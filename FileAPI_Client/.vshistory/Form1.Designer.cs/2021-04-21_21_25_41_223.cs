
namespace FileAPI_Client
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
            this.downloadTxt = new System.Windows.Forms.TextBox();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadTxt
            // 
            this.downloadTxt.Location = new System.Drawing.Point(53, 34);
            this.downloadTxt.Name = "downloadTxt";
            this.downloadTxt.Size = new System.Drawing.Size(155, 23);
            this.downloadTxt.TabIndex = 0;
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(214, 34);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(167, 23);
            this.downloadBtn.TabIndex = 1;
            this.downloadBtn.Text = "Download File";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 528);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.downloadTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox downloadTxt;
        private System.Windows.Forms.Button downloadBtn;
    }
}

