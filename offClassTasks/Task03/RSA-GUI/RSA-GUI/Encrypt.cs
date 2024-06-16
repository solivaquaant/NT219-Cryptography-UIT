using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace RSA_GUI
{
    public partial class Encrypt : Form
    {
        [DllImport("RSA-DLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "RSAencrypt")]
        public static extern IntPtr RSAencrypt(string format, string publicKeyFile,
                                 string cipherTextFormat,
                                 string PlainText);

        public Encrypt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string eformat= "";
            if (radioButton_kBER.Checked) eformat= "BER";
            if (radioButton_kPEM.Checked) eformat = "PEM";
            if (radioButton_kBase64.Checked) eformat = "Base64";


            string publicKeyFile = textBox_pubKeyFile.Text;

            string cipherTextFormat = "";
            if (radioButton_cHex.Checked) cipherTextFormat = "Hex";
            if (radioButton_cBase64.Checked) cipherTextFormat = "Base64";

            string PlainText = richTextBox_plainText.Text;

            IntPtr resultPtr = RSAencrypt(eformat, publicKeyFile, cipherTextFormat, PlainText);
            string result = Marshal.PtrToStringAnsi(resultPtr);

            richTextBox_cipherText.Text = result;
        }

        private void button_pubKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_pubKeyFile.Text = ofd.FileName;
        }

        private void button_plainText_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox_plainText.Text = content;
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save cipher text to file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save encrypted text";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    File.WriteAllText(filePath, richTextBox_cipherText.Text);
                    MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
