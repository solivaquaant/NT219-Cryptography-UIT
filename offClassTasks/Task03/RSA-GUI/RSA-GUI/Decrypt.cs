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


namespace RSA_GUI
{
    public partial class Decrypt : Form
    {
        [DllImport("RSA-DLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "RSAdecrypt")]
        public static extern IntPtr RSAdecrypt(string format, string privateKeyFile,
                                string cipherTextFormat,
                                string CipherText);
        public Decrypt()
        {
            InitializeComponent();
        }

        private void button_priKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_priKeyFile.Text = ofd.FileName;
        }

        private void button_cipherText_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox_cipherText.Text = content;
            fs.Close();
        }

        private void button_saveRecover_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save encrypted text";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    File.WriteAllText(filePath, richTextBox_recoverText.Text);
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
            string kformat = "";
            if (radioButton_kBER.Checked) kformat = "BER";
            if (radioButton_kPEM.Checked) kformat = "PEM";
            if (radioButton_kBase64.Checked) kformat = "Base64";


            string priKeyFile = textBox_priKeyFile.Text;

            string cipherTextFormat = "";
            if (radioButton_cHex.Checked) cipherTextFormat = "Hex";
            if (radioButton_cBase64.Checked) cipherTextFormat = "Base64";

            string cipherText = richTextBox_cipherText.Text;

            IntPtr resultPtr = RSAdecrypt(kformat, priKeyFile, cipherTextFormat, cipherText);
            string result = Marshal.PtrToStringAnsi(resultPtr);

            richTextBox_recoverText.Text = result;
        }
    }
}
