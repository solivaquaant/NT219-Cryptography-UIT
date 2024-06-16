
namespace RSA_GUI
{
    partial class Decrypt
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
            this.radioButton_kPEM = new System.Windows.Forms.RadioButton();
            this.radioButton_kBER = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_kBase64 = new System.Windows.Forms.RadioButton();
            this.radioButton_cBase64 = new System.Windows.Forms.RadioButton();
            this.radioButton_cHex = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.button_saveRecover = new System.Windows.Forms.Button();
            this.richTextBox_recoverText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_cipherText = new System.Windows.Forms.Button();
            this.richTextBox_cipherText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_priKey = new System.Windows.Forms.Button();
            this.textBox_priKeyFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_kPEM
            // 
            this.radioButton_kPEM.AutoSize = true;
            this.radioButton_kPEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_kPEM.Location = new System.Drawing.Point(114, 12);
            this.radioButton_kPEM.Name = "radioButton_kPEM";
            this.radioButton_kPEM.Size = new System.Drawing.Size(66, 24);
            this.radioButton_kPEM.TabIndex = 25;
            this.radioButton_kPEM.TabStop = true;
            this.radioButton_kPEM.Text = "PEM";
            this.radioButton_kPEM.UseVisualStyleBackColor = true;
            // 
            // radioButton_kBER
            // 
            this.radioButton_kBER.AutoSize = true;
            this.radioButton_kBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_kBER.Location = new System.Drawing.Point(21, 12);
            this.radioButton_kBER.Name = "radioButton_kBER";
            this.radioButton_kBER.Size = new System.Drawing.Size(65, 24);
            this.radioButton_kBER.TabIndex = 23;
            this.radioButton_kBER.TabStop = true;
            this.radioButton_kBER.Text = "BER";
            this.radioButton_kBER.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_kPEM);
            this.groupBox1.Controls.Add(this.radioButton_kBase64);
            this.groupBox1.Controls.Add(this.radioButton_kBER);
            this.groupBox1.Location = new System.Drawing.Point(197, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 48);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_kBase64
            // 
            this.radioButton_kBase64.AutoSize = true;
            this.radioButton_kBase64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_kBase64.Location = new System.Drawing.Point(202, 12);
            this.radioButton_kBase64.Name = "radioButton_kBase64";
            this.radioButton_kBase64.Size = new System.Drawing.Size(87, 24);
            this.radioButton_kBase64.TabIndex = 24;
            this.radioButton_kBase64.TabStop = true;
            this.radioButton_kBase64.Text = "Base64";
            this.radioButton_kBase64.UseVisualStyleBackColor = true;
            // 
            // radioButton_cBase64
            // 
            this.radioButton_cBase64.AutoSize = true;
            this.radioButton_cBase64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_cBase64.Location = new System.Drawing.Point(358, 229);
            this.radioButton_cBase64.Name = "radioButton_cBase64";
            this.radioButton_cBase64.Size = new System.Drawing.Size(87, 24);
            this.radioButton_cBase64.TabIndex = 39;
            this.radioButton_cBase64.TabStop = true;
            this.radioButton_cBase64.Text = "Base64";
            this.radioButton_cBase64.UseVisualStyleBackColor = true;
            // 
            // radioButton_cHex
            // 
            this.radioButton_cHex.AutoSize = true;
            this.radioButton_cHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_cHex.Location = new System.Drawing.Point(261, 227);
            this.radioButton_cHex.Name = "radioButton_cHex";
            this.radioButton_cHex.Size = new System.Drawing.Size(60, 24);
            this.radioButton_cHex.TabIndex = 38;
            this.radioButton_cHex.TabStop = true;
            this.radioButton_cHex.Text = "Hex";
            this.radioButton_cHex.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(22, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Choose Cipher Text Format:";
            // 
            // button_decrypt
            // 
            this.button_decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_decrypt.Location = new System.Drawing.Point(490, 420);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(144, 40);
            this.button_decrypt.TabIndex = 36;
            this.button_decrypt.Text = "Decrypt";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // button_saveRecover
            // 
            this.button_saveRecover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_saveRecover.Location = new System.Drawing.Point(546, 267);
            this.button_saveRecover.Name = "button_saveRecover";
            this.button_saveRecover.Size = new System.Drawing.Size(88, 62);
            this.button_saveRecover.TabIndex = 35;
            this.button_saveRecover.Text = "Save to File";
            this.button_saveRecover.UseVisualStyleBackColor = true;
            this.button_saveRecover.Click += new System.EventHandler(this.button_saveRecover_Click);
            // 
            // richTextBox_recoverText
            // 
            this.richTextBox_recoverText.Location = new System.Drawing.Point(197, 270);
            this.richTextBox_recoverText.Name = "richTextBox_recoverText";
            this.richTextBox_recoverText.ReadOnly = true;
            this.richTextBox_recoverText.Size = new System.Drawing.Size(311, 117);
            this.richTextBox_recoverText.TabIndex = 34;
            this.richTextBox_recoverText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(22, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Recover Text:";
            // 
            // button_cipherText
            // 
            this.button_cipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_cipherText.Location = new System.Drawing.Point(546, 113);
            this.button_cipherText.Name = "button_cipherText";
            this.button_cipherText.Size = new System.Drawing.Size(88, 33);
            this.button_cipherText.TabIndex = 32;
            this.button_cipherText.Text = "Browse";
            this.button_cipherText.UseVisualStyleBackColor = true;
            this.button_cipherText.Click += new System.EventHandler(this.button_cipherText_Click);
            // 
            // richTextBox_cipherText
            // 
            this.richTextBox_cipherText.Location = new System.Drawing.Point(197, 116);
            this.richTextBox_cipherText.Name = "richTextBox_cipherText";
            this.richTextBox_cipherText.Size = new System.Drawing.Size(311, 96);
            this.richTextBox_cipherText.TabIndex = 31;
            this.richTextBox_cipherText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cipher Text:";
            // 
            // button_priKey
            // 
            this.button_priKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_priKey.Location = new System.Drawing.Point(546, 66);
            this.button_priKey.Name = "button_priKey";
            this.button_priKey.Size = new System.Drawing.Size(88, 33);
            this.button_priKey.TabIndex = 29;
            this.button_priKey.Text = "Browse";
            this.button_priKey.UseVisualStyleBackColor = true;
            this.button_priKey.Click += new System.EventHandler(this.button_priKey_Click);
            // 
            // textBox_priKeyFile
            // 
            this.textBox_priKeyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_priKeyFile.Location = new System.Drawing.Point(197, 73);
            this.textBox_priKeyFile.Name = "textBox_priKeyFile";
            this.textBox_priKeyFile.Size = new System.Drawing.Size(311, 26);
            this.textBox_priKeyFile.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Private Key File:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Choose Key Format:";
            // 
            // Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton_cBase64);
            this.Controls.Add(this.radioButton_cHex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.button_saveRecover);
            this.Controls.Add(this.richTextBox_recoverText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_cipherText);
            this.Controls.Add(this.richTextBox_cipherText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_priKey);
            this.Controls.Add(this.textBox_priKeyFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Decrypt";
            this.Text = "Task 3 - RSA - Encrypt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_kPEM;
        private System.Windows.Forms.RadioButton radioButton_kBER;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_kBase64;
        private System.Windows.Forms.RadioButton radioButton_cBase64;
        private System.Windows.Forms.RadioButton radioButton_cHex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.Button button_saveRecover;
        private System.Windows.Forms.RichTextBox richTextBox_recoverText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_cipherText;
        private System.Windows.Forms.RichTextBox richTextBox_cipherText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_priKey;
        private System.Windows.Forms.TextBox textBox_priKeyFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}