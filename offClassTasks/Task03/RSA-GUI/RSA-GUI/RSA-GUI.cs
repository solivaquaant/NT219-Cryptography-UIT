using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_GUI
{
    public partial class RSA_GUI : Form
    {
        public RSA_GUI()
        {
            InitializeComponent();
        }

        private void button_keyGen_Click(object sender, EventArgs e)
        {
            KeyGen form = new KeyGen();
            form.Show();
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            Encrypt form = new Encrypt();
            form.Show();
        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {
            Decrypt form = new Decrypt();
            form.Show();
        }
    }
}
