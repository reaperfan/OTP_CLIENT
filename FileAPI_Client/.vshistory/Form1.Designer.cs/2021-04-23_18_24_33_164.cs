
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
            this.uploadBtn = new System.Windows.Forms.Button();
            this.uploadTxt = new System.Windows.Forms.TextBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.fileLb = new System.Windows.Forms.ListBox();
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
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(214, 78);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(167, 23);
            this.uploadBtn.TabIndex = 3;
            this.uploadBtn.Text = "Upload File";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // uploadTxt
            // 
            this.uploadTxt.Location = new System.Drawing.Point(53, 78);
            this.uploadTxt.Name = "uploadTxt";
            this.uploadTxt.Size = new System.Drawing.Size(155, 23);
            this.uploadTxt.TabIndex = 2;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(214, 468);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(111, 23);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh grid";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // fileLb
            // 
            this.fileLb.FormattingEnabled = true;
            this.fileLb.ItemHeight = 15;
            this.fileLb.Location = new System.Drawing.Point(53, 154);
            this.fileLb.Name = "fileLb";
            this.fileLb.Size = new System.Drawing.Size(433, 289);
            this.fileLb.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 528);
            this.Controls.Add(this.fileLb);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.uploadTxt);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.downloadTxt);
            this.Name = "Form1";
            this.Text = "API Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox downloadTxt;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox uploadTxt;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ListBox fileLb;
    }
}

