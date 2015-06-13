namespace CocosConsoleFE
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectProjectsFolder = new System.Windows.Forms.Button();
            this.txtProjectsFolder = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPlatform = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCommand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupConsoleOutput = new System.Windows.Forms.GroupBox();
            this.txtConsoleOutput = new System.Windows.Forms.RichTextBox();
            this.btnClearConsole = new System.Windows.Forms.Button();
            this.groupOptions.SuspendLayout();
            this.groupConsoleOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects Folder";
            // 
            // btnSelectProjectsFolder
            // 
            this.btnSelectProjectsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectProjectsFolder.Location = new System.Drawing.Point(694, 10);
            this.btnSelectProjectsFolder.Name = "btnSelectProjectsFolder";
            this.btnSelectProjectsFolder.Size = new System.Drawing.Size(32, 23);
            this.btnSelectProjectsFolder.TabIndex = 1;
            this.btnSelectProjectsFolder.Text = "...";
            this.btnSelectProjectsFolder.UseVisualStyleBackColor = true;
            this.btnSelectProjectsFolder.Click += new System.EventHandler(this.btnSelectProjectsFolder_Click);
            // 
            // txtProjectsFolder
            // 
            this.txtProjectsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectsFolder.Location = new System.Drawing.Point(96, 10);
            this.txtProjectsFolder.Name = "txtProjectsFolder";
            this.txtProjectsFolder.ReadOnly = true;
            this.txtProjectsFolder.Size = new System.Drawing.Size(592, 20);
            this.txtProjectsFolder.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Projects";
            // 
            // cmbProjects
            // 
            this.cmbProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(96, 42);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(630, 21);
            this.cmbProjects.TabIndex = 4;
            // 
            // groupOptions
            // 
            this.groupOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOptions.Controls.Add(this.txtProjectName);
            this.groupOptions.Controls.Add(this.label8);
            this.groupOptions.Controls.Add(this.cmbMode);
            this.groupOptions.Controls.Add(this.label7);
            this.groupOptions.Controls.Add(this.cmbLanguage);
            this.groupOptions.Controls.Add(this.label6);
            this.groupOptions.Controls.Add(this.cmbPlatform);
            this.groupOptions.Controls.Add(this.label5);
            this.groupOptions.Controls.Add(this.txtPackageName);
            this.groupOptions.Controls.Add(this.label4);
            this.groupOptions.Controls.Add(this.cmbCommand);
            this.groupOptions.Controls.Add(this.label3);
            this.groupOptions.Location = new System.Drawing.Point(16, 80);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Size = new System.Drawing.Size(710, 110);
            this.groupOptions.TabIndex = 5;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = " Cocos Compile Options ";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(582, 27);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(122, 20);
            this.txtProjectName.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Project Name";
            // 
            // cmbMode
            // 
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "-- SELECT --",
            "Debug",
            "Release"});
            this.cmbMode.Location = new System.Drawing.Point(582, 64);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(121, 21);
            this.cmbMode.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mode";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "-- SELECT --",
            "C++",
            "JavaScript",
            "Lua"});
            this.cmbLanguage.Location = new System.Drawing.Point(316, 64);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(169, 21);
            this.cmbLanguage.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Langage";
            // 
            // cmbPlatform
            // 
            this.cmbPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlatform.FormattingEnabled = true;
            this.cmbPlatform.Items.AddRange(new object[] {
            "-- SELECT --",
            "Android",
            "Win32",
            "Windows Phone 8"});
            this.cmbPlatform.Location = new System.Drawing.Point(89, 64);
            this.cmbPlatform.Name = "cmbPlatform";
            this.cmbPlatform.Size = new System.Drawing.Size(121, 21);
            this.cmbPlatform.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Platform";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(316, 27);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(169, 20);
            this.txtPackageName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Package Name";
            // 
            // cmbCommand
            // 
            this.cmbCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommand.FormattingEnabled = true;
            this.cmbCommand.Items.AddRange(new object[] {
            "-- SELECT --",
            "New",
            "Compile",
            "Run"});
            this.cmbCommand.Location = new System.Drawing.Point(89, 27);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(121, 21);
            this.cmbCommand.TabIndex = 1;
            this.cmbCommand.SelectedIndexChanged += new System.EventHandler(this.cmbCommand_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Command";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(651, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(570, 402);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRun.Location = new System.Drawing.Point(12, 402);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "&Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // groupConsoleOutput
            // 
            this.groupConsoleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupConsoleOutput.Controls.Add(this.txtConsoleOutput);
            this.groupConsoleOutput.Location = new System.Drawing.Point(16, 196);
            this.groupConsoleOutput.Name = "groupConsoleOutput";
            this.groupConsoleOutput.Size = new System.Drawing.Size(710, 200);
            this.groupConsoleOutput.TabIndex = 9;
            this.groupConsoleOutput.TabStop = false;
            this.groupConsoleOutput.Text = " Console Output ";
            // 
            // txtConsoleOutput
            // 
            this.txtConsoleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsoleOutput.Location = new System.Drawing.Point(6, 19);
            this.txtConsoleOutput.Name = "txtConsoleOutput";
            this.txtConsoleOutput.Size = new System.Drawing.Size(697, 175);
            this.txtConsoleOutput.TabIndex = 0;
            this.txtConsoleOutput.Text = "";
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearConsole.Location = new System.Drawing.Point(93, 402);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Size = new System.Drawing.Size(75, 23);
            this.btnClearConsole.TabIndex = 10;
            this.btnClearConsole.Text = "&Clear Output";
            this.btnClearConsole.UseVisualStyleBackColor = true;
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 437);
            this.Controls.Add(this.btnClearConsole);
            this.Controls.Add(this.groupConsoleOutput);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupOptions);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProjectsFolder);
            this.Controls.Add(this.btnSelectProjectsFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cocos Compile FrontEnd v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();
            this.groupConsoleOutput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectProjectsFolder;
        private System.Windows.Forms.TextBox txtProjectsFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.ComboBox cmbCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cmbPlatform;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupConsoleOutput;
        private System.Windows.Forms.RichTextBox txtConsoleOutput;
        private System.Windows.Forms.Button btnClearConsole;
    }
}

