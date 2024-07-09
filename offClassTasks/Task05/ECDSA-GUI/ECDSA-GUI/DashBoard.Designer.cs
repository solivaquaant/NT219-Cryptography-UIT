
namespace ECDSA_GUI
{
    partial class DashBoard
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
            this.button_keyGen = new System.Windows.Forms.Button();
            this.button_sign = new System.Windows.Forms.Button();
            this.button_verify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_keyGen
            // 
            this.button_keyGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_keyGen.Location = new System.Drawing.Point(106, 58);
            this.button_keyGen.Name = "button_keyGen";
            this.button_keyGen.Size = new System.Drawing.Size(245, 71);
            this.button_keyGen.TabIndex = 0;
            this.button_keyGen.Text = "Key Generation";
            this.button_keyGen.UseVisualStyleBackColor = true;
            this.button_keyGen.Click += new System.EventHandler(this.button_keyGen_Click);
            // 
            // button_sign
            // 
            this.button_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_sign.Location = new System.Drawing.Point(106, 156);
            this.button_sign.Name = "button_sign";
            this.button_sign.Size = new System.Drawing.Size(245, 71);
            this.button_sign.TabIndex = 1;
            this.button_sign.Text = "Sign";
            this.button_sign.UseVisualStyleBackColor = true;
            this.button_sign.Click += new System.EventHandler(this.button_sign_Click);
            // 
            // button_verify
            // 
            this.button_verify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_verify.Location = new System.Drawing.Point(106, 257);
            this.button_verify.Name = "button_verify";
            this.button_verify.Size = new System.Drawing.Size(245, 71);
            this.button_verify.TabIndex = 2;
            this.button_verify.Text = "Verify";
            this.button_verify.UseVisualStyleBackColor = true;
            this.button_verify.Click += new System.EventHandler(this.button_verify_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 416);
            this.Controls.Add(this.button_verify);
            this.Controls.Add(this.button_sign);
            this.Controls.Add(this.button_keyGen);
            this.Name = "DashBoard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_keyGen;
        private System.Windows.Forms.Button button_sign;
        private System.Windows.Forms.Button button_verify;
    }
}

