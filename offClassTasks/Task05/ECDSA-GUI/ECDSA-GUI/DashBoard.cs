using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECDSA_GUI
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void button_keyGen_Click(object sender, EventArgs e)
        {
            KeyGen form = new KeyGen();
            form.Show();
        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            Sign form = new Sign();
            form.Show();
        }

        private void button_verify_Click(object sender, EventArgs e)
        {
           Verify form = new Verify();
            form.Show();
        }
    }
}
