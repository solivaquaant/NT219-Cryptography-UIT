
namespace AES_DLL
{
    partial class Task02
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
            this.button_enc = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ekFile = new System.Windows.Forms.TextBox();
            this.textBox_eivFile = new System.Windows.Forms.TextBox();
            this.richTextBox_epText = new System.Windows.Forms.RichTextBox();
            this.button_ekFile = new System.Windows.Forms.Button();
            this.button_eivFile = new System.Windows.Forms.Button();
            this.button_epText = new System.Windows.Forms.Button();
            this.button_ecText = new System.Windows.Forms.Button();
            this.richTextBox_ecText = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_drFile = new System.Windows.Forms.Button();
            this.richTextBox_drText = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_dcFile = new System.Windows.Forms.Button();
            this.button_divFile = new System.Windows.Forms.Button();
            this.button_dkFile = new System.Windows.Forms.Button();
            this.button_dec = new System.Windows.Forms.Button();
            this.richTextBox_dcText = new System.Windows.Forms.RichTextBox();
            this.textBox_divFile = new System.Windows.Forms.TextBox();
            this.textBox_dkFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_enc
            // 
            this.button_enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_enc.Location = new System.Drawing.Point(366, 365);
            this.button_enc.Name = "button_enc";
            this.button_enc.Size = new System.Drawing.Size(139, 50);
            this.button_enc.TabIndex = 0;
            this.button_enc.Text = "Encrypt";
            this.button_enc.UseVisualStyleBackColor = true;
            this.button_enc.Click += new System.EventHandler(this.button_enc_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 460);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_ecText);
            this.tabPage1.Controls.Add(this.richTextBox_ecText);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button_epText);
            this.tabPage1.Controls.Add(this.button_eivFile);
            this.tabPage1.Controls.Add(this.button_ekFile);
            this.tabPage1.Controls.Add(this.button_enc);
            this.tabPage1.Controls.Add(this.richTextBox_epText);
            this.tabPage1.Controls.Add(this.textBox_eivFile);
            this.tabPage1.Controls.Add(this.textBox_ekFile);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_drFile);
            this.tabPage2.Controls.Add(this.richTextBox_drText);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.button_dcFile);
            this.tabPage2.Controls.Add(this.button_divFile);
            this.tabPage2.Controls.Add(this.button_dkFile);
            this.tabPage2.Controls.Add(this.button_dec);
            this.tabPage2.Controls.Add(this.richTextBox_dcText);
            this.tabPage2.Controls.Add(this.textBox_divFile);
            this.tabPage2.Controls.Add(this.textBox_dkFile);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "TASK 02: AES - CBC mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(8, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "22521541 - Thái Ngọc Diễm Trinh\r\nNT219.O22.ANTT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(31, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Key file:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(31, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "IV file:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(31, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Plain text:";
            // 
            // textBox_ekFile
            // 
            this.textBox_ekFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_ekFile.Location = new System.Drawing.Point(153, 31);
            this.textBox_ekFile.Name = "textBox_ekFile";
            this.textBox_ekFile.Size = new System.Drawing.Size(249, 26);
            this.textBox_ekFile.TabIndex = 4;
            // 
            // textBox_eivFile
            // 
            this.textBox_eivFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_eivFile.Location = new System.Drawing.Point(153, 78);
            this.textBox_eivFile.Name = "textBox_eivFile";
            this.textBox_eivFile.Size = new System.Drawing.Size(249, 26);
            this.textBox_eivFile.TabIndex = 7;
            // 
            // richTextBox_epText
            // 
            this.richTextBox_epText.Location = new System.Drawing.Point(153, 137);
            this.richTextBox_epText.Name = "richTextBox_epText";
            this.richTextBox_epText.Size = new System.Drawing.Size(249, 96);
            this.richTextBox_epText.TabIndex = 8;
            this.richTextBox_epText.Text = "";
            // 
            // button_ekFile
            // 
            this.button_ekFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_ekFile.Location = new System.Drawing.Point(430, 23);
            this.button_ekFile.Name = "button_ekFile";
            this.button_ekFile.Size = new System.Drawing.Size(87, 34);
            this.button_ekFile.TabIndex = 4;
            this.button_ekFile.Text = "Browse";
            this.button_ekFile.UseVisualStyleBackColor = true;
            this.button_ekFile.Click += new System.EventHandler(this.button_ekFile_Click);
            // 
            // button_eivFile
            // 
            this.button_eivFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_eivFile.Location = new System.Drawing.Point(430, 70);
            this.button_eivFile.Name = "button_eivFile";
            this.button_eivFile.Size = new System.Drawing.Size(87, 34);
            this.button_eivFile.TabIndex = 9;
            this.button_eivFile.Text = "Browse";
            this.button_eivFile.UseVisualStyleBackColor = true;
            this.button_eivFile.Click += new System.EventHandler(this.button_eivFile_Click);
            // 
            // button_epText
            // 
            this.button_epText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_epText.Location = new System.Drawing.Point(430, 137);
            this.button_epText.Name = "button_epText";
            this.button_epText.Size = new System.Drawing.Size(87, 34);
            this.button_epText.TabIndex = 10;
            this.button_epText.Text = "Browse";
            this.button_epText.UseVisualStyleBackColor = true;
            this.button_epText.Click += new System.EventHandler(this.button_epText_Click);
            // 
            // button_ecText
            // 
            this.button_ecText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_ecText.Location = new System.Drawing.Point(430, 254);
            this.button_ecText.Name = "button_ecText";
            this.button_ecText.Size = new System.Drawing.Size(87, 63);
            this.button_ecText.TabIndex = 13;
            this.button_ecText.Text = "Save to file";
            this.button_ecText.UseVisualStyleBackColor = true;
            this.button_ecText.Click += new System.EventHandler(this.button_ecText_Click);
            // 
            // richTextBox_ecText
            // 
            this.richTextBox_ecText.Location = new System.Drawing.Point(153, 254);
            this.richTextBox_ecText.Name = "richTextBox_ecText";
            this.richTextBox_ecText.Size = new System.Drawing.Size(249, 96);
            this.richTextBox_ecText.TabIndex = 12;
            this.richTextBox_ecText.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(31, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cipher text:";
            // 
            // button_drFile
            // 
            this.button_drFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_drFile.Location = new System.Drawing.Point(436, 250);
            this.button_drFile.Name = "button_drFile";
            this.button_drFile.Size = new System.Drawing.Size(93, 63);
            this.button_drFile.TabIndex = 26;
            this.button_drFile.Text = "Save to file";
            this.button_drFile.UseVisualStyleBackColor = true;
            this.button_drFile.Click += new System.EventHandler(this.button_drFile_Click);
            // 
            // richTextBox_drText
            // 
            this.richTextBox_drText.Location = new System.Drawing.Point(159, 250);
            this.richTextBox_drText.Name = "richTextBox_drText";
            this.richTextBox_drText.Size = new System.Drawing.Size(249, 96);
            this.richTextBox_drText.TabIndex = 25;
            this.richTextBox_drText.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(37, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Cipher text:";
            // 
            // button_dcFile
            // 
            this.button_dcFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_dcFile.Location = new System.Drawing.Point(436, 133);
            this.button_dcFile.Name = "button_dcFile";
            this.button_dcFile.Size = new System.Drawing.Size(93, 34);
            this.button_dcFile.TabIndex = 23;
            this.button_dcFile.Text = "Browse";
            this.button_dcFile.UseVisualStyleBackColor = true;
            this.button_dcFile.Click += new System.EventHandler(this.button_dcFile_Click);
            // 
            // button_divFile
            // 
            this.button_divFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_divFile.Location = new System.Drawing.Point(436, 66);
            this.button_divFile.Name = "button_divFile";
            this.button_divFile.Size = new System.Drawing.Size(93, 34);
            this.button_divFile.TabIndex = 22;
            this.button_divFile.Text = "Browse";
            this.button_divFile.UseVisualStyleBackColor = true;
            this.button_divFile.Click += new System.EventHandler(this.button_divFile_Click);
            // 
            // button_dkFile
            // 
            this.button_dkFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_dkFile.Location = new System.Drawing.Point(436, 19);
            this.button_dkFile.Name = "button_dkFile";
            this.button_dkFile.Size = new System.Drawing.Size(93, 34);
            this.button_dkFile.TabIndex = 15;
            this.button_dkFile.Text = "Browse";
            this.button_dkFile.UseVisualStyleBackColor = true;
            this.button_dkFile.Click += new System.EventHandler(this.button_dkFile_Click);
            // 
            // button_dec
            // 
            this.button_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_dec.Location = new System.Drawing.Point(372, 361);
            this.button_dec.Name = "button_dec";
            this.button_dec.Size = new System.Drawing.Size(139, 50);
            this.button_dec.TabIndex = 14;
            this.button_dec.Text = "Decrypt";
            this.button_dec.UseVisualStyleBackColor = true;
            this.button_dec.Click += new System.EventHandler(this.button_dec_Click);
            // 
            // richTextBox_dcText
            // 
            this.richTextBox_dcText.Location = new System.Drawing.Point(159, 133);
            this.richTextBox_dcText.Name = "richTextBox_dcText";
            this.richTextBox_dcText.Size = new System.Drawing.Size(249, 96);
            this.richTextBox_dcText.TabIndex = 21;
            this.richTextBox_dcText.Text = "";
            // 
            // textBox_divFile
            // 
            this.textBox_divFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_divFile.Location = new System.Drawing.Point(159, 74);
            this.textBox_divFile.Name = "textBox_divFile";
            this.textBox_divFile.Size = new System.Drawing.Size(249, 26);
            this.textBox_divFile.TabIndex = 20;
            // 
            // textBox_dkFile
            // 
            this.textBox_dkFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_dkFile.Location = new System.Drawing.Point(159, 27);
            this.textBox_dkFile.Name = "textBox_dkFile";
            this.textBox_dkFile.Size = new System.Drawing.Size(249, 26);
            this.textBox_dkFile.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(37, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Recover text:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(37, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "IV file:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(37, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Key file:";
            // 
            // Task02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 575);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Task02";
            this.Text = "Task02";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_enc;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_ecText;
        private System.Windows.Forms.RichTextBox richTextBox_ecText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_epText;
        private System.Windows.Forms.Button button_eivFile;
        private System.Windows.Forms.Button button_ekFile;
        private System.Windows.Forms.RichTextBox richTextBox_epText;
        private System.Windows.Forms.TextBox textBox_eivFile;
        private System.Windows.Forms.TextBox textBox_ekFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_drFile;
        private System.Windows.Forms.RichTextBox richTextBox_drText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_dcFile;
        private System.Windows.Forms.Button button_divFile;
        private System.Windows.Forms.Button button_dkFile;
        private System.Windows.Forms.Button button_dec;
        private System.Windows.Forms.RichTextBox richTextBox_dcText;
        private System.Windows.Forms.TextBox textBox_divFile;
        private System.Windows.Forms.TextBox textBox_dkFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

