
namespace RSAGUI
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboFormat = new System.Windows.Forms.ComboBox();
            this.txtPublicKeyFile = new System.Windows.Forms.TextBox();
            this.txtPrivateKeyFile = new System.Windows.Forms.TextBox();
            this.txtKeySize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCipherTextFile_enc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_enc = new System.Windows.Forms.Button();
            this.txtPublicKeyFile_enc = new System.Windows.Forms.TextBox();
            this.txtPlainTextFile_enc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboFormat_enc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_dec = new System.Windows.Forms.Button();
            this.txtRecoverTextFile_dec = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrivateKeyFile_dec = new System.Windows.Forms.TextBox();
            this.txtCipherTextFile_dec = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboFormat_dec = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_keyGen = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_keyGen);
            this.tabPage1.Controls.Add(this.cboFormat);
            this.tabPage1.Controls.Add(this.txtPublicKeyFile);
            this.tabPage1.Controls.Add(this.txtPrivateKeyFile);
            this.tabPage1.Controls.Add(this.txtKeySize);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Key Gen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboFormat
            // 
            this.cboFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cboFormat.FormattingEnabled = true;
            this.cboFormat.Items.AddRange(new object[] {
            "DER",
            "Base64"});
            this.cboFormat.Location = new System.Drawing.Point(417, 104);
            this.cboFormat.Name = "cboFormat";
            this.cboFormat.Size = new System.Drawing.Size(121, 37);
            this.cboFormat.TabIndex = 7;
            // 
            // txtPublicKeyFile
            // 
            this.txtPublicKeyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPublicKeyFile.Location = new System.Drawing.Point(417, 261);
            this.txtPublicKeyFile.Name = "txtPublicKeyFile";
            this.txtPublicKeyFile.Size = new System.Drawing.Size(191, 36);
            this.txtPublicKeyFile.TabIndex = 6;
            // 
            // txtPrivateKeyFile
            // 
            this.txtPrivateKeyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPrivateKeyFile.Location = new System.Drawing.Point(44, 261);
            this.txtPrivateKeyFile.Name = "txtPrivateKeyFile";
            this.txtPrivateKeyFile.Size = new System.Drawing.Size(191, 36);
            this.txtPrivateKeyFile.TabIndex = 5;
            // 
            // txtKeySize
            // 
            this.txtKeySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtKeySize.Location = new System.Drawing.Point(44, 104);
            this.txtKeySize.Name = "txtKeySize";
            this.txtKeySize.Size = new System.Drawing.Size(148, 36);
            this.txtKeySize.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(412, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Public Key File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(39, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Private Key File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(412, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key Size";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCipherTextFile_enc);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button_enc);
            this.tabPage2.Controls.Add(this.txtPublicKeyFile_enc);
            this.tabPage2.Controls.Add(this.txtPlainTextFile_enc);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cboFormat_enc);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCipherTextFile_enc
            // 
            this.txtCipherTextFile_enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCipherTextFile_enc.Location = new System.Drawing.Point(427, 245);
            this.txtCipherTextFile_enc.Name = "txtCipherTextFile_enc";
            this.txtCipherTextFile_enc.Size = new System.Drawing.Size(191, 36);
            this.txtCipherTextFile_enc.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(422, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cipher Text File";
            // 
            // button_enc
            // 
            this.button_enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_enc.Location = new System.Drawing.Point(206, 315);
            this.button_enc.Name = "button_enc";
            this.button_enc.Size = new System.Drawing.Size(319, 63);
            this.button_enc.TabIndex = 14;
            this.button_enc.Text = "START ENCRYPTION";
            this.button_enc.UseVisualStyleBackColor = true;
            this.button_enc.Click += new System.EventHandler(this.button_enc_Click);
            // 
            // txtPublicKeyFile_enc
            // 
            this.txtPublicKeyFile_enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPublicKeyFile_enc.Location = new System.Drawing.Point(427, 96);
            this.txtPublicKeyFile_enc.Name = "txtPublicKeyFile_enc";
            this.txtPublicKeyFile_enc.Size = new System.Drawing.Size(191, 36);
            this.txtPublicKeyFile_enc.TabIndex = 13;
            // 
            // txtPlainTextFile_enc
            // 
            this.txtPlainTextFile_enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPlainTextFile_enc.Location = new System.Drawing.Point(57, 245);
            this.txtPlainTextFile_enc.Name = "txtPlainTextFile_enc";
            this.txtPlainTextFile_enc.Size = new System.Drawing.Size(191, 36);
            this.txtPlainTextFile_enc.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(422, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Public Key File";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(52, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Plain Text File";
            // 
            // cboFormat_enc
            // 
            this.cboFormat_enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cboFormat_enc.FormattingEnabled = true;
            this.cboFormat_enc.Items.AddRange(new object[] {
            "DER",
            "Base64"});
            this.cboFormat_enc.Location = new System.Drawing.Point(57, 95);
            this.cboFormat_enc.Name = "cboFormat_enc";
            this.cboFormat_enc.Size = new System.Drawing.Size(121, 37);
            this.cboFormat_enc.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(52, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Format";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_dec);
            this.tabPage3.Controls.Add(this.txtRecoverTextFile_dec);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtPrivateKeyFile_dec);
            this.tabPage3.Controls.Add(this.txtCipherTextFile_dec);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cboFormat_dec);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 384);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Decrypt";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_dec
            // 
            this.button_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_dec.Location = new System.Drawing.Point(206, 296);
            this.button_dec.Name = "button_dec";
            this.button_dec.Size = new System.Drawing.Size(319, 63);
            this.button_dec.TabIndex = 25;
            this.button_dec.Text = "START DECRYPTION";
            this.button_dec.UseVisualStyleBackColor = true;
            this.button_dec.Click += new System.EventHandler(this.button_dec_Click);
            // 
            // txtRecoverTextFile_dec
            // 
            this.txtRecoverTextFile_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtRecoverTextFile_dec.Location = new System.Drawing.Point(439, 234);
            this.txtRecoverTextFile_dec.Name = "txtRecoverTextFile_dec";
            this.txtRecoverTextFile_dec.Size = new System.Drawing.Size(191, 36);
            this.txtRecoverTextFile_dec.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(434, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Recover Text File";
            // 
            // txtPrivateKeyFile_dec
            // 
            this.txtPrivateKeyFile_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPrivateKeyFile_dec.Location = new System.Drawing.Point(439, 85);
            this.txtPrivateKeyFile_dec.Name = "txtPrivateKeyFile_dec";
            this.txtPrivateKeyFile_dec.Size = new System.Drawing.Size(191, 36);
            this.txtPrivateKeyFile_dec.TabIndex = 22;
            // 
            // txtCipherTextFile_dec
            // 
            this.txtCipherTextFile_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCipherTextFile_dec.Location = new System.Drawing.Point(69, 234);
            this.txtCipherTextFile_dec.Name = "txtCipherTextFile_dec";
            this.txtCipherTextFile_dec.Size = new System.Drawing.Size(191, 36);
            this.txtCipherTextFile_dec.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(434, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 29);
            this.label10.TabIndex = 20;
            this.label10.Text = "Private Key File";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(64, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 29);
            this.label11.TabIndex = 19;
            this.label11.Text = "Cipher Text File";
            // 
            // cboFormat_dec
            // 
            this.cboFormat_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cboFormat_dec.FormattingEnabled = true;
            this.cboFormat_dec.Items.AddRange(new object[] {
            "DER",
            "Base64"});
            this.cboFormat_dec.Location = new System.Drawing.Point(69, 84);
            this.cboFormat_dec.Name = "cboFormat_dec";
            this.cboFormat_dec.Size = new System.Drawing.Size(121, 37);
            this.cboFormat_dec.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.Location = new System.Drawing.Point(64, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 29);
            this.label12.TabIndex = 17;
            this.label12.Text = "Format";
            // 
            // button_keyGen
            // 
            this.button_keyGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_keyGen.Location = new System.Drawing.Point(203, 307);
            this.button_keyGen.Name = "button_keyGen";
            this.button_keyGen.Size = new System.Drawing.Size(319, 63);
            this.button_keyGen.TabIndex = 15;
            this.button_keyGen.Text = "START KEY GEN";
            this.button_keyGen.UseVisualStyleBackColor = true;
            this.button_keyGen.Click += new System.EventHandler(this.button_keyGen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "RSA";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtPublicKeyFile;
        private System.Windows.Forms.TextBox txtPrivateKeyFile;
        private System.Windows.Forms.TextBox txtKeySize;
        private System.Windows.Forms.ComboBox cboFormat;
        private System.Windows.Forms.ComboBox cboFormat_enc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCipherTextFile_enc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_enc;
        private System.Windows.Forms.TextBox txtPublicKeyFile_enc;
        private System.Windows.Forms.TextBox txtPlainTextFile_enc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRecoverTextFile_dec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrivateKeyFile_dec;
        private System.Windows.Forms.TextBox txtCipherTextFile_dec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboFormat_dec;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_dec;
        private System.Windows.Forms.Button button_keyGen;
    }
}

