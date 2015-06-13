using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocosConsoleFE
{
    public partial class FormMain : Form
    {
        private StringBuilder cocosOutput = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void initProjects()
        {
            //Get projects folder
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (Directory.Exists(folderBrowserDialog.SelectedPath))
                    txtProjectsFolder.Text = folderBrowserDialog.SelectedPath;
            }

            //Put all subfolders inside cmbProjects
            cmbProjects.Items.Add("-- SELECT --");
            cmbProjects.SelectedIndex = 0;

            if (!string.IsNullOrEmpty(txtProjectsFolder.Text))
            {
                foreach (string path in Directory.EnumerateDirectories(txtProjectsFolder.Text))
                {
                    if (Directory.Exists(path))
                    {
                        cmbProjects.Items.Add(path);
                    }
                }
            }
        }

        private void btnSelectProjectsFolder_Click(object sender, EventArgs e)
        {
            initProjects();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            string aboutMsg = "This program is free software (See http://www.gnu.org/licenses/gpl-2.0.html for more information.\n\nCreated by Thiago Neves <thiago.nsantos@gmail.com.\n\nGitHub: https://github.com/thiagonevess/cocoscompilefe";
            MessageBox.Show(aboutMsg, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //Validations
            if (cmbCommand.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(txtProjectName.Text))
                    MessageBox.Show("Project name required", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (string.IsNullOrEmpty(txtPackageName.Text))
                    MessageBox.Show("Package name required", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (string.IsNullOrEmpty(txtProjectsFolder.Text))
                    MessageBox.Show("Project folder required", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (cmbLanguage.SelectedIndex == 0)
                    MessageBox.Show("Select a language required", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (cmbPlatform.SelectedIndex == 0)
            {
                if (cmbCommand.SelectedIndex == 2 || cmbCommand.SelectedIndex == 3)
                    MessageBox.Show("You must specify a platform to compile", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string project = txtProjectName.Text.Trim();
            string package = txtPackageName.Text.Trim();
            string folder = txtProjectsFolder.Text.Trim();
            string projectFolder = cmbProjects.Text;

            string language = string.Empty;
            switch (cmbLanguage.SelectedIndex)
            {
                case 1:
                    language = "cpp";
                    break;

                case 2:
                    language = "js";
                    break;

                case 3:
                    language = "lua";
                    break;
            }

            string mode = string.Empty;
            switch (cmbMode.SelectedIndex)
            {
                case 1:
                    mode = "debug";
                    break;

                case 2:
                    mode = "release";
                    break;
            }

            string platform = string.Empty;
            switch (cmbPlatform.SelectedIndex)
            {
                case 1:
                    platform = "android";
                    break;

                case 2:
                    platform = "win32";
                    break;

                case 3:
                    platform = "wp8_1";
                    break;
            }

            string arguments = string.Empty;
            switch (cmbCommand.SelectedIndex)
            {
                case 1:
                    arguments = string.Format(" new {0} -p {1} -l {2} -d {3}", project, package, language, folder);
                    break;

                case 2:
                    arguments = string.Format(" compile -p {0} -m {1} -s {2}", platform, mode, projectFolder);
                    break;

                case 3:
                    arguments = string.Format(" run -p {0} -m {1}  -s {2}", platform, mode, projectFolder);
                    break;
            }

            try
            {
                string command = "python.exe";
                arguments = string.Format(" {0}\\{1} {2}", Environment.GetEnvironmentVariable("COCOS_CONSOLE_ROOT"), "cocos.py", arguments);
                txtConsoleOutput.AppendText("Command to execute: " + command + arguments + "\r\n");

                ProcessStartInfo startInfo = new ProcessStartInfo(command, arguments);
                startInfo.RedirectStandardOutput = true;
                cocosOutput = new StringBuilder("");
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;

                Process process = new Process();
                process.StartInfo = startInfo;
                process.OutputDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);
                process.Start();

                process.BeginOutputReadLine();

                process.WaitForExit();
                process.Close();

                txtConsoleOutput.AppendText(cocosOutput.ToString());
                txtConsoleOutput.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(e.Data))
                    cocosOutput.Append(e.Data + "\r\n");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCommand.SelectedIndex = 0;
            cmbLanguage.SelectedIndex = 0;
            cmbPlatform.SelectedIndex = 0;
            cmbMode.SelectedIndex = 0;

            if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("COCOS_CONSOLE_ROOT")))
                MessageBox.Show("You must rum setup.py to set environment variables first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCommand.SelectedIndex == 1)
            {
                cmbPlatform.Enabled = false;
                cmbMode.Enabled = false;
            }
            else 
            {
                cmbPlatform.Enabled = true;
                cmbMode.Enabled = true;
            }

            if (cmbCommand.SelectedIndex == 2 || cmbCommand.SelectedIndex == 3) 
            {
                txtPackageName.Enabled = false;
                txtProjectName.Enabled = false;
                cmbLanguage.Enabled = false;
            }
            else
            {
                txtPackageName.Enabled = true;
                txtProjectName.Enabled = true;
                cmbLanguage.Enabled = true;
            }
        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            txtConsoleOutput.Text = string.Empty;
        }
    }
}
