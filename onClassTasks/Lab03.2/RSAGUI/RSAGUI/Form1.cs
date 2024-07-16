using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //dll


namespace RSAGUI
{
    public partial class Form1 : Form
    {
        [DllImport("RSADLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "GenerateAndSaveRSAKeys")]
        public static extern void GenerateAndSaveRSAKeys(int keySize, string format, string privateKeyFile, string publicKeyFile);

        [DllImport("RSADLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "RSAencrypt")]
        public static extern void RSAencrypt(string format, string publicKeyFile, string PlaintextFile, string CiphertFile);

        [DllImport("RSADLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "RSAdecrypt")]
        public static extern void RSAdecrypt(string format, string privateKeyFile, string CiphertextFile, string PlaintextFile);

        public Form1()
        {
            InitializeComponent();
        }

        private void button_keyGen_Click(object sender, EventArgs e)
        {
            int keySize = int.Parse(txtKeySize.Text);
            string format = cboFormat.SelectedItem.ToString();
            GenerateAndSaveRSAKeys(keySize, format, txtPrivateKeyFile.Text, txtPublicKeyFile.Text);
            MessageBox.Show("Key Generated Successfully!");
        }

        private void button_enc_Click(object sender, EventArgs e)
        {
            string format = cboFormat_enc.SelectedItem.ToString();
            RSAencrypt(format, txtPublicKeyFile_enc.Text, txtPlainTextFile_enc.Text, txtCipherTextFile_enc.Text);
            MessageBox.Show("Encrypt Successfully!");
        }

        private void button_dec_Click(object sender, EventArgs e)
        {
            string format = cboFormat_dec.SelectedItem.ToString();
            RSAdecrypt(format, txtPrivateKeyFile_dec.Text, txtCipherTextFile_dec.Text, txtRecoverTextFile_dec.Text);
            MessageBox.Show("Decrypt Successfully!");
        }

    }
}
