using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;


namespace DES_GUI
{
    public partial class Decrypt : Form
    {
        [DllImport("DES_DLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "DESDecrypt")]
        public static extern IntPtr DESDecrypt(string mode, string keyIVFormat, string keyFile, string ivFile,
                                    string cipherFormat,
                                    string cipherText);
        public Decrypt()
        {
            InitializeComponent();
        }

        private void button_kFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_kFile.Text = ofd.FileName;
        }

        private void button_ivFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_ivFile.Text = ofd.FileName;
        }

        private void button_cFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox_cText.Text = content;
            fs.Close();
        }

        private void button_rFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save encrypted text";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    File.WriteAllText(filePath, richTextBox_rText.Text);
                    MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {
            string mode = "";
            if (radioButton_ECB.Checked) mode = "ECB";
            if (radioButton_CBC.Checked) mode = "CBC";
            if (radioButton_OFB.Checked) mode = "OFB";
            if (radioButton_CFB.Checked) mode = "CFB";
            if (radioButton_CTR.Checked) mode = "CTR";

            string format = "";
            if (radioButton_Binary.Checked) format = "Binary";
            if (radioButton_Hex.Checked) format = "Hex";
            if (radioButton_Base64.Checked) format = "Base64";

            string keyFile = textBox_kFile.Text;
            string ivFile = textBox_ivFile.Text;

            string cFormat = "";
            if (radioButton_cHex.Checked) cFormat = "Hex";
            if (radioButton_cBase64.Checked) cFormat = "Base64";

            string cipherText = richTextBox_cText.Text;

            // Gọi hàm AESEncrypt từ DLL
            IntPtr resultPtr = DESDecrypt(mode, format, keyFile, ivFile, cFormat, cipherText);
            // IntPtr resultPtr = AESEncrypt("CBC","Hex","key.txt", "iv.txt", "Hex", "Con meof");

            if (resultPtr == IntPtr.Zero)
            {
                MessageBox.Show("Encryption failed. The result is a null pointer.");
                return;
            }

            string result = Marshal.PtrToStringAnsi(resultPtr);
            richTextBox_rText.Text = result;
        }
    }
}
