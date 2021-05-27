
namespace FileHashChecker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFileToCheck = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpectedHash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileHash = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cboHashType = new System.Windows.Forms.ComboBox();
            this.btnHashIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFileToCheck
            // 
            this.txtFileToCheck.Location = new System.Drawing.Point(100, 19);
            this.txtFileToCheck.Name = "txtFileToCheck";
            this.txtFileToCheck.Size = new System.Drawing.Size(429, 23);
            this.txtFileToCheck.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "D:\\Downloads\\";
            this.openFileDialog1.Title = "Select File to Check Hash Values";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "File To Check: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hash Algorithm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expected Hash Value: ";
            // 
            // txtExpectedHash
            // 
            this.txtExpectedHash.Location = new System.Drawing.Point(149, 87);
            this.txtExpectedHash.Name = "txtExpectedHash";
            this.txtExpectedHash.Size = new System.Drawing.Size(713, 23);
            this.txtExpectedHash.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "File Hash Value:";
            // 
            // txtFileHash
            // 
            this.txtFileHash.Location = new System.Drawing.Point(149, 116);
            this.txtFileHash.Name = "txtFileHash";
            this.txtFileHash.Size = new System.Drawing.Size(713, 23);
            this.txtFileHash.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(535, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cboHashType
            // 
            this.cboHashType.FormattingEnabled = true;
            this.cboHashType.Location = new System.Drawing.Point(109, 56);
            this.cboHashType.Name = "cboHashType";
            this.cboHashType.Size = new System.Drawing.Size(91, 23);
            this.cboHashType.TabIndex = 10;
            // 
            // btnHashIt
            // 
            this.btnHashIt.Location = new System.Drawing.Point(535, 48);
            this.btnHashIt.Name = "btnHashIt";
            this.btnHashIt.Size = new System.Drawing.Size(75, 23);
            this.btnHashIt.TabIndex = 11;
            this.btnHashIt.Text = "Hash It!";
            this.btnHashIt.UseVisualStyleBackColor = true;
            this.btnHashIt.Click += new System.EventHandler(this.btnHashIt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 156);
            this.Controls.Add(this.btnHashIt);
            this.Controls.Add(this.cboHashType);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileHash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExpectedHash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileToCheck);
            this.Name = "Form1";
            this.Text = "File Hash Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileToCheck;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpectedHash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFileHash;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cboHashType;
        private System.Windows.Forms.Button btnHashIt;
    }
}

