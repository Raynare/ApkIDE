namespace ApkIDE
{
    partial class MainWindow
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
            this.sourceLst = new System.Windows.Forms.ListBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.fileNameTxt = new System.Windows.Forms.TextBox();
            this.codeTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sourceLst
            // 
            this.sourceLst.FormattingEnabled = true;
            this.sourceLst.HorizontalScrollbar = true;
            this.sourceLst.Location = new System.Drawing.Point(12, 12);
            this.sourceLst.Name = "sourceLst";
            this.sourceLst.Size = new System.Drawing.Size(241, 511);
            this.sourceLst.TabIndex = 0;
            this.sourceLst.SelectedValueChanged += new System.EventHandler(this.sourceLst_SelectedValueChanged);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(12, 533);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(241, 20);
            this.searchTxt.TabIndex = 1;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // fileNameTxt
            // 
            this.fileNameTxt.Location = new System.Drawing.Point(274, 12);
            this.fileNameTxt.Name = "fileNameTxt";
            this.fileNameTxt.ReadOnly = true;
            this.fileNameTxt.Size = new System.Drawing.Size(563, 20);
            this.fileNameTxt.TabIndex = 2;
            // 
            // codeTxt
            // 
            this.codeTxt.Location = new System.Drawing.Point(274, 31);
            this.codeTxt.Multiline = true;
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(563, 522);
            this.codeTxt.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 565);
            this.Controls.Add(this.codeTxt);
            this.Controls.Add(this.fileNameTxt);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.sourceLst);
            this.Name = "MainWindow";
            this.Text = "ApkIDE";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox sourceLst;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.TextBox fileNameTxt;
        private System.Windows.Forms.TextBox codeTxt;
    }
}

