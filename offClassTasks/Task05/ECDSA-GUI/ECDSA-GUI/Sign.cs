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
    public partial class Sign : Form
    {
        [DllImport("ECDSA-DLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GenerateKeys")]
        public static extern bool GenerateKeys(string format, string privateKeyFile, string publicKeyFile);
        [DllImport("ECDSA-DLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "sign")]
        public static extern bool sign(string privateKeyFile, string fileName, string signFile);
        [DllImport("ECDSA-DLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "verify")]
        public static extern bool verify(string publicKeyFile, string fileName, string signFile);
        public Sign()
        {
            InitializeComponent();
        }

        private void button_priKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_priKey.Text = ofd.FileName;
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_input.Text = ofd.FileName;
        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_sign.Text = ofd.FileName;
        }

        private void button_doSign_Click(object sender, EventArgs e)
        {
            if (sign(textBox_priKey.Text, textBox_input.Text, textBox_sign.Text))
            {
                MessageBox.Show("Sign file successfully!");
            }
            else
                MessageBox.Show("Sign file unsuccessfully!");
        }
    }
}
