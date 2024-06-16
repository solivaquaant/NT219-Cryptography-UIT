
namespace RSA_GUI
{
    partial class RSA_GUI
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_keyGen = new System.Windows.Forms.Button();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_keyGen
            // 
            this.button_keyGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_keyGen.Location = new System.Drawing.Point(294, 95);
            this.button_keyGen.Name = "button_keyGen";
            this.button_keyGen.Size = new System.Drawing.Size(220, 66);
            this.button_keyGen.TabIndex = 0;
            this.button_keyGen.Text = "Generate and Save Keys";
            this.button_keyGen.UseVisualStyleBackColor = true;
            this.button_keyGen.Click += new System.EventHandler(this.button_keyGen_Click);
            // 
            // button_encrypt
            // 
            this.button_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_encrypt.Location = new System.Drawing.Point(294, 180);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(220, 66);
            this.button_encrypt.TabIndex = 1;
            this.button_encrypt.Text = "RSA Encrypt";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_decrypt
            // 
            this.button_decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_decrypt.Location = new System.Drawing.Point(294, 270);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(220, 66);
            this.button_decrypt.TabIndex = 2;
            this.button_decrypt.Text = "RSA Decrypt";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // RSA_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 485);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.button_keyGen);
            this.Name = "RSA_GUI";
            this.Text = "Task 3 - RSA ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_keyGen;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_decrypt;
    }
}

