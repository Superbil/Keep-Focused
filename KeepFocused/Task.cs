using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using KeepFocused.Properties;

namespace KeepFocused
{
    public partial class Task : Form
    {
        string taskDataFile;
        public Task()
        {
            InitializeComponent();
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Settings.Default.TaskDataFilePath))
                Directory.CreateDirectory(Settings.Default.TaskDataFilePath);
            File.AppendAllText(Settings.Default.TaskDataFilePath + @"\" + Settings.Default.TaskDataFileName, DateTime.Now.ToString("dd:MMM:yyyy hh:mm") + ":: " + txtTask.Text + "\r\n");
            this.Close();
        }

        private void Task_Load(object sender, EventArgs e)
        {
            if (Settings.Default.TaskDataFilePath == "no")
                Settings.Default.TaskDataFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + Settings.Default.AppName;
            taskDataFile = Settings.Default.TaskDataFilePath + @"\" +Settings.Default.TaskDataFileName;
            txtSessionDataFileName.Text = taskDataFile;
        }

        private void btnViewDataFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(taskDataFile))
                System.Diagnostics.Process.Start(taskDataFile);
            else
            {
                string message = "Log file cannot be read.\r\nThis may be because you are running Keep Focused very first time or you may have deleted the log file.\r\nLogfile will be automatically created when you run the application again.";
                MessageBox.Show(message, "Keep Focused", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChengFilePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            if (path.SelectedPath != "")
            {
                Settings.Default.TaskDataFilePath = path.SelectedPath;
                taskDataFile = Settings.Default.TaskDataFilePath + @"\" + Settings.Default.TaskDataFileName;
                txtSessionDataFileName.Text = taskDataFile;
                Settings.Default.Save();
            }
        }
    }
}
