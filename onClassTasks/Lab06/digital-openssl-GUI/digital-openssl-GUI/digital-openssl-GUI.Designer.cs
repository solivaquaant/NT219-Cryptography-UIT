
namespace digital_openssl_GUI
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSign = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSign_signFile = new System.Windows.Forms.TextBox();
            this.textBoxSign_pdfFile = new System.Windows.Forms.TextBox();
            this.textBoxSign_privateKey = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpen_privateKeyFile = new System.Windows.Forms.Button();
            this.buttonOpen_signFile = new System.Windows.Forms.Button();
            this.buttonOpen_pdfFile = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(216, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN AND VERIFY PDF FILE";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 372);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonOpen_pdfFile);
            this.tabPage1.Controls.Add(this.buttonOpen_signFile);
            this.tabPage1.Controls.Add(this.buttonOpen_privateKeyFile);
            this.tabPage1.Controls.Add(this.buttonSign);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxSign_signFile);
            this.tabPage1.Controls.Add(this.textBoxSign_pdfFile);
            this.tabPage1.Controls.Add(this.textBoxSign_privateKey);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(751, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sign PDF";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSign
            // 
            this.buttonSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonSign.Location = new System.Drawing.Point(397, 267);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(148, 51);
            this.buttonSign.TabIndex = 6;
            this.buttonSign.Text = "SIGN PDF";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(121, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "PDF File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(120, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sign File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(41, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Private Key File:";
            // 
            // textBoxSign_signFile
            // 
            this.textBoxSign_signFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSign_signFile.Location = new System.Drawing.Point(312, 207);
            this.textBoxSign_signFile.Name = "textBoxSign_signFile";
            this.textBoxSign_signFile.Size = new System.Drawing.Size(233, 36);
            this.textBoxSign_signFile.TabIndex = 2;
            // 
            // textBoxSign_pdfFile
            // 
            this.textBoxSign_pdfFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSign_pdfFile.Location = new System.Drawing.Point(312, 112);
            this.textBoxSign_pdfFile.Name = "textBoxSign_pdfFile";
            this.textBoxSign_pdfFile.Size = new System.Drawing.Size(233, 36);
            this.textBoxSign_pdfFile.TabIndex = 1;
            // 
            // textBoxSign_privateKey
            // 
            this.textBoxSign_privateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSign_privateKey.Location = new System.Drawing.Point(312, 26);
            this.textBoxSign_privateKey.Name = "textBoxSign_privateKey";
            this.textBoxSign_privateKey.Size = new System.Drawing.Size(233, 36);
            this.textBoxSign_privateKey.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(751, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Verify PDF";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonOpen_privateKeyFile
            // 
            this.buttonOpen_privateKeyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOpen_privateKeyFile.Location = new System.Drawing.Point(551, 18);
            this.buttonOpen_privateKeyFile.Name = "buttonOpen_privateKeyFile";
            this.buttonOpen_privateKeyFile.Size = new System.Drawing.Size(105, 48);
            this.buttonOpen_privateKeyFile.TabIndex = 7;
            this.buttonOpen_privateKeyFile.Text = "Open";
            this.buttonOpen_privateKeyFile.UseVisualStyleBackColor = true;
            this.buttonOpen_privateKeyFile.Click += new System.EventHandler(this.buttonOpen_privateKeyFile_Click);
            // 
            // buttonOpen_pdfFile
            // 
            this.buttonOpen_pdfFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOpen_pdfFile.Location = new System.Drawing.Point(551, 100);
            this.buttonOpen_pdfFile.Name = "buttonOpen_pdfFile";
            this.buttonOpen_pdfFile.Size = new System.Drawing.Size(105, 48);
            this.buttonOpen_pdfFile.TabIndex = 9;
            this.buttonOpen_pdfFile.Text = "Open";
            this.buttonOpen_pdfFile.UseVisualStyleBackColor = true;
            this.buttonOpen_pdfFile.Click += new System.EventHandler(this.buttonOpen_pdfFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "digital-openssl-GUI";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSign_signFile;
        private System.Windows.Forms.TextBox textBoxSign_pdfFile;
        private System.Windows.Forms.TextBox textBoxSign_privateKey;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonOpen_privateKeyFile;
        private System.Windows.Forms.Button buttonOpen_pdfFile;
        private System.Windows.Forms.Button buttonOpen_signFile;
    }
}

