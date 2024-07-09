
namespace ECDSA_GUI
{
    partial class Sign
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
            this.textBox_priKey = new System.Windows.Forms.TextBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_sign = new System.Windows.Forms.TextBox();
            this.button_priKey = new System.Windows.Forms.Button();
            this.button_input = new System.Windows.Forms.Button();
            this.button_sign = new System.Windows.Forms.Button();
            this.button_doSign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Private Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(25, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sign File:";
            // 
            // textBox_priKey
            // 
            this.textBox_priKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_priKey.Location = new System.Drawing.Point(181, 36);
            this.textBox_priKey.Name = "textBox_priKey";
            this.textBox_priKey.Size = new System.Drawing.Size(262, 26);
            this.textBox_priKey.TabIndex = 3;
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_input.Location = new System.Drawing.Point(181, 96);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(262, 26);
            this.textBox_input.TabIndex = 4;
            // 
            // textBox_sign
            // 
            this.textBox_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_sign.Location = new System.Drawing.Point(181, 160);
            this.textBox_sign.Name = "textBox_sign";
            this.textBox_sign.Size = new System.Drawing.Size(262, 26);
            this.textBox_sign.TabIndex = 5;
            // 
            // button_priKey
            // 
            this.button_priKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_priKey.Location = new System.Drawing.Point(477, 23);
            this.button_priKey.Name = "button_priKey";
            this.button_priKey.Size = new System.Drawing.Size(101, 39);
            this.button_priKey.TabIndex = 6;
            this.button_priKey.Text = "Browse";
            this.button_priKey.UseVisualStyleBackColor = true;
            this.button_priKey.Click += new System.EventHandler(this.button_priKey_Click);
            // 
            // button_input
            // 
            this.button_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_input.Location = new System.Drawing.Point(477, 90);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(101, 39);
            this.button_input.TabIndex = 7;
            this.button_input.Text = "Browse";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // button_sign
            // 
            this.button_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_sign.Location = new System.Drawing.Point(477, 147);
            this.button_sign.Name = "button_sign";
            this.button_sign.Size = new System.Drawing.Size(101, 39);
            this.button_sign.TabIndex = 8;
            this.button_sign.Text = "Browse";
            this.button_sign.UseVisualStyleBackColor = true;
            this.button_sign.Click += new System.EventHandler(this.button_sign_Click);
            // 
            // button_doSign
            // 
            this.button_doSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_doSign.Location = new System.Drawing.Point(477, 220);
            this.button_doSign.Name = "button_doSign";
            this.button_doSign.Size = new System.Drawing.Size(101, 39);
            this.button_doSign.TabIndex = 9;
            this.button_doSign.Text = "Sign";
            this.button_doSign.UseVisualStyleBackColor = true;
            this.button_doSign.Click += new System.EventHandler(this.button_doSign_Click);
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 276);
            this.Controls.Add(this.button_doSign);
            this.Controls.Add(this.button_sign);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.button_priKey);
            this.Controls.Add(this.textBox_sign);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.textBox_priKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sign";
            this.Text = "Sign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_priKey;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_sign;
        private System.Windows.Forms.Button button_priKey;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Button button_sign;
        private System.Windows.Forms.Button button_doSign;
    }
}