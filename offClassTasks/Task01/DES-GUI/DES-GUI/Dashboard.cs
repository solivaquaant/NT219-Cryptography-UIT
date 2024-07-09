using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DES_GUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button_genkey_Click(object sender, EventArgs e)
        {
            GenKey form = new GenKey();
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
