
namespace DES_GUI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_cBase64 = new System.Windows.Forms.RadioButton();
            this.radioButton_cHex = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.button_pFile = new System.Windows.Forms.Button();
            this.button_cFile = new System.Windows.Forms.Button();
            this.richTextBox_cText = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_pText = new System.Windows.Forms.RichTextBox();
            this.radioButton_CTR = new System.Windows.Forms.RadioButton();
            this.radioButton_CFB = new System.Windows.Forms.RadioButton();
            this.radioButton_OFB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_CBC = new System.Windows.Forms.RadioButton();
            this.radioButton_ECB = new System.Windows.Forms.RadioButton();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_ivFile = new System.Windows.Forms.Button();
            this.button_kFile = new System.Windows.Forms.Button();
            this.textBox_kFile = new System.Windows.Forms.TextBox();
            this.textBox_ivFile = new System.Windows.Forms.TextBox();
            this.radioButton_Base64 = new System.Windows.Forms.RadioButton();
            this.radioButton_Binary = new System.Windows.Forms.RadioButton();
            this.radioButton_Hex = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_cBase64);
            this.groupBox2.Controls.Add(this.radioButton_cHex);
            this.groupBox2.Location = new System.Drawing.Point(179, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 41);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // radioButton_cBase64
            // 
            this.radioButton_cBase64.AutoSize = true;
            this.radioButton_cBase64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_cBase64.Location = new System.Drawing.Point(157, 8);
            this.radioButton_cBase64.Name = "radioButton_cBase64";
            this.radioButton_cBase64.Size = new System.Drawing.Size(87, 24);
            this.radioButton_cBase64.TabIndex = 34;
            this.radioButton_cBase64.TabStop = true;
            this.radioButton_cBase64.Text = "Base64";
            this.radioButton_cBase64.UseVisualStyleBackColor = true;
            // 
            // radioButton_cHex
            // 
            this.radioButton_cHex.AutoSize = true;
            this.radioButton_cHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_cHex.Location = new System.Drawing.Point(69, 8);
            this.radioButton_cHex.Name = "radioButton_cHex";
            this.radioButton_cHex.Size = new System.Drawing.Size(60, 24);
            this.radioButton_cHex.TabIndex = 33;
            this.radioButton_cHex.TabStop = true;
            this.radioButton_cHex.Text = "Hex";
            this.radioButton_cHex.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(25, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 66;
            this.label7.Text = "Cipher text format:";
            // 
            // button_pFile
            // 
            this.button_pFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_pFile.Location = new System.Drawing.Point(497, 239);
            this.button_pFile.Name = "button_pFile";
            this.button_pFile.Size = new System.Drawing.Size(84, 39);
            this.button_pFile.TabIndex = 65;
            this.button_pFile.Text = "Browse";
            this.button_pFile.UseVisualStyleBackColor = true;
            this.button_pFile.Click += new System.EventHandler(this.button_pFile_Click);
            // 
            // button_cFile
            // 
            this.button_cFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_cFile.Location = new System.Drawing.Point(501, 377);
            this.button_cFile.Name = "button_cFile";
            this.button_cFile.Size = new System.Drawing.Size(84, 60);
            this.button_cFile.TabIndex = 64;
            this.button_cFile.Text = "Save to file";
            this.button_cFile.UseVisualStyleBackColor = true;
            this.button_cFile.Click += new System.EventHandler(this.button_cFile_Click);
            // 
            // richTextBox_cText
            // 
            this.richTextBox_cText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richTextBox_cText.Location = new System.Drawing.Point(140, 377);
            this.richTextBox_cText.Name = "richTextBox_cText";
            this.richTextBox_cText.ReadOnly = true;
            this.richTextBox_cText.Size = new System.Drawing.Size(310, 85);
            this.richTextBox_cText.TabIndex = 63;
            this.richTextBox_cText.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(25, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Plain text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(25, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Cipher text:";
            // 
            // richTextBox_pText
            // 
            this.richTextBox_pText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richTextBox_pText.Location = new System.Drawing.Point(140, 239);
            this.richTextBox_pText.Name = "richTextBox_pText";
            this.richTextBox_pText.Size = new System.Drawing.Size(310, 85);
            this.richTextBox_pText.TabIndex = 60;
            this.richTextBox_pText.Text = "";
            // 
            // radioButton_CTR
            // 
            this.radioButton_CTR.AutoSize = true;
            this.radioButton_CTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_CTR.Location = new System.Drawing.Point(357, 18);
            this.radioButton_CTR.Name = "radioButton_CTR";
            this.radioButton_CTR.Size = new System.Drawing.Size(64, 24);
            this.radioButton_CTR.TabIndex = 14;
            this.radioButton_CTR.TabStop = true;
            this.radioButton_CTR.Text = "CTR";
            this.radioButton_CTR.UseVisualStyleBackColor = true;
            // 
            // radioButton_CFB
            // 
            this.radioButton_CFB.AutoSize = true;
            this.radioButton_CFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_CFB.Location = new System.Drawing.Point(276, 18);
            this.radioButton_CFB.Name = "radioButton_CFB";
            this.radioButton_CFB.Size = new System.Drawing.Size(64, 24);
            this.radioButton_CFB.TabIndex = 13;
            this.radioButton_CFB.TabStop = true;
            this.radioButton_CFB.Text = "CFB";
            this.radioButton_CFB.UseVisualStyleBackColor = true;
            // 
            // radioButton_OFB
            // 
            this.radioButton_OFB.AutoSize = true;
            this.radioButton_OFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_OFB.Location = new System.Drawing.Point(196, 18);
            this.radioButton_OFB.Name = "radioButton_OFB";
            this.radioButton_OFB.Size = new System.Drawing.Size(65, 24);
            this.radioButton_OFB.TabIndex = 12;
            this.radioButton_OFB.TabStop = true;
            this.radioButton_OFB.Text = "OFB";
            this.radioButton_OFB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(26, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Key file:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(26, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Key format:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mode:";
            // 
            // radioButton_CBC
            // 
            this.radioButton_CBC.AutoSize = true;
            this.radioButton_CBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_CBC.Location = new System.Drawing.Point(108, 18);
            this.radioButton_CBC.Name = "radioButton_CBC";
            this.radioButton_CBC.Size = new System.Drawing.Size(66, 24);
            this.radioButton_CBC.TabIndex = 11;
            this.radioButton_CBC.TabStop = true;
            this.radioButton_CBC.Text = "CBC";
            this.radioButton_CBC.UseVisualStyleBackColor = true;
            // 
            // radioButton_ECB
            // 
            this.radioButton_ECB.AutoSize = true;
            this.radioButton_ECB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_ECB.Location = new System.Drawing.Point(23, 18);
            this.radioButton_ECB.Name = "radioButton_ECB";
            this.radioButton_ECB.Size = new System.Drawing.Size(65, 24);
            this.radioButton_ECB.TabIndex = 10;
            this.radioButton_ECB.TabStop = true;
            this.radioButton_ECB.Text = "ECB";
            this.radioButton_ECB.UseVisualStyleBackColor = true;
            // 
            // button_encrypt
            // 
            this.button_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_encrypt.Location = new System.Drawing.Point(367, 478);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(214, 39);
            this.button_encrypt.TabIndex = 59;
            this.button_encrypt.Text = "Encrypt";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_ivFile
            // 
            this.button_ivFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_ivFile.Location = new System.Drawing.Point(497, 194);
            this.button_ivFile.Name = "button_ivFile";
            this.button_ivFile.Size = new System.Drawing.Size(84, 39);
            this.button_ivFile.TabIndex = 58;
            this.button_ivFile.Text = "Browse";
            this.button_ivFile.UseVisualStyleBackColor = true;
            this.button_ivFile.Click += new System.EventHandler(this.button_ivFile_Click);
            // 
            // button_kFile
            // 
            this.button_kFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_kFile.Location = new System.Drawing.Point(497, 149);
            this.button_kFile.Name = "button_kFile";
            this.button_kFile.Size = new System.Drawing.Size(84, 39);
            this.button_kFile.TabIndex = 57;
            this.button_kFile.Text = "Browse";
            this.button_kFile.UseVisualStyleBackColor = true;
            this.button_kFile.Click += new System.EventHandler(this.button_kFile_Click);
            // 
            // textBox_kFile
            // 
            this.textBox_kFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_kFile.Location = new System.Drawing.Point(140, 149);
            this.textBox_kFile.Name = "textBox_kFile";
            this.textBox_kFile.Size = new System.Drawing.Size(310, 26);
            this.textBox_kFile.TabIndex = 56;
            // 
            // textBox_ivFile
            // 
            this.textBox_ivFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_ivFile.Location = new System.Drawing.Point(140, 191);
            this.textBox_ivFile.Name = "textBox_ivFile";
            this.textBox_ivFile.Size = new System.Drawing.Size(310, 26);
            this.textBox_ivFile.TabIndex = 55;
            // 
            // radioButton_Base64
            // 
            this.radioButton_Base64.AutoSize = true;
            this.radioButton_Base64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_Base64.Location = new System.Drawing.Point(336, 105);
            this.radioButton_Base64.Name = "radioButton_Base64";
            this.radioButton_Base64.Size = new System.Drawing.Size(87, 24);
            this.radioButton_Base64.TabIndex = 54;
            this.radioButton_Base64.TabStop = true;
            this.radioButton_Base64.Text = "Base64";
            this.radioButton_Base64.UseVisualStyleBackColor = true;
            // 
            // radioButton_Binary
            // 
            this.radioButton_Binary.AutoSize = true;
            this.radioButton_Binary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_Binary.Location = new System.Drawing.Point(140, 105);
            this.radioButton_Binary.Name = "radioButton_Binary";
            this.radioButton_Binary.Size = new System.Drawing.Size(78, 24);
            this.radioButton_Binary.TabIndex = 53;
            this.radioButton_Binary.TabStop = true;
            this.radioButton_Binary.Text = "Binary";
            this.radioButton_Binary.UseVisualStyleBackColor = true;
            // 
            // radioButton_Hex
            // 
            this.radioButton_Hex.AutoSize = true;
            this.radioButton_Hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_Hex.Location = new System.Drawing.Point(248, 105);
            this.radioButton_Hex.Name = "radioButton_Hex";
            this.radioButton_Hex.Size = new System.Drawing.Size(60, 24);
            this.radioButton_Hex.TabIndex = 52;
            this.radioButton_Hex.TabStop = true;
            this.radioButton_Hex.Text = "Hex";
            this.radioButton_Hex.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_CTR);
            this.groupBox1.Controls.Add(this.radioButton_CFB);
            this.groupBox1.Controls.Add(this.radioButton_OFB);
            this.groupBox1.Controls.Add(this.radioButton_CBC);
            this.groupBox1.Controls.Add(this.radioButton_ECB);
            this.groupBox1.Location = new System.Drawing.Point(140, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 56);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(26, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "IV file:";
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 577);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_pFile);
            this.Controls.Add(this.button_cFile);
            this.Controls.Add(this.richTextBox_cText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_pText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.button_ivFile);
            this.Controls.Add(this.button_kFile);
            this.Controls.Add(this.textBox_kFile);
            this.Controls.Add(this.textBox_ivFile);
            this.Controls.Add(this.radioButton_Base64);
            this.Controls.Add(this.radioButton_Binary);
            this.Controls.Add(this.radioButton_Hex);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Name = "Encrypt";
            this.Text = "Encrypt";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_cBase64;
        private System.Windows.Forms.RadioButton radioButton_cHex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_pFile;
        private System.Windows.Forms.Button button_cFile;
        private System.Windows.Forms.RichTextBox richTextBox_cText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_pText;
        private System.Windows.Forms.RadioButton radioButton_CTR;
        private System.Windows.Forms.RadioButton radioButton_CFB;
        private System.Windows.Forms.RadioButton radioButton_OFB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_CBC;
        private System.Windows.Forms.RadioButton radioButton_ECB;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_ivFile;
        private System.Windows.Forms.Button button_kFile;
        private System.Windows.Forms.TextBox textBox_kFile;
        private System.Windows.Forms.TextBox textBox_ivFile;
        private System.Windows.Forms.RadioButton radioButton_Base64;
        private System.Windows.Forms.RadioButton radioButton_Binary;
        private System.Windows.Forms.RadioButton radioButton_Hex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
    }
}