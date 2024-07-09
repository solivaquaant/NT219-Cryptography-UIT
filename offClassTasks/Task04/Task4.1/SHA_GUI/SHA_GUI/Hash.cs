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
using System.IO;

namespace SHA_GUI
{
    public partial class Hash : Form
    {
        [DllImport("SHA_DLL.so", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "hashFunction")]
        public static extern IntPtr hashFunction(string algo, string inputMes, int length);
        public Hash()
        {
            InitializeComponent();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox_input.Text = content;
            fs.Close();
        }

        private void button_output_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save encrypted text";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    File.WriteAllText(filePath, richTextBox_output.Text);
                    MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_hash_Click(object sender, EventArgs e)
        {
            string algo = "";
            //Algo and length
            int length = 0;
            if (radioButton_SHA224.Checked)
            {
                algo = "SHA224";
            }
            else if (radioButton_SHA256.Checked)
            {
                algo = "SHA256";
            }
            else if (radioButton_SHA384.Checked)
            {
                algo = "SHA384";
            }
            else if (radioButton_SHA512.Checked)
            {
                algo = "SHA512";
            }
            else if (radioButton_SHA3_224.Checked)
            {
                algo = "SHA3_224";
            }
            else if (radioButton_SHA3_256.Checked)
            {
                algo = "SHA3_256";
            }
            else if (radioButton_SHA3_384.Checked)
            {
                algo = "SHA3_384";
            }
            else if (radioButton_SHA3_512.Checked)
            {
                algo = "SHA3_512";
            }
            else if (radioButton_SHAKE128.Checked)
            {
                algo = "SHAKE128";
                length = int.Parse(textBox_length.Text);
            }
            else if (radioButton_SHAKE256.Checked)
            {
                algo = "SHAKE256";
                length = int.Parse(textBox_length.Text);
            }
            else
            {
                algo = "Unknown";
            }
           

            IntPtr resultPtr = hashFunction(algo, richTextBox_input.Text, length);
            if (resultPtr == IntPtr.Zero)
            {
                MessageBox.Show("Hashing failed. The result is a null pointer.");
                return;
            }

            string result = Marshal.PtrToStringAnsi(resultPtr);
            richTextBox_output.Text = result;
        }

        private void radioButton_SHAKE128_CheckedChanged(object sender, EventArgs e)
        {
            textBox_length.ReadOnly = false;
        }

        private void radioButton_SHAKE256_CheckedChanged(object sender, EventArgs e)
        {
            textBox_length.ReadOnly = false;
        }

        private void radioButton_SHA224_CheckedChanged(object sender, EventArgs e)
        {
            textBox_length.ReadOnly = true;
        }

        private void radioButton_SHA256_CheckedChanged(object sender, EventArgs e)
        {
            textBox_length.ReadOnly = true;
        }

        private void radioButton_SHA384_CheckedChanged(object sender, EventArgs e)
        {
            textBox_length.ReadOnly = true;
        }

        private void radioButton_SHA512_CheckedChanged(object sender, EventArgs e)
        {
            textBox_length.ReadOnly = true;
        }

        private void radioButton_SHA3_224_CheckedChanged(object sender, EventArgs e)
        {
            textBox_length.ReadOnly = true;
        }

        private void radioButton_SHA3_256_CheckedChanged(object sender, EventArgs e)
        {
            textBox_length.ReadOnly = true;
        }

        private void radioButton_SHA3_384_CheckedChanged(object sender, EventArgs e)
        {
            textBox_length.ReadOnly = true;
        }

        private void radioButton_SHA3_512_CheckedChanged(object sender, EventArgs e)
        {
            textBox_length.ReadOnly = true;
        }
    }
}
