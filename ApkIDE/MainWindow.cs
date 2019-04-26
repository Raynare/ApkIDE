using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ApkIDE
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindFilesInDir(string path)
        {
            int codeFilesCurLen = codeFiles.Length;

            string[] filesInDir = Directory.GetFiles(path);
            Array.Resize(ref codeFiles, codeFiles.Length + filesInDir.Length);
            for (int i = codeFilesCurLen; i < codeFiles.Length; ++i)
            {
                codeFiles[i] = new CodeFile(filesInDir[i - codeFilesCurLen]);
            }

            string[] dirsInDir = Directory.GetDirectories(path);
            foreach (string dir in dirsInDir)
            {
                FindFilesInDir(dir);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            /*FindFilesInDir(FOLDER_PATH);
            filteredCodeFiles = codeFiles;

            foreach (CodeFile codeFile in codeFiles)
            {
                sourceLst.Items.Add(codeFile.GetFileName());
            }

            FormBorderStyle = FormBorderStyle.FixedSingle;
            codeTxt.ScrollBars = ScrollBars.Both;
            codeTxt.WordWrap = false;*/
        }

        private void OpenJavaZip(string path)
        {

        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            sourceLst.Items.Clear();

            if (searchTxt.Text.Equals(""))
            {
                filteredCodeFiles = codeFiles;
            }

            filteredCodeFiles = new CodeFile[0];
            foreach (CodeFile file in codeFiles)
            {
                if (file.GetFileName().Contains(searchTxt.Text))
                {
                    Array.Resize(ref filteredCodeFiles, filteredCodeFiles.Length + 1);
                    filteredCodeFiles[filteredCodeFiles.Length - 1] = file;
                }
            }

            foreach (CodeFile codeFile in filteredCodeFiles)
            {
                sourceLst.Items.Add(codeFile.GetFileName());
            }
        }

        /* Changed to smth like SelectedIndexChanged */
        private void sourceLst_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sourceLst.SelectedIndex >= codeFiles.Length)
            {
                return;
            }

            CodeFile currentCodeFile = filteredCodeFiles[sourceLst.SelectedIndex];

            fileNameTxt.Text = currentCodeFile.GetFileName();
            string[] codeLines = currentCodeFile.GetCodeLines();

            codeTxt.Clear();
            foreach (string codeLine in codeLines)
            {
                codeTxt.Text += codeLine + "\r\n";
            }
        }

        private CodeFile[] codeFiles = new CodeFile[0];
        private CodeFile[] filteredCodeFiles = new CodeFile[0];

        private void dexFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearWidgets();
            DialogResult result = openFileDialog.ShowDialog();

            DexReader dexReader = new DexReader(openFileDialog.FileName);
            codeTxt.Text = Encoding.ASCII.GetString(dexReader.GetStringIds());
        }

        private void javaCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearWidgets();
            DialogResult result = openFileDialog.ShowDialog();
        }

        private void ClearWidgets()
        {
            sourceLst.Items.Clear();
            codeTxt.Clear();
            searchTxt.Clear();
            fileNameTxt.Clear();
        }
    }
}
