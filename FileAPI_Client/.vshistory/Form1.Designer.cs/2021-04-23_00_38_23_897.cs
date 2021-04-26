
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
            this.listGrid = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listGrid)).BeginInit();
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
            // listGrid
            // 
            this.listGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listGrid.Location = new System.Drawing.Point(12, 136);
            this.listGrid.Name = "listGrid";
            this.listGrid.RowTemplate.Height = 25;
            this.listGrid.Size = new System.Drawing.Size(526, 313);
            this.listGrid.TabIndex = 4;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(214, 468);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(111, 23);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 528);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.listGrid);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.uploadTxt);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.downloadTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox downloadTxt;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox uploadTxt;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.DataGridView listGrid;
        private System.Windows.Forms.Button refreshBtn;
    }
}

