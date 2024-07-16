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

namespace digital_openssl_GUI
{
    public partial class Form1 : Form
    {
        [DllImport("digital-opensslDLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "signPdf")]
        public static extern bool signPdf(string privateKeyPath, string pdfPath, string signaturePath);

        [DllImport("digital-opensslDLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "verifySignature")]
        public static extern bool verifySignature(string publicKeyPath, string pdfPath, string signaturePath);




        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if(signPdf(textBoxSign_privateKey.Text, textBoxSign_pdfFile.Text, textBoxSign_signFile.Text))
            {
                MessageBox.Show("Hash function successfully!");

            }
            else
            {
                MessageBox.Show("No");

            }

        }

        private void buttonOpen_privateKeyFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBoxSign_privateKey.Text = ofd.FileName;        
        }

        private void buttonOpen_pdfFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBoxSign_pdfFile.Text = ofd.FileName;
        }
    }
}
