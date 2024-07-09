
namespace ECDSA_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_BER = new System.Windows.Forms.RadioButton();
            this.radioButton_PEM = new System.Windows.Forms.RadioButton();
            this.textBox_privateKeyFile = new System.Windows.Forms.TextBox();
            this.textBox_publicKeyFile = new System.Windows.Forms.TextBox();
            this.button_browsePrivate = new System.Windows.Forms.Button();
            this.button_browsePublic = new System.Windows.Forms.Button();
            this.button_keygen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key format:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Private Key File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(20, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Public Key File:";
            // 
            // radioButton_BER
            // 
            this.radioButton_BER.AutoSize = true;
            this.radioButton_BER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_BER.Location = new System.Drawing.Point(190, 35);
            this.radioButton_BER.Name = "radioButton_BER";
            this.radioButton_BER.Size = new System.Drawing.Size(65, 24);
            this.radioButton_BER.TabIndex = 3;
            this.radioButton_BER.TabStop = true;
            this.radioButton_BER.Text = "BER";
            this.radioButton_BER.UseVisualStyleBackColor = true;
            // 
            // radioButton_PEM
            // 
            this.radioButton_PEM.AutoSize = true;
            this.radioButton_PEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_PEM.Location = new System.Drawing.Point(326, 35);
            this.radioButton_PEM.Name = "radioButton_PEM";
            this.radioButton_PEM.Size = new System.Drawing.Size(66, 24);
            this.radioButton_PEM.TabIndex = 4;
            this.radioButton_PEM.TabStop = true;
            this.radioButton_PEM.Text = "PEM";
            this.radioButton_PEM.UseVisualStyleBackColor = true;
            // 
            // textBox_privateKeyFile
            // 
            this.textBox_privateKeyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_privateKeyFile.Location = new System.Drawing.Point(190, 83);
            this.textBox_privateKeyFile.Name = "textBox_privateKeyFile";
            this.textBox_privateKeyFile.Size = new System.Drawing.Size(271, 26);
            this.textBox_privateKeyFile.TabIndex = 5;
            // 
            // textBox_publicKeyFile
            // 
            this.textBox_publicKeyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_publicKeyFile.Location = new System.Drawing.Point(190, 138);
            this.textBox_publicKeyFile.Name = "textBox_publicKeyFile";
            this.textBox_publicKeyFile.Size = new System.Drawing.Size(271, 26);
            this.textBox_publicKeyFile.TabIndex = 6;
            // 
            // button_browsePrivate
            // 
            this.button_browsePrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_browsePrivate.Location = new System.Drawing.Point(499, 73);
            this.button_browsePrivate.Name = "button_browsePrivate";
            this.button_browsePrivate.Size = new System.Drawing.Size(104, 36);
            this.button_browsePrivate.TabIndex = 7;
            this.button_browsePrivate.Text = "Browse";
            this.button_browsePrivate.UseVisualStyleBackColor = true;
            this.button_browsePrivate.Click += new System.EventHandler(this.button_browsePrivate_Click);
            // 
            // button_browsePublic
            // 
            this.button_browsePublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_browsePublic.Location = new System.Drawing.Point(499, 128);
            this.button_browsePublic.Name = "button_browsePublic";
            this.button_browsePublic.Size = new System.Drawing.Size(104, 36);
            this.button_browsePublic.TabIndex = 8;
            this.button_browsePublic.Text = "Browse";
            this.button_browsePublic.UseVisualStyleBackColor = true;
            this.button_browsePublic.Click += new System.EventHandler(this.button_browsePublic_Click);
            // 
            // button_keygen
            // 
            this.button_keygen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_keygen.Location = new System.Drawing.Point(409, 189);
            this.button_keygen.Name = "button_keygen";
            this.button_keygen.Size = new System.Drawing.Size(194, 47);
            this.button_keygen.TabIndex = 9;
            this.button_keygen.Text = "Keys Generate";
            this.button_keygen.UseVisualStyleBackColor = true;
            this.button_keygen.Click += new System.EventHandler(this.button_keygen_Click);
            // 
            // KeyGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 276);
            this.Controls.Add(this.button_keygen);
            this.Controls.Add(this.button_browsePublic);
            this.Controls.Add(this.button_browsePrivate);
            this.Controls.Add(this.textBox_publicKeyFile);
            this.Controls.Add(this.textBox_privateKeyFile);
            this.Controls.Add(this.radioButton_PEM);
            this.Controls.Add(this.radioButton_BER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KeyGen";
            this.Text = "KeyGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_BER;
        private System.Windows.Forms.RadioButton radioButton_PEM;
        private System.Windows.Forms.TextBox textBox_privateKeyFile;
        private System.Windows.Forms.TextBox textBox_publicKeyFile;
        private System.Windows.Forms.Button button_browsePrivate;
        private System.Windows.Forms.Button button_browsePublic;
        private System.Windows.Forms.Button button_keygen;
    }
}