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


namespace shasGUI
{
    public partial class SHAs : Form
    {
        [DllImport("shas.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z6hashesPKcS0_S0_")]
        public static extern void hashes(string algo, string inputFilename, string outputFilename);

        public SHAs()
        {
            InitializeComponent();
        }

        private void button_hash_Click(object sender, EventArgs e)
        {
            string algo = comboBox_algo.SelectedItem.ToString();
            hashes(algo, textBox_input.Text, textBox_output.Text);
            MessageBox.Show("Hash function successfully!");
        
        }
    }
}
