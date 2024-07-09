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

namespace AES_GUI
{
    public partial class GenKeyIV : Form
    {
        [DllImport("AES_DLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GenerateKeyAndIV")]
        public static extern void GenerateKeyAndIV(string mode, int keySize, string format, string keyFile, string ivFile);

        public GenKeyIV()
        {
            InitializeComponent();
        }

        private void button_genKey_Click(object sender, EventArgs e)
        {
            string mode = "";
            if (radioButton_ECB.Checked) mode = "ECB";
            if (radioButton_CBC.Checked) mode = "CBC";
            if (radioButton_OFB.Checked) mode = "OFB";
            if (radioButton_CFB.Checked) mode = "CFB";
            if (radioButton_CTR.Checked) mode = "CTR";
            if (radioButton_XTS.Checked) mode = "XTS";
            if (radioButton_CCM.Checked) mode = "CCM";
            if (radioButton_GCM.Checked) mode = "GCM";

            int keySize = int.Parse(textBox_kSize.Text);

            string format = "";
            if (radioButton_Binary.Checked) format = "Binary";
            if (radioButton_Hex.Checked) format = "Hex";
            if (radioButton_Base64.Checked) format = "Base64";

            string keyFile = textBox_kFile.Text;
            string ivFile = textBox_ivFile.Text;

            GenerateKeyAndIV(mode, keySize, format, keyFile, ivFile);
            MessageBox.Show("Generate Key and IV successfully!");


        }

        private void button_kFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_kFile.Text = ofd.FileName;
        }

        private void button_ivFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_ivFile.Text = ofd.FileName;
        }
    }
}
