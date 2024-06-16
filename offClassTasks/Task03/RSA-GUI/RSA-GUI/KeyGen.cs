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


namespace RSA_GUI
{
    public partial class KeyGen : Form
    {
        [DllImport("RSA-DLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GenerateAndSaveRSAKeys")]
        public static extern void GenerateAndSaveRSAKeys(int keySize, string format, string privateKeyFile, string publicKeyFile);
        public KeyGen()
        {
            InitializeComponent();
        }
        private void button_priKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_priKeyFile.Text = ofd.FileName;
        }
        private void button_pubKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_pubKeyFile.Text = ofd.FileName;
        }
        private void button_keyGen_Click(object sender, EventArgs e)
        {
            int keySize = int.Parse(textBox_keySize.Text);

            string format="";
            if (radioBtn_DER.Checked) format = "DER";
            if (radioBtn_PEM.Checked) format = "PEM";
            if (radioBtn_Base64.Checked) format = "Base64";
            MessageBox.Show(format);

            string privateKeyFile = textBox_priKeyFile.Text;
            string publicKeyFile = textBox_pubKeyFile.Text;

            GenerateAndSaveRSAKeys(keySize, format, privateKeyFile, publicKeyFile);
            MessageBox.Show("Generate and Save Keys Successfully!");
        }
    }
}
