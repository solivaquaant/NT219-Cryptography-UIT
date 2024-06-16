
namespace RSA_GUI
{
    partial class KeyGen
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
            this.radioBtn_DER = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBtn_Base64 = new System.Windows.Forms.RadioButton();
            this.radioBtn_PEM = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_priKeyFile = new System.Windows.Forms.TextBox();
            this.button_priKey = new System.Windows.Forms.Button();
            this.button_pubKey = new System.Windows.Forms.Button();
            this.textBox_pubKeyFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_keySize = new System.Windows.Forms.TextBox();
            this.button_keyGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioBtn_DER
            // 
            this.radioBtn_DER.AutoSize = true;
            this.radioBtn_DER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtn_DER.Location = new System.Drawing.Point(206, 67);
            this.radioBtn_DER.Name = "radioBtn_DER";
            this.radioBtn_DER.Size = new System.Drawing.Size(66, 24);
            this.radioBtn_DER.TabIndex = 0;
            this.radioBtn_DER.TabStop = true;
            this.radioBtn_DER.Text = "DER";
            this.radioBtn_DER.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Key Format:";
            // 
            // radioBtn_Base64
            // 
            this.radioBtn_Base64.AutoSize = true;
            this.radioBtn_Base64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtn_Base64.Location = new System.Drawing.Point(419, 67);
            this.radioBtn_Base64.Name = "radioBtn_Base64";
            this.radioBtn_Base64.Size = new System.Drawing.Size(87, 24);
            this.radioBtn_Base64.TabIndex = 2;
            this.radioBtn_Base64.TabStop = true;
            this.radioBtn_Base64.Text = "Base64";
            this.radioBtn_Base64.UseVisualStyleBackColor = true;
            // 
            // radioBtn_PEM
            // 
            this.radioBtn_PEM.AutoSize = true;
            this.radioBtn_PEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtn_PEM.Location = new System.Drawing.Point(319, 67);
            this.radioBtn_PEM.Name = "radioBtn_PEM";
            this.radioBtn_PEM.Size = new System.Drawing.Size(66, 24);
            this.radioBtn_PEM.TabIndex = 3;
            this.radioBtn_PEM.TabStop = true;
            this.radioBtn_PEM.Text = "PEM";
            this.radioBtn_PEM.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Private Key File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Public Key File:";
            // 
            // textBox_priKeyFile
            // 
            this.textBox_priKeyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_priKeyFile.Location = new System.Drawing.Point(179, 123);
            this.textBox_priKeyFile.Name = "textBox_priKeyFile";
            this.textBox_priKeyFile.Size = new System.Drawing.Size(311, 26);
            this.textBox_priKeyFile.TabIndex = 6;
            // 
            // button_priKey
            // 
            this.button_priKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_priKey.Location = new System.Drawing.Point(528, 116);
            this.button_priKey.Name = "button_priKey";
            this.button_priKey.Size = new System.Drawing.Size(88, 33);
            this.button_priKey.TabIndex = 7;
            this.button_priKey.Text = "Browse";
            this.button_priKey.UseVisualStyleBackColor = true;
            this.button_priKey.Click += new System.EventHandler(this.button_priKey_Click);
            // 
            // button_pubKey
            // 
            this.button_pubKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_pubKey.Location = new System.Drawing.Point(528, 204);
            this.button_pubKey.Name = "button_pubKey";
            this.button_pubKey.Size = new System.Drawing.Size(88, 33);
            this.button_pubKey.TabIndex = 9;
            this.button_pubKey.Text = "Browse";
            this.button_pubKey.UseVisualStyleBackColor = true;
            this.button_pubKey.Click += new System.EventHandler(this.button_pubKey_Click);
            // 
            // textBox_pubKeyFile
            // 
            this.textBox_pubKeyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_pubKeyFile.Location = new System.Drawing.Point(179, 211);
            this.textBox_pubKeyFile.Name = "textBox_pubKeyFile";
            this.textBox_pubKeyFile.Size = new System.Drawing.Size(311, 26);
            this.textBox_pubKeyFile.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Key Size:";
            // 
            // textBox_keySize
            // 
            this.textBox_keySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_keySize.Location = new System.Drawing.Point(179, 12);
            this.textBox_keySize.Name = "textBox_keySize";
            this.textBox_keySize.Size = new System.Drawing.Size(311, 26);
            this.textBox_keySize.TabIndex = 12;
            // 
            // button_keyGen
            // 
            this.button_keyGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_keyGen.Location = new System.Drawing.Point(367, 286);
            this.button_keyGen.Name = "button_keyGen";
            this.button_keyGen.Size = new System.Drawing.Size(249, 43);
            this.button_keyGen.TabIndex = 14;
            this.button_keyGen.Text = "Generate and Save Keys";
            this.button_keyGen.UseVisualStyleBackColor = true;
            this.button_keyGen.Click += new System.EventHandler(this.button_keyGen_Click);
            // 
            // KeyGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 382);
            this.Controls.Add(this.button_keyGen);
            this.Controls.Add(this.textBox_keySize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_pubKey);
            this.Controls.Add(this.textBox_pubKeyFile);
            this.Controls.Add(this.button_priKey);
            this.Controls.Add(this.textBox_priKeyFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtn_PEM);
            this.Controls.Add(this.radioBtn_Base64);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBtn_DER);
            this.Name = "KeyGen";
            this.Text = "Task 3 - RSA - KeyGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtn_DER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtn_Base64;
        private System.Windows.Forms.RadioButton radioBtn_PEM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_priKeyFile;
        private System.Windows.Forms.Button button_priKey;
        private System.Windows.Forms.Button button_pubKey;
        private System.Windows.Forms.TextBox textBox_pubKeyFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_keySize;
        private System.Windows.Forms.Button button_keyGen;
    }
}