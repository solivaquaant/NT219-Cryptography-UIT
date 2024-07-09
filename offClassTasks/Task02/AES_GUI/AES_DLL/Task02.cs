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

namespace AES_DLL
{
    public partial class Task02 : Form
    {
        [DllImport("AES_DLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "AESEncrypt")]
        public static extern IntPtr AESEncrypt(string keyFile, string ivFile, string plainText);
        [DllImport("AES_DLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "AESDecrypt")]
        public static extern IntPtr AESDecrypt(string keyFile, string ivFile, string cipherText);
  

    public Task02()
        {
            InitializeComponent();
        }

        private void button_enc_Click(object sender, EventArgs e)
        {
            string keyFile = textBox_ekFile.Text;
            string ivFiile = textBox_ekFile.Text;
            string plainText = richTextBox_epText.Text;

            IntPtr resultPtr = AESEncrypt(keyFile,ivFiile,plainText);

            if (resultPtr == IntPtr.Zero)
            {
                MessageBox.Show("Encryption failed. The result is a null pointer.");
                return;
            }

            string result = Marshal.PtrToStringAnsi(resultPtr);
            richTextBox_ecText.Text = result;
        }

        private void button_ekFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_ekFile.Text = ofd.FileName;
        }

        private void button_eivFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_eivFile.Text = ofd.FileName;
        }

        private void button_epText_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox_epText.Text = content;
            fs.Close();
        }

        private void button_ecText_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save encrypted text";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    File.WriteAllText(filePath, richTextBox_ecText.Text);
                    MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Decrypt
        private void button_dec_Click(object sender, EventArgs e)
        {
            string keyFile1 = textBox_dkFile.Text;
            string ivFile1 = textBox_divFile.Text;
            string cipherText1 = richTextBox_dcText.Text;

            IntPtr resultPtr1 = AESDecrypt(keyFile1, ivFile1, cipherText1);

            if (resultPtr1 == IntPtr.Zero)
            {
                MessageBox.Show("Encryption failed. The result is a null pointer.");
                return;
            }

            string result = Marshal.PtrToStringAnsi(resultPtr1);
            richTextBox_drText.Text = result;
        }

        private void button_dkFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_dkFile.Text = ofd.FileName;
        }
    

        private void button_divFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_divFile.Text = ofd.FileName;
        
        }

        private void button_dcFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox_dcText.Text = content;
            fs.Close();
        }

        private void button_drFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save encrypted text";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    File.WriteAllText(filePath, richTextBox_drText.Text);
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
