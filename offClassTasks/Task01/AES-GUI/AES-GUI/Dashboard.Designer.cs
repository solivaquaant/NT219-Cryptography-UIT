
namespace AES_GUI
{
    partial class Dashboard
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
            this.button_genkey = new System.Windows.Forms.Button();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_genkey
            // 
            this.button_genkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_genkey.Location = new System.Drawing.Point(76, 96);
            this.button_genkey.Name = "button_genkey";
            this.button_genkey.Size = new System.Drawing.Size(184, 61);
            this.button_genkey.TabIndex = 0;
            this.button_genkey.Text = "Generate Key and IV";
            this.button_genkey.UseVisualStyleBackColor = true;
            this.button_genkey.Click += new System.EventHandler(this.button_genkey_Click);
            // 
            // button_decrypt
            // 
            this.button_decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_decrypt.Location = new System.Drawing.Point(76, 230);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(184, 61);
            this.button_decrypt.TabIndex = 1;
            this.button_decrypt.Text = "Decrypt";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // button_encrypt
            // 
            this.button_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_encrypt.Location = new System.Drawing.Point(76, 163);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(184, 61);
            this.button_encrypt.TabIndex = 2;
            this.button_encrypt.Text = "Encrypt";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(124, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "AES-GUI\r\nTask 01\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "22521541 - Thái Ngọc Diễm Trinh\r\nNT219.O22.ANTT\r\n";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.button_genkey);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_genkey;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

