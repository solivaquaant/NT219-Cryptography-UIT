
namespace AES_GUI
{
    partial class GenKeyIV
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_GCM = new System.Windows.Forms.RadioButton();
            this.radioButton_CCM = new System.Windows.Forms.RadioButton();
            this.radioButton_XTS = new System.Windows.Forms.RadioButton();
            this.radioButton_CTR = new System.Windows.Forms.RadioButton();
            this.radioButton_CFB = new System.Windows.Forms.RadioButton();
            this.radioButton_OFB = new System.Windows.Forms.RadioButton();
            this.radioButton_CBC = new System.Windows.Forms.RadioButton();
            this.radioButton_ECB = new System.Windows.Forms.RadioButton();
            this.radioButton_Hex = new System.Windows.Forms.RadioButton();
            this.radioButton_Binary = new System.Windows.Forms.RadioButton();
            this.radioButton_Base64 = new System.Windows.Forms.RadioButton();
            this.textBox_kSize = new System.Windows.Forms.TextBox();
            this.textBox_ivFile = new System.Windows.Forms.TextBox();
            this.textBox_kFile = new System.Windows.Forms.TextBox();
            this.button_kFile = new System.Windows.Forms.Button();
            this.button_ivFile = new System.Windows.Forms.Button();
            this.button_genKey = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(28, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(28, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Key format:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(28, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Key file:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(28, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "IV file:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_GCM);
            this.groupBox1.Controls.Add(this.radioButton_CCM);
            this.groupBox1.Controls.Add(this.radioButton_XTS);
            this.groupBox1.Controls.Add(this.radioButton_CTR);
            this.groupBox1.Controls.Add(this.radioButton_CFB);
            this.groupBox1.Controls.Add(this.radioButton_OFB);
            this.groupBox1.Controls.Add(this.radioButton_CBC);
            this.groupBox1.Controls.Add(this.radioButton_ECB);
            this.groupBox1.Location = new System.Drawing.Point(142, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 98);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_GCM
            // 
            this.radioButton_GCM.AutoSize = true;
            this.radioButton_GCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_GCM.Location = new System.Drawing.Point(196, 48);
            this.radioButton_GCM.Name = "radioButton_GCM";
            this.radioButton_GCM.Size = new System.Drawing.Size(69, 24);
            this.radioButton_GCM.TabIndex = 17;
            this.radioButton_GCM.TabStop = true;
            this.radioButton_GCM.Text = "GCM";
            this.radioButton_GCM.UseVisualStyleBackColor = true;
            // 
            // radioButton_CCM
            // 
            this.radioButton_CCM.AutoSize = true;
            this.radioButton_CCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_CCM.Location = new System.Drawing.Point(108, 48);
            this.radioButton_CCM.Name = "radioButton_CCM";
            this.radioButton_CCM.Size = new System.Drawing.Size(68, 24);
            this.radioButton_CCM.TabIndex = 16;
            this.radioButton_CCM.TabStop = true;
            this.radioButton_CCM.Text = "CCM";
            this.radioButton_CCM.UseVisualStyleBackColor = true;
            // 
            // radioButton_XTS
            // 
            this.radioButton_XTS.AutoSize = true;
            this.radioButton_XTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_XTS.Location = new System.Drawing.Point(23, 48);
            this.radioButton_XTS.Name = "radioButton_XTS";
            this.radioButton_XTS.Size = new System.Drawing.Size(62, 24);
            this.radioButton_XTS.TabIndex = 15;
            this.radioButton_XTS.TabStop = true;
            this.radioButton_XTS.Text = "XTS";
            this.radioButton_XTS.UseVisualStyleBackColor = true;
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
            // radioButton_Hex
            // 
            this.radioButton_Hex.AutoSize = true;
            this.radioButton_Hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_Hex.Location = new System.Drawing.Point(250, 175);
            this.radioButton_Hex.Name = "radioButton_Hex";
            this.radioButton_Hex.Size = new System.Drawing.Size(60, 24);
            this.radioButton_Hex.TabIndex = 15;
            this.radioButton_Hex.TabStop = true;
            this.radioButton_Hex.Text = "Hex";
            this.radioButton_Hex.UseVisualStyleBackColor = true;
            // 
            // radioButton_Binary
            // 
            this.radioButton_Binary.AutoSize = true;
            this.radioButton_Binary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_Binary.Location = new System.Drawing.Point(142, 175);
            this.radioButton_Binary.Name = "radioButton_Binary";
            this.radioButton_Binary.Size = new System.Drawing.Size(78, 24);
            this.radioButton_Binary.TabIndex = 16;
            this.radioButton_Binary.TabStop = true;
            this.radioButton_Binary.Text = "Binary";
            this.radioButton_Binary.UseVisualStyleBackColor = true;
            // 
            // radioButton_Base64
            // 
            this.radioButton_Base64.AutoSize = true;
            this.radioButton_Base64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_Base64.Location = new System.Drawing.Point(338, 175);
            this.radioButton_Base64.Name = "radioButton_Base64";
            this.radioButton_Base64.Size = new System.Drawing.Size(87, 24);
            this.radioButton_Base64.TabIndex = 17;
            this.radioButton_Base64.TabStop = true;
            this.radioButton_Base64.Text = "Base64";
            this.radioButton_Base64.UseVisualStyleBackColor = true;
            // 
            // textBox_kSize
            // 
            this.textBox_kSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_kSize.Location = new System.Drawing.Point(142, 132);
            this.textBox_kSize.Name = "textBox_kSize";
            this.textBox_kSize.Size = new System.Drawing.Size(104, 26);
            this.textBox_kSize.TabIndex = 18;
            // 
            // textBox_ivFile
            // 
            this.textBox_ivFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_ivFile.Location = new System.Drawing.Point(142, 258);
            this.textBox_ivFile.Name = "textBox_ivFile";
            this.textBox_ivFile.Size = new System.Drawing.Size(310, 26);
            this.textBox_ivFile.TabIndex = 19;
            // 
            // textBox_kFile
            // 
            this.textBox_kFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_kFile.Location = new System.Drawing.Point(142, 216);
            this.textBox_kFile.Name = "textBox_kFile";
            this.textBox_kFile.Size = new System.Drawing.Size(310, 26);
            this.textBox_kFile.TabIndex = 20;
            // 
            // button_kFile
            // 
            this.button_kFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_kFile.Location = new System.Drawing.Point(499, 216);
            this.button_kFile.Name = "button_kFile";
            this.button_kFile.Size = new System.Drawing.Size(84, 39);
            this.button_kFile.TabIndex = 21;
            this.button_kFile.Text = "Browse";
            this.button_kFile.UseVisualStyleBackColor = true;
            this.button_kFile.Click += new System.EventHandler(this.button_kFile_Click);
            // 
            // button_ivFile
            // 
            this.button_ivFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_ivFile.Location = new System.Drawing.Point(499, 261);
            this.button_ivFile.Name = "button_ivFile";
            this.button_ivFile.Size = new System.Drawing.Size(84, 39);
            this.button_ivFile.TabIndex = 22;
            this.button_ivFile.Text = "Browse";
            this.button_ivFile.UseVisualStyleBackColor = true;
            this.button_ivFile.Click += new System.EventHandler(this.button_ivFile_Click);
            // 
            // button_genKey
            // 
            this.button_genKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_genKey.Location = new System.Drawing.Point(369, 321);
            this.button_genKey.Name = "button_genKey";
            this.button_genKey.Size = new System.Drawing.Size(214, 43);
            this.button_genKey.TabIndex = 23;
            this.button_genKey.Text = "Generate Key and IV";
            this.button_genKey.UseVisualStyleBackColor = true;
            this.button_genKey.Click += new System.EventHandler(this.button_genKey_Click);
            // 
            // GenKeyIV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 391);
            this.Controls.Add(this.button_genKey);
            this.Controls.Add(this.button_ivFile);
            this.Controls.Add(this.button_kFile);
            this.Controls.Add(this.textBox_kFile);
            this.Controls.Add(this.textBox_ivFile);
            this.Controls.Add(this.textBox_kSize);
            this.Controls.Add(this.radioButton_Base64);
            this.Controls.Add(this.radioButton_Binary);
            this.Controls.Add(this.radioButton_Hex);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GenKeyIV";
            this.Text = "GenKeyIV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_CTR;
        private System.Windows.Forms.RadioButton radioButton_CFB;
        private System.Windows.Forms.RadioButton radioButton_OFB;
        private System.Windows.Forms.RadioButton radioButton_CBC;
        private System.Windows.Forms.RadioButton radioButton_ECB;
        private System.Windows.Forms.RadioButton radioButton_Hex;
        private System.Windows.Forms.RadioButton radioButton_Binary;
        private System.Windows.Forms.RadioButton radioButton_Base64;
        private System.Windows.Forms.TextBox textBox_kSize;
        private System.Windows.Forms.TextBox textBox_ivFile;
        private System.Windows.Forms.TextBox textBox_kFile;
        private System.Windows.Forms.Button button_kFile;
        private System.Windows.Forms.Button button_ivFile;
        private System.Windows.Forms.Button button_genKey;
        private System.Windows.Forms.RadioButton radioButton_GCM;
        private System.Windows.Forms.RadioButton radioButton_CCM;
        private System.Windows.Forms.RadioButton radioButton_XTS;
    }
}