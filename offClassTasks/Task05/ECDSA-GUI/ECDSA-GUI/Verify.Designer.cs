
namespace ECDSA_GUI
{
    partial class Verify
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
            this.button_verify = new System.Windows.Forms.Button();
            this.button_sign = new System.Windows.Forms.Button();
            this.button_input = new System.Windows.Forms.Button();
            this.button_pubKey = new System.Windows.Forms.Button();
            this.textBox_sign = new System.Windows.Forms.TextBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_pubKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_verify
            // 
            this.button_verify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_verify.Location = new System.Drawing.Point(492, 223);
            this.button_verify.Name = "button_verify";
            this.button_verify.Size = new System.Drawing.Size(101, 39);
            this.button_verify.TabIndex = 19;
            this.button_verify.Text = "Verify";
            this.button_verify.UseVisualStyleBackColor = true;
            this.button_verify.Click += new System.EventHandler(this.button_verify_Click);
            // 
            // button_sign
            // 
            this.button_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_sign.Location = new System.Drawing.Point(492, 150);
            this.button_sign.Name = "button_sign";
            this.button_sign.Size = new System.Drawing.Size(101, 39);
            this.button_sign.TabIndex = 18;
            this.button_sign.Text = "Browse";
            this.button_sign.UseVisualStyleBackColor = true;
            this.button_sign.Click += new System.EventHandler(this.button_sign_Click);
            // 
            // button_input
            // 
            this.button_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_input.Location = new System.Drawing.Point(492, 93);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(101, 39);
            this.button_input.TabIndex = 17;
            this.button_input.Text = "Browse";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // button_pubKey
            // 
            this.button_pubKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_pubKey.Location = new System.Drawing.Point(492, 26);
            this.button_pubKey.Name = "button_pubKey";
            this.button_pubKey.Size = new System.Drawing.Size(101, 39);
            this.button_pubKey.TabIndex = 16;
            this.button_pubKey.Text = "Browse";
            this.button_pubKey.UseVisualStyleBackColor = true;
            this.button_pubKey.Click += new System.EventHandler(this.button_pubKey_Click);
            // 
            // textBox_sign
            // 
            this.textBox_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_sign.Location = new System.Drawing.Point(196, 163);
            this.textBox_sign.Name = "textBox_sign";
            this.textBox_sign.Size = new System.Drawing.Size(262, 26);
            this.textBox_sign.TabIndex = 15;
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_input.Location = new System.Drawing.Point(196, 99);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(262, 26);
            this.textBox_input.TabIndex = 14;
            // 
            // textBox_pubKey
            // 
            this.textBox_pubKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_pubKey.Location = new System.Drawing.Point(196, 39);
            this.textBox_pubKey.Name = "textBox_pubKey";
            this.textBox_pubKey.Size = new System.Drawing.Size(262, 26);
            this.textBox_pubKey.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(40, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sign File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Input File:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Public Key:";
            // 
            // Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 276);
            this.Controls.Add(this.button_verify);
            this.Controls.Add(this.button_sign);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.button_pubKey);
            this.Controls.Add(this.textBox_sign);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.textBox_pubKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Verify";
            this.Text = "Verify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_verify;
        private System.Windows.Forms.Button button_sign;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Button button_pubKey;
        private System.Windows.Forms.TextBox textBox_sign;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_pubKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}