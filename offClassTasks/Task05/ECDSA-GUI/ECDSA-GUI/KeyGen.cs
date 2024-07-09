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

namespace ECDSA_GUI
{
    public partial class KeyGen : Form
    {
        [DllImport("ECDSA-DLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GenerateKeys")]
        public static extern bool GenerateKeys(string format, string privateKeyFile, string publicKeyFile);
        [DllImport("ECDSA-DLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "sign")]
        public static extern bool sign(string privateKeyFile, string fileName, string signFile);
        [DllImport("ECDSA-DLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "verify")]
        public static extern bool verify(string publicKeyFile, string fileName, string signFile);
        public KeyGen()
        {
            InitializeComponent();
        }

        private void button_browsePrivate_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_privateKeyFile.Text = ofd.FileName;
        }

        private void button_browsePublic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_publicKeyFile.Text = ofd.FileName;
        }

        private void button_keygen_Click(object sender, EventArgs e)
        {
            string format = "BER";
            if (radioButton_BER.Checked)
                format = "BER";
            else if (radioButton_PEM.Checked)
                format = "PEM";
            
            string privateKeyFile = textBox_privateKeyFile.Text;
            string publicKeyFile = textBox_publicKeyFile.Text;

            if(GenerateKeys(format, privateKeyFile,publicKeyFile))
            {
                MessageBox.Show("Generate Keys successfully!");
            }    
            else
                MessageBox.Show("Generate Keys unsuccessfully!");

        }
    }
}
