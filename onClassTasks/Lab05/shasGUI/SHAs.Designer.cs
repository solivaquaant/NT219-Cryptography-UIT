
namespace shasGUI
{
    partial class SHAs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_algo = new System.Windows.Forms.ComboBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.button_hash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(311, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algorithm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(91, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(472, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output File:";
            // 
            // comboBox_algo
            // 
            this.comboBox_algo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBox_algo.FormattingEnabled = true;
            this.comboBox_algo.Items.AddRange(new object[] {
            "SHA224",
            "SHA256",
            "SHA384",
            "SHA512",
            "SHA512-224",
            "SHA512-256",
            "SHA3-224",
            "SHA3-256",
            "SHA3-384",
            "SHA3-512",
            "SHAKE128",
            "SHAKE256"});
            this.comboBox_algo.Location = new System.Drawing.Point(291, 137);
            this.comboBox_algo.Name = "comboBox_algo";
            this.comboBox_algo.Size = new System.Drawing.Size(176, 37);
            this.comboBox_algo.TabIndex = 3;
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_input.Location = new System.Drawing.Point(96, 263);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(250, 36);
            this.textBox_input.TabIndex = 4;
            // 
            // textBox_output
            // 
            this.textBox_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_output.Location = new System.Drawing.Point(477, 263);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(250, 36);
            this.textBox_output.TabIndex = 5;
            // 
            // button_hash
            // 
            this.button_hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_hash.Location = new System.Drawing.Point(304, 342);
            this.button_hash.Name = "button_hash";
            this.button_hash.Size = new System.Drawing.Size(177, 50);
            this.button_hash.TabIndex = 6;
            this.button_hash.Text = "Start Hashing";
            this.button_hash.UseVisualStyleBackColor = true;
            this.button_hash.Click += new System.EventHandler(this.button_hash_Click);
            // 
            // SHAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_hash);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.comboBox_algo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SHAs";
            this.Text = "SHAs-GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_algo;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Button button_hash;
    }
}

