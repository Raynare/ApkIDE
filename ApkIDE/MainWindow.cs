using System;
using System.IO;
using System.Windows.Forms;

namespace ApkIDE
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindFilesInDir(String path)
        {
            int codeFilesCurLen = codeFiles.Length;

            String[] filesInDir = Directory.GetFiles(path);
            Array.Resize<CodeFile>(ref codeFiles, codeFiles.Length + filesInDir.Length);
            for (int i = codeFilesCurLen; i < codeFiles.Length; ++i)
            {
                codeFiles[i] = new CodeFile(filesInDir[i - codeFilesCurLen]);
            }

            String[] dirsInDir = Directory.GetDirectories(path);
            foreach (String dir in dirsInDir)
            {
                FindFilesInDir(dir);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            FindFilesInDir(FOLDER_PATH);
            filteredCodeFiles = codeFiles;

            foreach (CodeFile codeFile in codeFiles)
            {
                sourceLst.Items.Add(codeFile.GetFileName());
            }

            FormBorderStyle = FormBorderStyle.FixedSingle;
            codeTxt.ScrollBars = ScrollBars.Both;
            codeTxt.WordWrap = false;
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
                    Array.Resize<CodeFile>(ref filteredCodeFiles, filteredCodeFiles.Length + 1);
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
            CodeFile currentCodeFile = filteredCodeFiles[sourceLst.SelectedIndex];

            fileNameTxt.Text = currentCodeFile.GetFileName();
            String[] codeLines = currentCodeFile.GetCodeLines();

            codeTxt.Clear();
            foreach (String codeLine in codeLines)
            {
                codeTxt.Text += codeLine + "\r\n";
            }
        }

        /* MUST: Add possibility to open new file */
        private const String FOLDER_PATH = "C:\\Users\\zhur.sergey\\Desktop\\GoogleRestore";
        private CodeFile[] codeFiles = new CodeFile[0];
        private CodeFile[] filteredCodeFiles = new CodeFile[0];
    }
}
