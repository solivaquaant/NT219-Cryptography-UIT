
namespace RSA_GUI
{
    partial class Encrypt
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
            this.button_pubKey = new System.Windows.Forms.Button();
            this.textBox_pubKeyFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_plainText = new System.Windows.Forms.RichTextBox();
            this.button_plainText = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox_cipherText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_cHex = new System.Windows.Forms.RadioButton();
            this.radioButton_cBase64 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_kPEM = new System.Windows.Forms.RadioButton();
            this.radioButton_kBase64 = new System.Windows.Forms.RadioButton();
            this.radioButton_kBER = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Key Format:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Public Key File:";
            // 
            // button_pubKey
            // 
            this.button_pubKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_pubKey.Location = new System.Drawing.Point(536, 73);
            this.button_pubKey.Name = "button_pubKey";
            this.button_pubKey.Size = new System.Drawing.Size(88, 33);
            this.button_pubKey.TabIndex = 11;
            this.button_pubKey.Text = "Browse";
            this.button_pubKey.UseVisualStyleBackColor = true;
            this.button_pubKey.Click += new System.EventHandler(this.button_pubKey_Click);
            // 
            // textBox_pubKeyFile
            // 
            this.textBox_pubKeyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_pubKeyFile.Location = new System.Drawing.Point(187, 80);
            this.textBox_pubKeyFile.Name = "textBox_pubKeyFile";
            this.textBox_pubKeyFile.Size = new System.Drawing.Size(311, 26);
            this.textBox_pubKeyFile.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Plain Text:";
            // 
            // richTextBox_plainText
            // 
            this.richTextBox_plainText.Location = new System.Drawing.Point(187, 123);
            this.richTextBox_plainText.Name = "richTextBox_plainText";
            this.richTextBox_plainText.Size = new System.Drawing.Size(311, 96);
            this.richTextBox_plainText.TabIndex = 13;
            this.richTextBox_plainText.Text = "";
            // 
            // button_plainText
            // 
            this.button_plainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_plainText.Location = new System.Drawing.Point(536, 120);
            this.button_plainText.Name = "button_plainText";
            this.button_plainText.Size = new System.Drawing.Size(88, 33);
            this.button_plainText.TabIndex = 14;
            this.button_plainText.Text = "Browse";
            this.button_plainText.UseVisualStyleBackColor = true;
            this.button_plainText.Click += new System.EventHandler(this.button_plainText_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(536, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 62);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save to File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox_cipherText
            // 
            this.richTextBox_cipherText.Location = new System.Drawing.Point(187, 277);
            this.richTextBox_cipherText.Name = "richTextBox_cipherText";
            this.richTextBox_cipherText.ReadOnly = true;
            this.richTextBox_cipherText.Size = new System.Drawing.Size(311, 117);
            this.richTextBox_cipherText.TabIndex = 16;
            this.richTextBox_cipherText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cipher Text:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(480, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "Encrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(12, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Choose Cipher Text Format:";
            // 
            // radioButton_cHex
            // 
            this.radioButton_cHex.AutoSize = true;
            this.radioButton_cHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_cHex.Location = new System.Drawing.Point(251, 234);
            this.radioButton_cHex.Name = "radioButton_cHex";
            this.radioButton_cHex.Size = new System.Drawing.Size(60, 24);
            this.radioButton_cHex.TabIndex = 23;
            this.radioButton_cHex.TabStop = true;
            this.radioButton_cHex.Text = "Hex";
            this.radioButton_cHex.UseVisualStyleBackColor = true;
            // 
            // radioButton_cBase64
            // 
            this.radioButton_cBase64.AutoSize = true;
            this.radioButton_cBase64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_cBase64.Location = new System.Drawing.Point(348, 236);
            this.radioButton_cBase64.Name = "radioButton_cBase64";
            this.radioButton_cBase64.Size = new System.Drawing.Size(87, 24);
            this.radioButton_cBase64.TabIndex = 24;
            this.radioButton_cBase64.TabStop = true;
            this.radioButton_cBase64.Text = "Base64";
            this.radioButton_cBase64.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_kPEM);
            this.groupBox1.Controls.Add(this.radioButton_kBase64);
            this.groupBox1.Controls.Add(this.radioButton_kBER);
            this.groupBox1.Location = new System.Drawing.Point(187, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 48);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
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
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton_cBase64);
            this.Controls.Add(this.radioButton_cHex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox_cipherText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_plainText);
            this.Controls.Add(this.richTextBox_plainText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_pubKey);
            this.Controls.Add(this.textBox_pubKeyFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Encrypt";
            this.Text = "Task 3 - RSA - Encrypt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_pubKey;
        private System.Windows.Forms.TextBox textBox_pubKeyFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_plainText;
        private System.Windows.Forms.Button button_plainText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox_cipherText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_cHex;
        private System.Windows.Forms.RadioButton radioButton_cBase64;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_kPEM;
        private System.Windows.Forms.RadioButton radioButton_kBase64;
        private System.Windows.Forms.RadioButton radioButton_kBER;
    }
}