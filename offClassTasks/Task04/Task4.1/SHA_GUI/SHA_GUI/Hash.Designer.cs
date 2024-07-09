
namespace SHA_GUI
{
    partial class Hash
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
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.richTextBox_input = new System.Windows.Forms.RichTextBox();
            this.button_hash = new System.Windows.Forms.Button();
            this.button_output = new System.Windows.Forms.Button();
            this.button_input = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.radioButton_SHA3_512 = new System.Windows.Forms.RadioButton();
            this.radioButton_SHA3_384 = new System.Windows.Forms.RadioButton();
            this.radioButton_SHA3_256 = new System.Windows.Forms.RadioButton();
            this.radioButton_SHA3_224 = new System.Windows.Forms.RadioButton();
            this.radioButton_SHA512 = new System.Windows.Forms.RadioButton();
            this.radioButton_SHAKE128 = new System.Windows.Forms.RadioButton();
            this.radioButton_SHAKE256 = new System.Windows.Forms.RadioButton();
            this.radioButton_SHA384 = new System.Windows.Forms.RadioButton();
            this.radioButton_SHA256 = new System.Windows.Forms.RadioButton();
            this.radioButton_SHA224 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.Location = new System.Drawing.Point(100, 306);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.Size = new System.Drawing.Size(344, 96);
            this.richTextBox_output.TabIndex = 46;
            this.richTextBox_output.Text = "";
            // 
            // richTextBox_input
            // 
            this.richTextBox_input.Location = new System.Drawing.Point(100, 184);
            this.richTextBox_input.Name = "richTextBox_input";
            this.richTextBox_input.Size = new System.Drawing.Size(344, 96);
            this.richTextBox_input.TabIndex = 45;
            this.richTextBox_input.Text = "";
            // 
            // button_hash
            // 
            this.button_hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_hash.Location = new System.Drawing.Point(248, 406);
            this.button_hash.Name = "button_hash";
            this.button_hash.Size = new System.Drawing.Size(165, 44);
            this.button_hash.TabIndex = 44;
            this.button_hash.Text = "HASH";
            this.button_hash.UseVisualStyleBackColor = true;
            this.button_hash.Click += new System.EventHandler(this.button_hash_Click);
            // 
            // button_output
            // 
            this.button_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_output.Location = new System.Drawing.Point(475, 306);
            this.button_output.Name = "button_output";
            this.button_output.Size = new System.Drawing.Size(87, 62);
            this.button_output.TabIndex = 43;
            this.button_output.Text = "Save to file";
            this.button_output.UseVisualStyleBackColor = true;
            this.button_output.Click += new System.EventHandler(this.button_output_Click);
            // 
            // button_input
            // 
            this.button_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_input.Location = new System.Drawing.Point(475, 184);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(87, 66);
            this.button_input.TabIndex = 42;
            this.button_input.Text = "Read from file";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(27, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Length:";
            // 
            // textBox_length
            // 
            this.textBox_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_length.Location = new System.Drawing.Point(100, 130);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.ReadOnly = true;
            this.textBox_length.Size = new System.Drawing.Size(344, 26);
            this.textBox_length.TabIndex = 40;
            // 
            // radioButton_SHA3_512
            // 
            this.radioButton_SHA3_512.AutoSize = true;
            this.radioButton_SHA3_512.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_SHA3_512.Location = new System.Drawing.Point(469, 45);
            this.radioButton_SHA3_512.Name = "radioButton_SHA3_512";
            this.radioButton_SHA3_512.Size = new System.Drawing.Size(110, 24);
            this.radioButton_SHA3_512.TabIndex = 39;
            this.radioButton_SHA3_512.TabStop = true;
            this.radioButton_SHA3_512.Text = "SHA3_512";
            this.radioButton_SHA3_512.UseVisualStyleBackColor = true;
            this.radioButton_SHA3_512.CheckedChanged += new System.EventHandler(this.radioButton_SHA3_512_CheckedChanged);
            // 
            // radioButton_SHA3_384
            // 
            this.radioButton_SHA3_384.AutoSize = true;
            this.radioButton_SHA3_384.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_SHA3_384.Location = new System.Drawing.Point(351, 45);
            this.radioButton_SHA3_384.Name = "radioButton_SHA3_384";
            this.radioButton_SHA3_384.Size = new System.Drawing.Size(110, 24);
            this.radioButton_SHA3_384.TabIndex = 38;
            this.radioButton_SHA3_384.TabStop = true;
            this.radioButton_SHA3_384.Text = "SHA3_384";
            this.radioButton_SHA3_384.UseVisualStyleBackColor = true;
            this.radioButton_SHA3_384.CheckedChanged += new System.EventHandler(this.radioButton_SHA3_384_CheckedChanged);
            // 
            // radioButton_SHA3_256
            // 
            this.radioButton_SHA3_256.AutoSize = true;
            this.radioButton_SHA3_256.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_SHA3_256.Location = new System.Drawing.Point(229, 45);
            this.radioButton_SHA3_256.Name = "radioButton_SHA3_256";
            this.radioButton_SHA3_256.Size = new System.Drawing.Size(110, 24);
            this.radioButton_SHA3_256.TabIndex = 37;
            this.radioButton_SHA3_256.TabStop = true;
            this.radioButton_SHA3_256.Text = "SHA3_256";
            this.radioButton_SHA3_256.UseVisualStyleBackColor = true;
            this.radioButton_SHA3_256.CheckedChanged += new System.EventHandler(this.radioButton_SHA3_256_CheckedChanged);
            // 
            // radioButton_SHA3_224
            // 
            this.radioButton_SHA3_224.AutoSize = true;
            this.radioButton_SHA3_224.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_SHA3_224.Location = new System.Drawing.Point(100, 45);
            this.radioButton_SHA3_224.Name = "radioButton_SHA3_224";
            this.radioButton_SHA3_224.Size = new System.Drawing.Size(110, 24);
            this.radioButton_SHA3_224.TabIndex = 36;
            this.radioButton_SHA3_224.TabStop = true;
            this.radioButton_SHA3_224.Text = "SHA3_224";
            this.radioButton_SHA3_224.UseVisualStyleBackColor = true;
            this.radioButton_SHA3_224.CheckedChanged += new System.EventHandler(this.radioButton_SHA3_224_CheckedChanged);
            // 
            // radioButton_SHA512
            // 
            this.radioButton_SHA512.AutoSize = true;
            this.radioButton_SHA512.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_SHA512.Location = new System.Drawing.Point(469, 6);
            this.radioButton_SHA512.Name = "radioButton_SHA512";
            this.radioButton_SHA512.Size = new System.Drawing.Size(92, 24);
            this.radioButton_SHA512.TabIndex = 35;
            this.radioButton_SHA512.TabStop = true;
            this.radioButton_SHA512.Text = "SHA512";
            this.radioButton_SHA512.UseVisualStyleBackColor = true;
            this.radioButton_SHA512.CheckedChanged += new System.EventHandler(this.radioButton_SHA512_CheckedChanged);
            // 
            // radioButton_SHAKE128
            // 
            this.radioButton_SHAKE128.AutoSize = true;
            this.radioButton_SHAKE128.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_SHAKE128.Location = new System.Drawing.Point(100, 83);
            this.radioButton_SHAKE128.Name = "radioButton_SHAKE128";
            this.radioButton_SHAKE128.Size = new System.Drawing.Size(114, 24);
            this.radioButton_SHAKE128.TabIndex = 34;
            this.radioButton_SHAKE128.TabStop = true;
            this.radioButton_SHAKE128.Text = "SHAKE128";
            this.radioButton_SHAKE128.UseVisualStyleBackColor = true;
            this.radioButton_SHAKE128.CheckedChanged += new System.EventHandler(this.radioButton_SHAKE128_CheckedChanged);
            // 
            // radioButton_SHAKE256
            // 
            this.radioButton_SHAKE256.AutoSize = true;
            this.radioButton_SHAKE256.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_SHAKE256.Location = new System.Drawing.Point(229, 83);
            this.radioButton_SHAKE256.Name = "radioButton_SHAKE256";
            this.radioButton_SHAKE256.Size = new System.Drawing.Size(114, 24);
            this.radioButton_SHAKE256.TabIndex = 33;
            this.radioButton_SHAKE256.TabStop = true;
            this.radioButton_SHAKE256.Text = "SHAKE256";
            this.radioButton_SHAKE256.UseVisualStyleBackColor = true;
            this.radioButton_SHAKE256.CheckedChanged += new System.EventHandler(this.radioButton_SHAKE256_CheckedChanged);
            // 
            // radioButton_SHA384
            // 
            this.radioButton_SHA384.AutoSize = true;
            this.radioButton_SHA384.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_SHA384.Location = new System.Drawing.Point(351, 6);
            this.radioButton_SHA384.Name = "radioButton_SHA384";
            this.radioButton_SHA384.Size = new System.Drawing.Size(92, 24);
            this.radioButton_SHA384.TabIndex = 32;
            this.radioButton_SHA384.TabStop = true;
            this.radioButton_SHA384.Text = "SHA384";
            this.radioButton_SHA384.UseVisualStyleBackColor = true;
            this.radioButton_SHA384.CheckedChanged += new System.EventHandler(this.radioButton_SHA384_CheckedChanged);
            // 
            // radioButton_SHA256
            // 
            this.radioButton_SHA256.AutoSize = true;
            this.radioButton_SHA256.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_SHA256.Location = new System.Drawing.Point(229, 6);
            this.radioButton_SHA256.Name = "radioButton_SHA256";
            this.radioButton_SHA256.Size = new System.Drawing.Size(92, 24);
            this.radioButton_SHA256.TabIndex = 31;
            this.radioButton_SHA256.TabStop = true;
            this.radioButton_SHA256.Text = "SHA256";
            this.radioButton_SHA256.UseVisualStyleBackColor = true;
            this.radioButton_SHA256.CheckedChanged += new System.EventHandler(this.radioButton_SHA256_CheckedChanged);
            // 
            // radioButton_SHA224
            // 
            this.radioButton_SHA224.AutoSize = true;
            this.radioButton_SHA224.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_SHA224.Location = new System.Drawing.Point(100, 6);
            this.radioButton_SHA224.Name = "radioButton_SHA224";
            this.radioButton_SHA224.Size = new System.Drawing.Size(92, 24);
            this.radioButton_SHA224.TabIndex = 30;
            this.radioButton_SHA224.TabStop = true;
            this.radioButton_SHA224.Text = "SHA224";
            this.radioButton_SHA224.UseVisualStyleBackColor = true;
            this.radioButton_SHA224.CheckedChanged += new System.EventHandler(this.radioButton_SHA224_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(27, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Output:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(27, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Input:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(27, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Algo:";
            // 
            // Hash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 468);
            this.Controls.Add(this.richTextBox_output);
            this.Controls.Add(this.richTextBox_input);
            this.Controls.Add(this.button_hash);
            this.Controls.Add(this.button_output);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_length);
            this.Controls.Add(this.radioButton_SHA3_512);
            this.Controls.Add(this.radioButton_SHA3_384);
            this.Controls.Add(this.radioButton_SHA3_256);
            this.Controls.Add(this.radioButton_SHA3_224);
            this.Controls.Add(this.radioButton_SHA512);
            this.Controls.Add(this.radioButton_SHAKE128);
            this.Controls.Add(this.radioButton_SHAKE256);
            this.Controls.Add(this.radioButton_SHA384);
            this.Controls.Add(this.radioButton_SHA256);
            this.Controls.Add(this.radioButton_SHA224);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hash";
            this.Text = "Hash Functions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_output;
        private System.Windows.Forms.RichTextBox richTextBox_input;
        private System.Windows.Forms.Button button_hash;
        private System.Windows.Forms.Button button_output;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.RadioButton radioButton_SHA3_512;
        private System.Windows.Forms.RadioButton radioButton_SHA3_384;
        private System.Windows.Forms.RadioButton radioButton_SHA3_256;
        private System.Windows.Forms.RadioButton radioButton_SHA3_224;
        private System.Windows.Forms.RadioButton radioButton_SHA512;
        private System.Windows.Forms.RadioButton radioButton_SHAKE128;
        private System.Windows.Forms.RadioButton radioButton_SHAKE256;
        private System.Windows.Forms.RadioButton radioButton_SHA384;
        private System.Windows.Forms.RadioButton radioButton_SHA256;
        private System.Windows.Forms.RadioButton radioButton_SHA224;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

