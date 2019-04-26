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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javaCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dexFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceLst
            // 
            this.sourceLst.FormattingEnabled = true;
            this.sourceLst.HorizontalScrollbar = true;
            this.sourceLst.Location = new System.Drawing.Point(12, 64);
            this.sourceLst.Name = "sourceLst";
            this.sourceLst.Size = new System.Drawing.Size(241, 459);
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
            this.fileNameTxt.Location = new System.Drawing.Point(274, 38);
            this.fileNameTxt.Name = "fileNameTxt";
            this.fileNameTxt.ReadOnly = true;
            this.fileNameTxt.Size = new System.Drawing.Size(563, 20);
            this.fileNameTxt.TabIndex = 2;
            // 
            // codeTxt
            // 
            this.codeTxt.Location = new System.Drawing.Point(274, 64);
            this.codeTxt.Multiline = true;
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(563, 489);
            this.codeTxt.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.javaCodeToolStripMenuItem,
            this.dexFileToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // javaCodeToolStripMenuItem
            // 
            this.javaCodeToolStripMenuItem.Name = "javaCodeToolStripMenuItem";
            this.javaCodeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.javaCodeToolStripMenuItem.Text = "Java code";
            this.javaCodeToolStripMenuItem.Click += new System.EventHandler(this.javaCodeToolStripMenuItem_Click);
            // 
            // dexFileToolStripMenuItem
            // 
            this.dexFileToolStripMenuItem.Name = "dexFileToolStripMenuItem";
            this.dexFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dexFileToolStripMenuItem.Text = "Dex file";
            this.dexFileToolStripMenuItem.Click += new System.EventHandler(this.dexFileToolStripMenuItem_Click);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "ApkIDE";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox sourceLst;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.TextBox fileNameTxt;
        private System.Windows.Forms.TextBox codeTxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javaCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dexFileToolStripMenuItem;
    }
}

