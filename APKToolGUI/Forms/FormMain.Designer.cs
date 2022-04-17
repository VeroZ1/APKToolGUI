﻿namespace APKToolGUI
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.comApkOpenDir = new System.Windows.Forms.Button();
            this.signApkOpenDirBtn = new System.Windows.Forms.Button();
            this.alignApkOpenDirBtn = new System.Windows.Forms.Button();
            this.decApkOpenDirBtn = new System.Windows.Forms.Button();
            this.selectedApkOpenDirBtn = new System.Windows.Forms.Button();
            this.button_OpenMainActivity = new System.Windows.Forms.Button();
            this.openApktoolYmlBtn = new System.Windows.Forms.Button();
            this.openAndroidMainfestBtn = new System.Windows.Forms.Button();
            this.signPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SIGN_InputFile = new System.Windows.Forms.TextBox();
            this.button_SIGN_BrowseInputFile = new System.Windows.Forms.Button();
            this.button_SIGN_Sign = new System.Windows.Forms.Button();
            this.zipalignPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button_ZIPALIGN_Align = new System.Windows.Forms.Button();
            this.button_ZIPALIGN_BrowseInputFile = new System.Windows.Forms.Button();
            this.textBox_ZIPALIGN_InputFile = new System.Windows.Forms.TextBox();
            this.comPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_BUILD_BrowseInputProjectDir = new System.Windows.Forms.Button();
            this.button_BUILD_Build = new System.Windows.Forms.Button();
            this.textBox_BUILD_InputProjectDir = new System.Windows.Forms.TextBox();
            this.decPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DECODE_InputAppPath = new System.Windows.Forms.TextBox();
            this.button_DECODE_Decode = new System.Windows.Forms.Button();
            this.button_DECODE_BrowseInputAppPath = new System.Windows.Forms.Button();
            this.tabPageApkInfo = new System.Windows.Forms.TabPage();
            this.selApkFileInfoBtn = new System.Windows.Forms.Button();
            this.apkComboLinkBtn = new System.Windows.Forms.Button();
            this.apkAioLinkBtn = new System.Windows.Forms.Button();
            this.apkPureLinkBtn = new System.Windows.Forms.Button();
            this.psLinkBtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.localsTxtBox = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.permTxtBox = new System.Windows.Forms.RichTextBox();
            this.buildTxtBox = new System.Windows.Forms.TextBox();
            this.apkIconPicBox = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.densityTxtBox = new System.Windows.Forms.TextBox();
            this.screenTxtBox = new System.Windows.Forms.TextBox();
            this.targetSdkTxtBox = new System.Windows.Forms.TextBox();
            this.minSdkTxtBox = new System.Windows.Forms.TextBox();
            this.verTxtBox = new System.Windows.Forms.TextBox();
            this.packNameTxtBox = new System.Windows.Forms.TextBox();
            this.fileTxtBox = new System.Windows.Forms.TextBox();
            this.appTxtBox = new System.Windows.Forms.TextBox();
            this.tabPageDecode = new System.Windows.Forms.TabPage();
            this.groupBox_DECODE_Options = new System.Windows.Forms.GroupBox();
            this.decApiLvlUpDown = new System.Windows.Forms.NumericUpDown();
            this.decSetApiLvlChkBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_DECODE_FixError = new System.Windows.Forms.CheckBox();
            this.checkBox_DECODE_OnlyMainClasses = new System.Windows.Forms.CheckBox();
            this.textBox_DECODE_FrameDir = new System.Windows.Forms.TextBox();
            this.button_DECODE_BrowseOutputDirectory = new System.Windows.Forms.Button();
            this.checkBox_DECODE_UseFramework = new System.Windows.Forms.CheckBox();
            this.button_DECODE_BrowseFrameDir = new System.Windows.Forms.Button();
            this.checkBox_DECODE_MatchOriginal = new System.Windows.Forms.CheckBox();
            this.checkBox_DECODE_OutputDirectory = new System.Windows.Forms.CheckBox();
            this.textBox_DECODE_OutputDirectory = new System.Windows.Forms.TextBox();
            this.checkBox_DECODE_KeepBrokenRes = new System.Windows.Forms.CheckBox();
            this.checkBox_DECODE_NoSrc = new System.Windows.Forms.CheckBox();
            this.checkBox_DECODE_Force = new System.Windows.Forms.CheckBox();
            this.checkBox_DECODE_NoRes = new System.Windows.Forms.CheckBox();
            this.checkBox_DECODE_NoDebugInfo = new System.Windows.Forms.CheckBox();
            this.tabPageBuild = new System.Windows.Forms.TabPage();
            this.groupBox_BUILD_Options = new System.Windows.Forms.GroupBox();
            this.buildApiLvlUpDown = new System.Windows.Forms.NumericUpDown();
            this.buildSetApiLvlChkBox = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.signAfterBuildChkBox = new System.Windows.Forms.CheckBox();
            this.zipalignAfterBuildChkBox = new System.Windows.Forms.CheckBox();
            this.checkBox_BUILD_NoCrunch = new System.Windows.Forms.CheckBox();
            this.button_BUILD_BrowseOutputAppPath = new System.Windows.Forms.Button();
            this.checkBox_BUILD_ForceAll = new System.Windows.Forms.CheckBox();
            this.button_BUILD_BrowseFrameDir = new System.Windows.Forms.Button();
            this.button_BUILD_BrowseAaptPath = new System.Windows.Forms.Button();
            this.checkBox_BUILD_OutputAppPath = new System.Windows.Forms.CheckBox();
            this.checkBox_BUILD_CopyOriginal = new System.Windows.Forms.CheckBox();
            this.textBox_BUILD_OutputAppPath = new System.Windows.Forms.TextBox();
            this.checkBox_BUILD_UseAapt = new System.Windows.Forms.CheckBox();
            this.textBox_BUILD_AaptPath = new System.Windows.Forms.TextBox();
            this.textBox_BUILD_FrameDir = new System.Windows.Forms.TextBox();
            this.checkBox_BUILD_UseFramework = new System.Windows.Forms.CheckBox();
            this.tabPageSign = new System.Windows.Forms.TabPage();
            this.groupBox_SIGN_Options = new System.Windows.Forms.GroupBox();
            this.schemev4ComboBox = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.schemev3ComboBox = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.schemev2ComboBox = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.schemev1ComboBox = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.selectKeyStoreFileBtn = new System.Windows.Forms.Button();
            this.aliasTxtBox = new System.Windows.Forms.TextBox();
            this.useAliasChkBox = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.keyStoreFileTxtBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.useKeyStoreChkBox = new System.Windows.Forms.CheckBox();
            this.useSigningOutputDir = new System.Windows.Forms.CheckBox();
            this.label_SIGN_PrivateKey = new System.Windows.Forms.Label();
            this.label_SIGN_PublicKey = new System.Windows.Forms.Label();
            this.button_SIGN_BrowseOutputFile = new System.Windows.Forms.Button();
            this.textBox_SIGN_OutputFile = new System.Windows.Forms.TextBox();
            this.button_SIGN_BrowsePublicKey = new System.Windows.Forms.Button();
            this.button_SIGN_BrowsePrivateKey = new System.Windows.Forms.Button();
            this.textBox_SIGN_PublicKey = new System.Windows.Forms.TextBox();
            this.textBox_SIGN_PrivateKey = new System.Windows.Forms.TextBox();
            this.tabPageZipAlign = new System.Windows.Forms.TabPage();
            this.groupBox_ZIPALIGN_Options = new System.Windows.Forms.GroupBox();
            this.zipalignOutputDirChkBox = new System.Windows.Forms.CheckBox();
            this.signAfterZipalignChkBox = new System.Windows.Forms.CheckBox();
            this.checkBox_ZIPALIGN_Recompress = new System.Windows.Forms.CheckBox();
            this.label_ZIPALIGN_AlignmentBytes = new System.Windows.Forms.Label();
            this.button_ZIPALIGN_BrowseOutputFile = new System.Windows.Forms.Button();
            this.checkBox_ZIPALIGN_CheckAlignment = new System.Windows.Forms.CheckBox();
            this.textBox_ZIPALIGN_OutputFile = new System.Windows.Forms.TextBox();
            this.checkBox_ZIPALIGN_VerboseOutput = new System.Windows.Forms.CheckBox();
            this.numericUpDown_ZIPALIGN_AlignmentBytes = new System.Windows.Forms.NumericUpDown();
            this.checkBox_ZIPALIGN_OverwriteOutputFile = new System.Windows.Forms.CheckBox();
            this.tabPageInstallFramework = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFwFolderBtn = new System.Windows.Forms.Button();
            this.clearFwBtn = new System.Windows.Forms.Button();
            this.clearFwBeforeDecodeChkBox = new System.Windows.Forms.CheckBox();
            this.groupBox_IF_Options = new System.Windows.Forms.GroupBox();
            this.checkBox_IF_Tag = new System.Windows.Forms.CheckBox();
            this.checkBox_IF_FramePath = new System.Windows.Forms.CheckBox();
            this.textBox_IF_Tag = new System.Windows.Forms.TextBox();
            this.button_IF_InstallFramework = new System.Windows.Forms.Button();
            this.button_IF_BrowseFrameDir = new System.Windows.Forms.Button();
            this.button_IF_BrowseInputFramePath = new System.Windows.Forms.Button();
            this.textBox_IF_InputFramePath = new System.Windows.Forms.TextBox();
            this.textBox_IF_FrameDir = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.smaliGroupBox = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.smaliUseOutputChkBox = new System.Windows.Forms.CheckBox();
            this.comSmaliBtn = new System.Windows.Forms.Button();
            this.smaliBrowseOutputBtn = new System.Windows.Forms.Button();
            this.smaliBrowseInputDirTxtBox = new System.Windows.Forms.TextBox();
            this.smaliBrowseOutputTxtBox = new System.Windows.Forms.TextBox();
            this.smaliBrowseInputDirBtn = new System.Windows.Forms.Button();
            this.bakSmaliGroupBox = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.baksmaliUseOutputChkBox = new System.Windows.Forms.CheckBox();
            this.baksmaliBrowseOutputBtn = new System.Windows.Forms.Button();
            this.baksmaliBrowseOutputTxtBox = new System.Windows.Forms.TextBox();
            this.decSmaliBtn = new System.Windows.Forms.Button();
            this.baksmaliBrowseInputDexBtn = new System.Windows.Forms.Button();
            this.baksmaliBrowseInputDexTxtBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStateImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStateText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.logGridView = new System.Windows.Forms.DataGridView();
            this.ColumnImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.saveLogItem = new System.Windows.Forms.MenuItem();
            this.menuItemSettings = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuItemCheckUpdate = new System.Windows.Forms.MenuItem();
            this.apktoolIssueItem = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.signPanel.SuspendLayout();
            this.zipalignPanel.SuspendLayout();
            this.comPanel.SuspendLayout();
            this.decPanel.SuspendLayout();
            this.tabPageApkInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apkIconPicBox)).BeginInit();
            this.tabPageDecode.SuspendLayout();
            this.groupBox_DECODE_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decApiLvlUpDown)).BeginInit();
            this.tabPageBuild.SuspendLayout();
            this.groupBox_BUILD_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildApiLvlUpDown)).BeginInit();
            this.tabPageSign.SuspendLayout();
            this.groupBox_SIGN_Options.SuspendLayout();
            this.tabPageZipAlign.SuspendLayout();
            this.groupBox_ZIPALIGN_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ZIPALIGN_AlignmentBytes)).BeginInit();
            this.tabPageInstallFramework.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_IF_Options.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.smaliGroupBox.SuspendLayout();
            this.bakSmaliGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).BeginInit();
            this.contextMenuStripLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.AllowDrop = true;
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageApkInfo);
            this.tabControlMain.Controls.Add(this.tabPageDecode);
            this.tabControlMain.Controls.Add(this.tabPageBuild);
            this.tabControlMain.Controls.Add(this.tabPageSign);
            this.tabControlMain.Controls.Add(this.tabPageZipAlign);
            this.tabControlMain.Controls.Add(this.tabPageInstallFramework);
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.White;
            this.tabPageMain.Controls.Add(this.comApkOpenDir);
            this.tabPageMain.Controls.Add(this.signApkOpenDirBtn);
            this.tabPageMain.Controls.Add(this.alignApkOpenDirBtn);
            this.tabPageMain.Controls.Add(this.decApkOpenDirBtn);
            this.tabPageMain.Controls.Add(this.selectedApkOpenDirBtn);
            this.tabPageMain.Controls.Add(this.button_OpenMainActivity);
            this.tabPageMain.Controls.Add(this.openApktoolYmlBtn);
            this.tabPageMain.Controls.Add(this.openAndroidMainfestBtn);
            this.tabPageMain.Controls.Add(this.signPanel);
            this.tabPageMain.Controls.Add(this.zipalignPanel);
            this.tabPageMain.Controls.Add(this.comPanel);
            this.tabPageMain.Controls.Add(this.decPanel);
            resources.ApplyResources(this.tabPageMain, "tabPageMain");
            this.tabPageMain.Name = "tabPageMain";
            // 
            // comApkOpenDir
            // 
            resources.ApplyResources(this.comApkOpenDir, "comApkOpenDir");
            this.comApkOpenDir.Name = "comApkOpenDir";
            this.comApkOpenDir.UseVisualStyleBackColor = true;
            // 
            // signApkOpenDirBtn
            // 
            resources.ApplyResources(this.signApkOpenDirBtn, "signApkOpenDirBtn");
            this.signApkOpenDirBtn.Name = "signApkOpenDirBtn";
            this.signApkOpenDirBtn.UseVisualStyleBackColor = true;
            // 
            // alignApkOpenDirBtn
            // 
            resources.ApplyResources(this.alignApkOpenDirBtn, "alignApkOpenDirBtn");
            this.alignApkOpenDirBtn.Name = "alignApkOpenDirBtn";
            this.alignApkOpenDirBtn.UseVisualStyleBackColor = true;
            // 
            // decApkOpenDirBtn
            // 
            resources.ApplyResources(this.decApkOpenDirBtn, "decApkOpenDirBtn");
            this.decApkOpenDirBtn.Name = "decApkOpenDirBtn";
            this.decApkOpenDirBtn.UseVisualStyleBackColor = true;
            // 
            // selectedApkOpenDirBtn
            // 
            resources.ApplyResources(this.selectedApkOpenDirBtn, "selectedApkOpenDirBtn");
            this.selectedApkOpenDirBtn.Name = "selectedApkOpenDirBtn";
            this.selectedApkOpenDirBtn.UseVisualStyleBackColor = true;
            this.selectedApkOpenDirBtn.Click += new System.EventHandler(this.selectedApkOpenDirBtn_Click);
            // 
            // button_OpenMainActivity
            // 
            resources.ApplyResources(this.button_OpenMainActivity, "button_OpenMainActivity");
            this.button_OpenMainActivity.Name = "button_OpenMainActivity";
            this.button_OpenMainActivity.UseVisualStyleBackColor = true;
            this.button_OpenMainActivity.Click += new System.EventHandler(this.button_OpenMainActivity_Click);
            // 
            // openApktoolYmlBtn
            // 
            resources.ApplyResources(this.openApktoolYmlBtn, "openApktoolYmlBtn");
            this.openApktoolYmlBtn.Name = "openApktoolYmlBtn";
            this.openApktoolYmlBtn.UseVisualStyleBackColor = true;
            this.openApktoolYmlBtn.Click += new System.EventHandler(this.openApktoolYmlBtn_Click);
            // 
            // openAndroidMainfestBtn
            // 
            resources.ApplyResources(this.openAndroidMainfestBtn, "openAndroidMainfestBtn");
            this.openAndroidMainfestBtn.Name = "openAndroidMainfestBtn";
            this.openAndroidMainfestBtn.UseVisualStyleBackColor = true;
            this.openAndroidMainfestBtn.Click += new System.EventHandler(this.openAndroidMainfestBtn_Click);
            // 
            // signPanel
            // 
            this.signPanel.AllowDrop = true;
            this.signPanel.Controls.Add(this.label4);
            this.signPanel.Controls.Add(this.textBox_SIGN_InputFile);
            this.signPanel.Controls.Add(this.button_SIGN_BrowseInputFile);
            this.signPanel.Controls.Add(this.button_SIGN_Sign);
            resources.ApplyResources(this.signPanel, "signPanel");
            this.signPanel.Name = "signPanel";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBox_SIGN_InputFile
            // 
            this.textBox_SIGN_InputFile.AllowDrop = true;
            resources.ApplyResources(this.textBox_SIGN_InputFile, "textBox_SIGN_InputFile");
            this.textBox_SIGN_InputFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Sign_InputFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_SIGN_InputFile.Name = "textBox_SIGN_InputFile";
            this.textBox_SIGN_InputFile.Text = global::APKToolGUI.Properties.Settings.Default.Sign_InputFile;
            // 
            // button_SIGN_BrowseInputFile
            // 
            resources.ApplyResources(this.button_SIGN_BrowseInputFile, "button_SIGN_BrowseInputFile");
            this.button_SIGN_BrowseInputFile.Name = "button_SIGN_BrowseInputFile";
            this.button_SIGN_BrowseInputFile.UseVisualStyleBackColor = true;
            // 
            // button_SIGN_Sign
            // 
            this.button_SIGN_Sign.AllowDrop = true;
            resources.ApplyResources(this.button_SIGN_Sign, "button_SIGN_Sign");
            this.button_SIGN_Sign.Name = "button_SIGN_Sign";
            this.button_SIGN_Sign.UseVisualStyleBackColor = true;
            // 
            // zipalignPanel
            // 
            this.zipalignPanel.AllowDrop = true;
            this.zipalignPanel.Controls.Add(this.label3);
            this.zipalignPanel.Controls.Add(this.button_ZIPALIGN_Align);
            this.zipalignPanel.Controls.Add(this.button_ZIPALIGN_BrowseInputFile);
            this.zipalignPanel.Controls.Add(this.textBox_ZIPALIGN_InputFile);
            resources.ApplyResources(this.zipalignPanel, "zipalignPanel");
            this.zipalignPanel.Name = "zipalignPanel";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // button_ZIPALIGN_Align
            // 
            this.button_ZIPALIGN_Align.AllowDrop = true;
            resources.ApplyResources(this.button_ZIPALIGN_Align, "button_ZIPALIGN_Align");
            this.button_ZIPALIGN_Align.Name = "button_ZIPALIGN_Align";
            this.button_ZIPALIGN_Align.UseVisualStyleBackColor = true;
            // 
            // button_ZIPALIGN_BrowseInputFile
            // 
            resources.ApplyResources(this.button_ZIPALIGN_BrowseInputFile, "button_ZIPALIGN_BrowseInputFile");
            this.button_ZIPALIGN_BrowseInputFile.Name = "button_ZIPALIGN_BrowseInputFile";
            this.button_ZIPALIGN_BrowseInputFile.UseVisualStyleBackColor = true;
            // 
            // textBox_ZIPALIGN_InputFile
            // 
            this.textBox_ZIPALIGN_InputFile.AllowDrop = true;
            resources.ApplyResources(this.textBox_ZIPALIGN_InputFile, "textBox_ZIPALIGN_InputFile");
            this.textBox_ZIPALIGN_InputFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Zipalign_InputFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_ZIPALIGN_InputFile.Name = "textBox_ZIPALIGN_InputFile";
            this.textBox_ZIPALIGN_InputFile.Text = global::APKToolGUI.Properties.Settings.Default.Zipalign_InputFile;
            // 
            // comPanel
            // 
            this.comPanel.AllowDrop = true;
            this.comPanel.Controls.Add(this.label2);
            this.comPanel.Controls.Add(this.button_BUILD_BrowseInputProjectDir);
            this.comPanel.Controls.Add(this.button_BUILD_Build);
            this.comPanel.Controls.Add(this.textBox_BUILD_InputProjectDir);
            resources.ApplyResources(this.comPanel, "comPanel");
            this.comPanel.Name = "comPanel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button_BUILD_BrowseInputProjectDir
            // 
            resources.ApplyResources(this.button_BUILD_BrowseInputProjectDir, "button_BUILD_BrowseInputProjectDir");
            this.button_BUILD_BrowseInputProjectDir.Name = "button_BUILD_BrowseInputProjectDir";
            this.button_BUILD_BrowseInputProjectDir.UseVisualStyleBackColor = true;
            // 
            // button_BUILD_Build
            // 
            this.button_BUILD_Build.AllowDrop = true;
            resources.ApplyResources(this.button_BUILD_Build, "button_BUILD_Build");
            this.button_BUILD_Build.Name = "button_BUILD_Build";
            this.button_BUILD_Build.UseVisualStyleBackColor = true;
            // 
            // textBox_BUILD_InputProjectDir
            // 
            this.textBox_BUILD_InputProjectDir.AllowDrop = true;
            resources.ApplyResources(this.textBox_BUILD_InputProjectDir, "textBox_BUILD_InputProjectDir");
            this.textBox_BUILD_InputProjectDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Build_InputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_BUILD_InputProjectDir.Name = "textBox_BUILD_InputProjectDir";
            this.textBox_BUILD_InputProjectDir.Text = global::APKToolGUI.Properties.Settings.Default.Build_InputDir;
            // 
            // decPanel
            // 
            this.decPanel.AllowDrop = true;
            this.decPanel.BackColor = System.Drawing.Color.White;
            this.decPanel.Controls.Add(this.label1);
            this.decPanel.Controls.Add(this.textBox_DECODE_InputAppPath);
            this.decPanel.Controls.Add(this.button_DECODE_Decode);
            this.decPanel.Controls.Add(this.button_DECODE_BrowseInputAppPath);
            resources.ApplyResources(this.decPanel, "decPanel");
            this.decPanel.Name = "decPanel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_DECODE_InputAppPath
            // 
            this.textBox_DECODE_InputAppPath.AllowDrop = true;
            resources.ApplyResources(this.textBox_DECODE_InputAppPath, "textBox_DECODE_InputAppPath");
            this.textBox_DECODE_InputAppPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Decode_InputAppPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_DECODE_InputAppPath.Name = "textBox_DECODE_InputAppPath";
            this.textBox_DECODE_InputAppPath.Text = global::APKToolGUI.Properties.Settings.Default.Decode_InputAppPath;
            // 
            // button_DECODE_Decode
            // 
            this.button_DECODE_Decode.AllowDrop = true;
            resources.ApplyResources(this.button_DECODE_Decode, "button_DECODE_Decode");
            this.button_DECODE_Decode.Name = "button_DECODE_Decode";
            this.button_DECODE_Decode.UseVisualStyleBackColor = true;
            // 
            // button_DECODE_BrowseInputAppPath
            // 
            resources.ApplyResources(this.button_DECODE_BrowseInputAppPath, "button_DECODE_BrowseInputAppPath");
            this.button_DECODE_BrowseInputAppPath.Name = "button_DECODE_BrowseInputAppPath";
            this.button_DECODE_BrowseInputAppPath.UseVisualStyleBackColor = true;
            // 
            // tabPageApkInfo
            // 
            this.tabPageApkInfo.AllowDrop = true;
            resources.ApplyResources(this.tabPageApkInfo, "tabPageApkInfo");
            this.tabPageApkInfo.BackColor = System.Drawing.Color.White;
            this.tabPageApkInfo.Controls.Add(this.selApkFileInfoBtn);
            this.tabPageApkInfo.Controls.Add(this.apkComboLinkBtn);
            this.tabPageApkInfo.Controls.Add(this.apkAioLinkBtn);
            this.tabPageApkInfo.Controls.Add(this.apkPureLinkBtn);
            this.tabPageApkInfo.Controls.Add(this.psLinkBtn);
            this.tabPageApkInfo.Controls.Add(this.label19);
            this.tabPageApkInfo.Controls.Add(this.localsTxtBox);
            this.tabPageApkInfo.Controls.Add(this.label18);
            this.tabPageApkInfo.Controls.Add(this.permTxtBox);
            this.tabPageApkInfo.Controls.Add(this.buildTxtBox);
            this.tabPageApkInfo.Controls.Add(this.apkIconPicBox);
            this.tabPageApkInfo.Controls.Add(this.label10);
            this.tabPageApkInfo.Controls.Add(this.label12);
            this.tabPageApkInfo.Controls.Add(this.label15);
            this.tabPageApkInfo.Controls.Add(this.label14);
            this.tabPageApkInfo.Controls.Add(this.label13);
            this.tabPageApkInfo.Controls.Add(this.label11);
            this.tabPageApkInfo.Controls.Add(this.label8);
            this.tabPageApkInfo.Controls.Add(this.label9);
            this.tabPageApkInfo.Controls.Add(this.label17);
            this.tabPageApkInfo.Controls.Add(this.label7);
            this.tabPageApkInfo.Controls.Add(this.densityTxtBox);
            this.tabPageApkInfo.Controls.Add(this.screenTxtBox);
            this.tabPageApkInfo.Controls.Add(this.targetSdkTxtBox);
            this.tabPageApkInfo.Controls.Add(this.minSdkTxtBox);
            this.tabPageApkInfo.Controls.Add(this.verTxtBox);
            this.tabPageApkInfo.Controls.Add(this.packNameTxtBox);
            this.tabPageApkInfo.Controls.Add(this.fileTxtBox);
            this.tabPageApkInfo.Controls.Add(this.appTxtBox);
            this.tabPageApkInfo.Name = "tabPageApkInfo";
            // 
            // selApkFileInfoBtn
            // 
            resources.ApplyResources(this.selApkFileInfoBtn, "selApkFileInfoBtn");
            this.selApkFileInfoBtn.Name = "selApkFileInfoBtn";
            this.selApkFileInfoBtn.UseVisualStyleBackColor = true;
            this.selApkFileInfoBtn.Click += new System.EventHandler(this.selApkFileInfoBtn_Click);
            // 
            // apkComboLinkBtn
            // 
            resources.ApplyResources(this.apkComboLinkBtn, "apkComboLinkBtn");
            this.apkComboLinkBtn.Name = "apkComboLinkBtn";
            this.apkComboLinkBtn.UseVisualStyleBackColor = true;
            this.apkComboLinkBtn.Click += new System.EventHandler(this.apkComboLinkBtn_Click);
            // 
            // apkAioLinkBtn
            // 
            resources.ApplyResources(this.apkAioLinkBtn, "apkAioLinkBtn");
            this.apkAioLinkBtn.Name = "apkAioLinkBtn";
            this.apkAioLinkBtn.UseVisualStyleBackColor = true;
            this.apkAioLinkBtn.Click += new System.EventHandler(this.apkAioLinkBtn_Click);
            // 
            // apkPureLinkBtn
            // 
            resources.ApplyResources(this.apkPureLinkBtn, "apkPureLinkBtn");
            this.apkPureLinkBtn.Name = "apkPureLinkBtn";
            this.apkPureLinkBtn.UseVisualStyleBackColor = true;
            this.apkPureLinkBtn.Click += new System.EventHandler(this.apkPureLinkBtn_Click);
            // 
            // psLinkBtn
            // 
            resources.ApplyResources(this.psLinkBtn, "psLinkBtn");
            this.psLinkBtn.Name = "psLinkBtn";
            this.psLinkBtn.UseVisualStyleBackColor = true;
            this.psLinkBtn.Click += new System.EventHandler(this.psLinkBtn_Click);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // localsTxtBox
            // 
            resources.ApplyResources(this.localsTxtBox, "localsTxtBox");
            this.localsTxtBox.Name = "localsTxtBox";
            this.localsTxtBox.ReadOnly = true;
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // permTxtBox
            // 
            resources.ApplyResources(this.permTxtBox, "permTxtBox");
            this.permTxtBox.Name = "permTxtBox";
            this.permTxtBox.ReadOnly = true;
            // 
            // buildTxtBox
            // 
            resources.ApplyResources(this.buildTxtBox, "buildTxtBox");
            this.buildTxtBox.Name = "buildTxtBox";
            this.buildTxtBox.ReadOnly = true;
            // 
            // apkIconPicBox
            // 
            this.apkIconPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.apkIconPicBox, "apkIconPicBox");
            this.apkIconPicBox.Name = "apkIconPicBox";
            this.apkIconPicBox.TabStop = false;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // densityTxtBox
            // 
            resources.ApplyResources(this.densityTxtBox, "densityTxtBox");
            this.densityTxtBox.Name = "densityTxtBox";
            this.densityTxtBox.ReadOnly = true;
            // 
            // screenTxtBox
            // 
            resources.ApplyResources(this.screenTxtBox, "screenTxtBox");
            this.screenTxtBox.Name = "screenTxtBox";
            this.screenTxtBox.ReadOnly = true;
            // 
            // targetSdkTxtBox
            // 
            resources.ApplyResources(this.targetSdkTxtBox, "targetSdkTxtBox");
            this.targetSdkTxtBox.Name = "targetSdkTxtBox";
            this.targetSdkTxtBox.ReadOnly = true;
            // 
            // minSdkTxtBox
            // 
            resources.ApplyResources(this.minSdkTxtBox, "minSdkTxtBox");
            this.minSdkTxtBox.Name = "minSdkTxtBox";
            this.minSdkTxtBox.ReadOnly = true;
            // 
            // verTxtBox
            // 
            resources.ApplyResources(this.verTxtBox, "verTxtBox");
            this.verTxtBox.Name = "verTxtBox";
            this.verTxtBox.ReadOnly = true;
            // 
            // packNameTxtBox
            // 
            resources.ApplyResources(this.packNameTxtBox, "packNameTxtBox");
            this.packNameTxtBox.Name = "packNameTxtBox";
            this.packNameTxtBox.ReadOnly = true;
            // 
            // fileTxtBox
            // 
            resources.ApplyResources(this.fileTxtBox, "fileTxtBox");
            this.fileTxtBox.Name = "fileTxtBox";
            this.fileTxtBox.ReadOnly = true;
            // 
            // appTxtBox
            // 
            resources.ApplyResources(this.appTxtBox, "appTxtBox");
            this.appTxtBox.Name = "appTxtBox";
            this.appTxtBox.ReadOnly = true;
            // 
            // tabPageDecode
            // 
            resources.ApplyResources(this.tabPageDecode, "tabPageDecode");
            this.tabPageDecode.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageDecode.Controls.Add(this.groupBox_DECODE_Options);
            this.tabPageDecode.Name = "tabPageDecode";
            // 
            // groupBox_DECODE_Options
            // 
            this.groupBox_DECODE_Options.Controls.Add(this.decApiLvlUpDown);
            this.groupBox_DECODE_Options.Controls.Add(this.decSetApiLvlChkBox);
            this.groupBox_DECODE_Options.Controls.Add(this.label6);
            this.groupBox_DECODE_Options.Controls.Add(this.label5);
            this.groupBox_DECODE_Options.Controls.Add(this.checkBox_DECODE_FixError);
            this.groupBox_DECODE_Options.Controls.Add(this.checkBox_DECODE_OnlyMainClasses);
            this.groupBox_DECODE_Options.Controls.Add(this.textBox_DECODE_FrameDir);
            this.groupBox_DECODE_Options.Controls.Add(this.button_DECODE_BrowseOutputDirectory);
            this.groupBox_DECODE_Options.Controls.Add(this.checkBox_DECODE_UseFramework);
            this.groupBox_DECODE_Options.Controls.Add(this.button_DECODE_BrowseFrameDir);
            this.groupBox_DECODE_Options.Controls.Add(this.checkBox_DECODE_MatchOriginal);
            this.groupBox_DECODE_Options.Controls.Add(this.checkBox_DECODE_OutputDirectory);
            this.groupBox_DECODE_Options.Controls.Add(this.textBox_DECODE_OutputDirectory);
            this.groupBox_DECODE_Options.Controls.Add(this.checkBox_DECODE_KeepBrokenRes);
            this.groupBox_DECODE_Options.Controls.Add(this.checkBox_DECODE_NoSrc);
            this.groupBox_DECODE_Options.Controls.Add(this.checkBox_DECODE_Force);
            this.groupBox_DECODE_Options.Controls.Add(this.checkBox_DECODE_NoRes);
            this.groupBox_DECODE_Options.Controls.Add(this.checkBox_DECODE_NoDebugInfo);
            resources.ApplyResources(this.groupBox_DECODE_Options, "groupBox_DECODE_Options");
            this.groupBox_DECODE_Options.Name = "groupBox_DECODE_Options";
            this.groupBox_DECODE_Options.TabStop = false;
            // 
            // decApiLvlUpDown
            // 
            this.decApiLvlUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::APKToolGUI.Properties.Settings.Default, "Decode_ApiLevel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.decApiLvlUpDown, "decApiLvlUpDown");
            this.decApiLvlUpDown.Name = "decApiLvlUpDown";
            this.decApiLvlUpDown.Value = global::APKToolGUI.Properties.Settings.Default.Decode_ApiLevel;
            // 
            // decSetApiLvlChkBox
            // 
            resources.ApplyResources(this.decSetApiLvlChkBox, "decSetApiLvlChkBox");
            this.decSetApiLvlChkBox.Checked = global::APKToolGUI.Properties.Settings.Default.Decode_SetApiLevel;
            this.decSetApiLvlChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Decode_SetApiLevel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.decSetApiLvlChkBox.Name = "decSetApiLvlChkBox";
            this.decSetApiLvlChkBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Name = "label5";
            // 
            // checkBox_DECODE_FixError
            // 
            resources.ApplyResources(this.checkBox_DECODE_FixError, "checkBox_DECODE_FixError");
            this.checkBox_DECODE_FixError.Checked = global::APKToolGUI.Properties.Settings.Default.Decode_FixError;
            this.checkBox_DECODE_FixError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DECODE_FixError.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Decode_FixError", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_DECODE_FixError.Name = "checkBox_DECODE_FixError";
            this.checkBox_DECODE_FixError.UseVisualStyleBackColor = true;
            // 
            // checkBox_DECODE_OnlyMainClasses
            // 
            resources.ApplyResources(this.checkBox_DECODE_OnlyMainClasses, "checkBox_DECODE_OnlyMainClasses");
            this.checkBox_DECODE_OnlyMainClasses.Checked = global::APKToolGUI.Properties.Settings.Default.Decode_OnlyMainClasses;
            this.checkBox_DECODE_OnlyMainClasses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DECODE_OnlyMainClasses.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Decode_OnlyMainClasses", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_DECODE_OnlyMainClasses.Name = "checkBox_DECODE_OnlyMainClasses";
            this.checkBox_DECODE_OnlyMainClasses.UseVisualStyleBackColor = true;
            // 
            // textBox_DECODE_FrameDir
            // 
            this.textBox_DECODE_FrameDir.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::APKToolGUI.Properties.Settings.Default, "Decode_UseFramework", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_DECODE_FrameDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Decode_FrameDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_DECODE_FrameDir.Enabled = global::APKToolGUI.Properties.Settings.Default.Decode_UseFramework;
            resources.ApplyResources(this.textBox_DECODE_FrameDir, "textBox_DECODE_FrameDir");
            this.textBox_DECODE_FrameDir.Name = "textBox_DECODE_FrameDir";
            this.textBox_DECODE_FrameDir.Text = global::APKToolGUI.Properties.Settings.Default.Decode_FrameDir;
            // 
            // button_DECODE_BrowseOutputDirectory
            // 
            this.button_DECODE_BrowseOutputDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::APKToolGUI.Properties.Settings.Default, "Decode_UseOutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_DECODE_BrowseOutputDirectory.Enabled = global::APKToolGUI.Properties.Settings.Default.Decode_UseOutputDir;
            resources.ApplyResources(this.button_DECODE_BrowseOutputDirectory, "button_DECODE_BrowseOutputDirectory");
            this.button_DECODE_BrowseOutputDirectory.Name = "button_DECODE_BrowseOutputDirectory";
            this.button_DECODE_BrowseOutputDirectory.UseVisualStyleBackColor = true;
            // 
            // checkBox_DECODE_UseFramework
            // 
            resources.ApplyResources(this.checkBox_DECODE_UseFramework, "checkBox_DECODE_UseFramework");
            this.checkBox_DECODE_UseFramework.Checked = global::APKToolGUI.Properties.Settings.Default.Decode_UseFramework;
            this.checkBox_DECODE_UseFramework.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Decode_UseFramework", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_DECODE_UseFramework.Name = "checkBox_DECODE_UseFramework";
            this.checkBox_DECODE_UseFramework.UseVisualStyleBackColor = true;
            // 
            // button_DECODE_BrowseFrameDir
            // 
            this.button_DECODE_BrowseFrameDir.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::APKToolGUI.Properties.Settings.Default, "Decode_UseFramework", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_DECODE_BrowseFrameDir.Enabled = global::APKToolGUI.Properties.Settings.Default.Decode_UseFramework;
            resources.ApplyResources(this.button_DECODE_BrowseFrameDir, "button_DECODE_BrowseFrameDir");
            this.button_DECODE_BrowseFrameDir.Name = "button_DECODE_BrowseFrameDir";
            this.button_DECODE_BrowseFrameDir.UseVisualStyleBackColor = true;
            // 
            // checkBox_DECODE_MatchOriginal
            // 
            resources.ApplyResources(this.checkBox_DECODE_MatchOriginal, "checkBox_DECODE_MatchOriginal");
            this.checkBox_DECODE_MatchOriginal.Checked = global::APKToolGUI.Properties.Settings.Default.Decode_MatchOriginal;
            this.checkBox_DECODE_MatchOriginal.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Decode_MatchOriginal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_DECODE_MatchOriginal.Name = "checkBox_DECODE_MatchOriginal";
            this.checkBox_DECODE_MatchOriginal.UseVisualStyleBackColor = true;
            // 
            // checkBox_DECODE_OutputDirectory
            // 
            resources.ApplyResources(this.checkBox_DECODE_OutputDirectory, "checkBox_DECODE_OutputDirectory");
            this.checkBox_DECODE_OutputDirectory.Checked = global::APKToolGUI.Properties.Settings.Default.Decode_UseOutputDir;
            this.checkBox_DECODE_OutputDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Decode_UseOutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_DECODE_OutputDirectory.Name = "checkBox_DECODE_OutputDirectory";
            this.checkBox_DECODE_OutputDirectory.UseVisualStyleBackColor = true;
            // 
            // textBox_DECODE_OutputDirectory
            // 
            this.textBox_DECODE_OutputDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Decode_OutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_DECODE_OutputDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::APKToolGUI.Properties.Settings.Default, "Decode_UseOutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_DECODE_OutputDirectory.Enabled = global::APKToolGUI.Properties.Settings.Default.Decode_UseOutputDir;
            resources.ApplyResources(this.textBox_DECODE_OutputDirectory, "textBox_DECODE_OutputDirectory");
            this.textBox_DECODE_OutputDirectory.Name = "textBox_DECODE_OutputDirectory";
            this.textBox_DECODE_OutputDirectory.Text = global::APKToolGUI.Properties.Settings.Default.Decode_OutputDir;
            // 
            // checkBox_DECODE_KeepBrokenRes
            // 
            resources.ApplyResources(this.checkBox_DECODE_KeepBrokenRes, "checkBox_DECODE_KeepBrokenRes");
            this.checkBox_DECODE_KeepBrokenRes.Checked = global::APKToolGUI.Properties.Settings.Default.Decode_KeepBrokenRes;
            this.checkBox_DECODE_KeepBrokenRes.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Decode_KeepBrokenRes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_DECODE_KeepBrokenRes.Name = "checkBox_DECODE_KeepBrokenRes";
            this.checkBox_DECODE_KeepBrokenRes.UseVisualStyleBackColor = true;
            // 
            // checkBox_DECODE_NoSrc
            // 
            resources.ApplyResources(this.checkBox_DECODE_NoSrc, "checkBox_DECODE_NoSrc");
            this.checkBox_DECODE_NoSrc.Checked = global::APKToolGUI.Properties.Settings.Default.Decode_NoSrc;
            this.checkBox_DECODE_NoSrc.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Decode_NoSrc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_DECODE_NoSrc.Name = "checkBox_DECODE_NoSrc";
            this.checkBox_DECODE_NoSrc.UseVisualStyleBackColor = true;
            // 
            // checkBox_DECODE_Force
            // 
            resources.ApplyResources(this.checkBox_DECODE_Force, "checkBox_DECODE_Force");
            this.checkBox_DECODE_Force.Checked = global::APKToolGUI.Properties.Settings.Default.Decode_Force;
            this.checkBox_DECODE_Force.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DECODE_Force.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Decode_Force", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_DECODE_Force.Name = "checkBox_DECODE_Force";
            this.checkBox_DECODE_Force.UseVisualStyleBackColor = true;
            // 
            // checkBox_DECODE_NoRes
            // 
            resources.ApplyResources(this.checkBox_DECODE_NoRes, "checkBox_DECODE_NoRes");
            this.checkBox_DECODE_NoRes.Checked = global::APKToolGUI.Properties.Settings.Default.Decode_NoRes;
            this.checkBox_DECODE_NoRes.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Decode_NoRes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_DECODE_NoRes.Name = "checkBox_DECODE_NoRes";
            this.checkBox_DECODE_NoRes.UseVisualStyleBackColor = true;
            // 
            // checkBox_DECODE_NoDebugInfo
            // 
            resources.ApplyResources(this.checkBox_DECODE_NoDebugInfo, "checkBox_DECODE_NoDebugInfo");
            this.checkBox_DECODE_NoDebugInfo.Checked = global::APKToolGUI.Properties.Settings.Default.Decode_NoDebugInfo;
            this.checkBox_DECODE_NoDebugInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Decode_NoDebugInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_DECODE_NoDebugInfo.Name = "checkBox_DECODE_NoDebugInfo";
            this.checkBox_DECODE_NoDebugInfo.UseVisualStyleBackColor = true;
            // 
            // tabPageBuild
            // 
            resources.ApplyResources(this.tabPageBuild, "tabPageBuild");
            this.tabPageBuild.BackColor = System.Drawing.Color.White;
            this.tabPageBuild.Controls.Add(this.groupBox_BUILD_Options);
            this.tabPageBuild.Name = "tabPageBuild";
            // 
            // groupBox_BUILD_Options
            // 
            this.groupBox_BUILD_Options.Controls.Add(this.buildApiLvlUpDown);
            this.groupBox_BUILD_Options.Controls.Add(this.buildSetApiLvlChkBox);
            this.groupBox_BUILD_Options.Controls.Add(this.label23);
            this.groupBox_BUILD_Options.Controls.Add(this.checkBox1);
            this.groupBox_BUILD_Options.Controls.Add(this.label16);
            this.groupBox_BUILD_Options.Controls.Add(this.signAfterBuildChkBox);
            this.groupBox_BUILD_Options.Controls.Add(this.zipalignAfterBuildChkBox);
            this.groupBox_BUILD_Options.Controls.Add(this.checkBox_BUILD_NoCrunch);
            this.groupBox_BUILD_Options.Controls.Add(this.button_BUILD_BrowseOutputAppPath);
            this.groupBox_BUILD_Options.Controls.Add(this.checkBox_BUILD_ForceAll);
            this.groupBox_BUILD_Options.Controls.Add(this.button_BUILD_BrowseFrameDir);
            this.groupBox_BUILD_Options.Controls.Add(this.button_BUILD_BrowseAaptPath);
            this.groupBox_BUILD_Options.Controls.Add(this.checkBox_BUILD_OutputAppPath);
            this.groupBox_BUILD_Options.Controls.Add(this.checkBox_BUILD_CopyOriginal);
            this.groupBox_BUILD_Options.Controls.Add(this.textBox_BUILD_OutputAppPath);
            this.groupBox_BUILD_Options.Controls.Add(this.checkBox_BUILD_UseAapt);
            this.groupBox_BUILD_Options.Controls.Add(this.textBox_BUILD_AaptPath);
            this.groupBox_BUILD_Options.Controls.Add(this.textBox_BUILD_FrameDir);
            this.groupBox_BUILD_Options.Controls.Add(this.checkBox_BUILD_UseFramework);
            resources.ApplyResources(this.groupBox_BUILD_Options, "groupBox_BUILD_Options");
            this.groupBox_BUILD_Options.Name = "groupBox_BUILD_Options";
            this.groupBox_BUILD_Options.TabStop = false;
            // 
            // buildApiLvlUpDown
            // 
            this.buildApiLvlUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::APKToolGUI.Properties.Settings.Default, "Build_ApiLevel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.buildApiLvlUpDown, "buildApiLvlUpDown");
            this.buildApiLvlUpDown.Name = "buildApiLvlUpDown";
            this.buildApiLvlUpDown.Value = global::APKToolGUI.Properties.Settings.Default.Build_ApiLevel;
            // 
            // buildSetApiLvlChkBox
            // 
            resources.ApplyResources(this.buildSetApiLvlChkBox, "buildSetApiLvlChkBox");
            this.buildSetApiLvlChkBox.Checked = global::APKToolGUI.Properties.Settings.Default.Build_SetApiLevel;
            this.buildSetApiLvlChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Build_SetApiLevel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buildSetApiLvlChkBox.Name = "buildSetApiLvlChkBox";
            this.buildSetApiLvlChkBox.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.ForeColor = System.Drawing.Color.DimGray;
            this.label23.Name = "label23";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Checked = global::APKToolGUI.Properties.Settings.Default.Build_CreateUnsignedApk;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Build_CreateUnsignedApk", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Name = "label16";
            // 
            // signAfterBuildChkBox
            // 
            resources.ApplyResources(this.signAfterBuildChkBox, "signAfterBuildChkBox");
            this.signAfterBuildChkBox.Checked = global::APKToolGUI.Properties.Settings.Default.Build_SignAfterBuild;
            this.signAfterBuildChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.signAfterBuildChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Build_SignAfterBuild", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.signAfterBuildChkBox.Name = "signAfterBuildChkBox";
            this.signAfterBuildChkBox.UseVisualStyleBackColor = true;
            // 
            // zipalignAfterBuildChkBox
            // 
            resources.ApplyResources(this.zipalignAfterBuildChkBox, "zipalignAfterBuildChkBox");
            this.zipalignAfterBuildChkBox.Checked = global::APKToolGUI.Properties.Settings.Default.Build_ZipalignAfterBuild;
            this.zipalignAfterBuildChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zipalignAfterBuildChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Build_ZipalignAfterBuild", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.zipalignAfterBuildChkBox.Name = "zipalignAfterBuildChkBox";
            this.zipalignAfterBuildChkBox.UseVisualStyleBackColor = true;
            // 
            // checkBox_BUILD_NoCrunch
            // 
            resources.ApplyResources(this.checkBox_BUILD_NoCrunch, "checkBox_BUILD_NoCrunch");
            this.checkBox_BUILD_NoCrunch.Checked = global::APKToolGUI.Properties.Settings.Default.Build_NoCrunch;
            this.checkBox_BUILD_NoCrunch.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Build_NoCrunch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_BUILD_NoCrunch.Name = "checkBox_BUILD_NoCrunch";
            this.checkBox_BUILD_NoCrunch.UseVisualStyleBackColor = true;
            // 
            // button_BUILD_BrowseOutputAppPath
            // 
            this.button_BUILD_BrowseOutputAppPath.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::APKToolGUI.Properties.Settings.Default, "Build_UseOutputAppPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_BUILD_BrowseOutputAppPath.Enabled = global::APKToolGUI.Properties.Settings.Default.Build_UseOutputAppPath;
            resources.ApplyResources(this.button_BUILD_BrowseOutputAppPath, "button_BUILD_BrowseOutputAppPath");
            this.button_BUILD_BrowseOutputAppPath.Name = "button_BUILD_BrowseOutputAppPath";
            this.button_BUILD_BrowseOutputAppPath.UseVisualStyleBackColor = true;
            // 
            // checkBox_BUILD_ForceAll
            // 
            resources.ApplyResources(this.checkBox_BUILD_ForceAll, "checkBox_BUILD_ForceAll");
            this.checkBox_BUILD_ForceAll.Checked = global::APKToolGUI.Properties.Settings.Default.Build_ForceAll;
            this.checkBox_BUILD_ForceAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_BUILD_ForceAll.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Build_ForceAll", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_BUILD_ForceAll.Name = "checkBox_BUILD_ForceAll";
            this.checkBox_BUILD_ForceAll.UseVisualStyleBackColor = true;
            // 
            // button_BUILD_BrowseFrameDir
            // 
            this.button_BUILD_BrowseFrameDir.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::APKToolGUI.Properties.Settings.Default, "Build_UseFramework", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_BUILD_BrowseFrameDir.Enabled = global::APKToolGUI.Properties.Settings.Default.Build_UseFramework;
            resources.ApplyResources(this.button_BUILD_BrowseFrameDir, "button_BUILD_BrowseFrameDir");
            this.button_BUILD_BrowseFrameDir.Name = "button_BUILD_BrowseFrameDir";
            this.button_BUILD_BrowseFrameDir.UseVisualStyleBackColor = true;
            // 
            // button_BUILD_BrowseAaptPath
            // 
            this.button_BUILD_BrowseAaptPath.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::APKToolGUI.Properties.Settings.Default, "Build_UseAapt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_BUILD_BrowseAaptPath.Enabled = global::APKToolGUI.Properties.Settings.Default.Build_UseAapt;
            resources.ApplyResources(this.button_BUILD_BrowseAaptPath, "button_BUILD_BrowseAaptPath");
            this.button_BUILD_BrowseAaptPath.Name = "button_BUILD_BrowseAaptPath";
            this.button_BUILD_BrowseAaptPath.UseVisualStyleBackColor = true;
            // 
            // checkBox_BUILD_OutputAppPath
            // 
            resources.ApplyResources(this.checkBox_BUILD_OutputAppPath, "checkBox_BUILD_OutputAppPath");
            this.checkBox_BUILD_OutputAppPath.Checked = global::APKToolGUI.Properties.Settings.Default.Build_UseOutputAppPath;
            this.checkBox_BUILD_OutputAppPath.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Build_UseOutputAppPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_BUILD_OutputAppPath.Name = "checkBox_BUILD_OutputAppPath";
            this.checkBox_BUILD_OutputAppPath.UseVisualStyleBackColor = true;
            // 
            // checkBox_BUILD_CopyOriginal
            // 
            resources.ApplyResources(this.checkBox_BUILD_CopyOriginal, "checkBox_BUILD_CopyOriginal");
            this.checkBox_BUILD_CopyOriginal.Checked = global::APKToolGUI.Properties.Settings.Default.Build_CopyOriginal;
            this.checkBox_BUILD_CopyOriginal.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Build_CopyOriginal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_BUILD_CopyOriginal.Name = "checkBox_BUILD_CopyOriginal";
            this.checkBox_BUILD_CopyOriginal.UseVisualStyleBackColor = true;
            // 
            // textBox_BUILD_OutputAppPath
            // 
            this.textBox_BUILD_OutputAppPath.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::APKToolGUI.Properties.Settings.Default, "Build_UseOutputAppPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_BUILD_OutputAppPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Build_OutputAppPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_BUILD_OutputAppPath.Enabled = global::APKToolGUI.Properties.Settings.Default.Build_UseOutputAppPath;
            resources.ApplyResources(this.textBox_BUILD_OutputAppPath, "textBox_BUILD_OutputAppPath");
            this.textBox_BUILD_OutputAppPath.Name = "textBox_BUILD_OutputAppPath";
            this.textBox_BUILD_OutputAppPath.Text = global::APKToolGUI.Properties.Settings.Default.Build_OutputAppPath;
            // 
            // checkBox_BUILD_UseAapt
            // 
            resources.ApplyResources(this.checkBox_BUILD_UseAapt, "checkBox_BUILD_UseAapt");
            this.checkBox_BUILD_UseAapt.Checked = global::APKToolGUI.Properties.Settings.Default.Build_UseAapt;
            this.checkBox_BUILD_UseAapt.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Build_UseAapt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_BUILD_UseAapt.Name = "checkBox_BUILD_UseAapt";
            this.checkBox_BUILD_UseAapt.UseVisualStyleBackColor = true;
            // 
            // textBox_BUILD_AaptPath
            // 
            this.textBox_BUILD_AaptPath.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::APKToolGUI.Properties.Settings.Default, "Build_UseAapt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_BUILD_AaptPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Build_AaptPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_BUILD_AaptPath.Enabled = global::APKToolGUI.Properties.Settings.Default.Build_UseAapt;
            resources.ApplyResources(this.textBox_BUILD_AaptPath, "textBox_BUILD_AaptPath");
            this.textBox_BUILD_AaptPath.Name = "textBox_BUILD_AaptPath";
            this.textBox_BUILD_AaptPath.Text = global::APKToolGUI.Properties.Settings.Default.Build_AaptPath;
            // 
            // textBox_BUILD_FrameDir
            // 
            this.textBox_BUILD_FrameDir.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::APKToolGUI.Properties.Settings.Default, "Build_UseFramework", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_BUILD_FrameDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Build_FrameDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_BUILD_FrameDir.Enabled = global::APKToolGUI.Properties.Settings.Default.Build_UseFramework;
            resources.ApplyResources(this.textBox_BUILD_FrameDir, "textBox_BUILD_FrameDir");
            this.textBox_BUILD_FrameDir.Name = "textBox_BUILD_FrameDir";
            this.textBox_BUILD_FrameDir.Text = global::APKToolGUI.Properties.Settings.Default.Build_FrameDir;
            // 
            // checkBox_BUILD_UseFramework
            // 
            resources.ApplyResources(this.checkBox_BUILD_UseFramework, "checkBox_BUILD_UseFramework");
            this.checkBox_BUILD_UseFramework.Checked = global::APKToolGUI.Properties.Settings.Default.Build_UseFramework;
            this.checkBox_BUILD_UseFramework.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Build_UseFramework", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_BUILD_UseFramework.Name = "checkBox_BUILD_UseFramework";
            this.checkBox_BUILD_UseFramework.UseVisualStyleBackColor = true;
            // 
            // tabPageSign
            // 
            resources.ApplyResources(this.tabPageSign, "tabPageSign");
            this.tabPageSign.BackColor = System.Drawing.Color.White;
            this.tabPageSign.Controls.Add(this.groupBox_SIGN_Options);
            this.tabPageSign.Name = "tabPageSign";
            // 
            // groupBox_SIGN_Options
            // 
            this.groupBox_SIGN_Options.Controls.Add(this.schemev4ComboBox);
            this.groupBox_SIGN_Options.Controls.Add(this.label27);
            this.groupBox_SIGN_Options.Controls.Add(this.schemev3ComboBox);
            this.groupBox_SIGN_Options.Controls.Add(this.label26);
            this.groupBox_SIGN_Options.Controls.Add(this.schemev2ComboBox);
            this.groupBox_SIGN_Options.Controls.Add(this.label25);
            this.groupBox_SIGN_Options.Controls.Add(this.schemev1ComboBox);
            this.groupBox_SIGN_Options.Controls.Add(this.label24);
            this.groupBox_SIGN_Options.Controls.Add(this.textBox3);
            this.groupBox_SIGN_Options.Controls.Add(this.selectKeyStoreFileBtn);
            this.groupBox_SIGN_Options.Controls.Add(this.aliasTxtBox);
            this.groupBox_SIGN_Options.Controls.Add(this.useAliasChkBox);
            this.groupBox_SIGN_Options.Controls.Add(this.label22);
            this.groupBox_SIGN_Options.Controls.Add(this.keyStoreFileTxtBox);
            this.groupBox_SIGN_Options.Controls.Add(this.label21);
            this.groupBox_SIGN_Options.Controls.Add(this.label20);
            this.groupBox_SIGN_Options.Controls.Add(this.useKeyStoreChkBox);
            this.groupBox_SIGN_Options.Controls.Add(this.useSigningOutputDir);
            this.groupBox_SIGN_Options.Controls.Add(this.label_SIGN_PrivateKey);
            this.groupBox_SIGN_Options.Controls.Add(this.label_SIGN_PublicKey);
            this.groupBox_SIGN_Options.Controls.Add(this.button_SIGN_BrowseOutputFile);
            this.groupBox_SIGN_Options.Controls.Add(this.textBox_SIGN_OutputFile);
            this.groupBox_SIGN_Options.Controls.Add(this.button_SIGN_BrowsePublicKey);
            this.groupBox_SIGN_Options.Controls.Add(this.button_SIGN_BrowsePrivateKey);
            this.groupBox_SIGN_Options.Controls.Add(this.textBox_SIGN_PublicKey);
            this.groupBox_SIGN_Options.Controls.Add(this.textBox_SIGN_PrivateKey);
            resources.ApplyResources(this.groupBox_SIGN_Options, "groupBox_SIGN_Options");
            this.groupBox_SIGN_Options.Name = "groupBox_SIGN_Options";
            this.groupBox_SIGN_Options.TabStop = false;
            // 
            // schemev4ComboBox
            // 
            this.schemev4ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schemev4ComboBox.FormattingEnabled = true;
            this.schemev4ComboBox.Items.AddRange(new object[] {
            resources.GetString("schemev4ComboBox.Items"),
            resources.GetString("schemev4ComboBox.Items1"),
            resources.GetString("schemev4ComboBox.Items2")});
            resources.ApplyResources(this.schemev4ComboBox, "schemev4ComboBox");
            this.schemev4ComboBox.Name = "schemev4ComboBox";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // schemev3ComboBox
            // 
            this.schemev3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schemev3ComboBox.FormattingEnabled = true;
            this.schemev3ComboBox.Items.AddRange(new object[] {
            resources.GetString("schemev3ComboBox.Items"),
            resources.GetString("schemev3ComboBox.Items1"),
            resources.GetString("schemev3ComboBox.Items2")});
            resources.ApplyResources(this.schemev3ComboBox, "schemev3ComboBox");
            this.schemev3ComboBox.Name = "schemev3ComboBox";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // schemev2ComboBox
            // 
            this.schemev2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schemev2ComboBox.FormattingEnabled = true;
            this.schemev2ComboBox.Items.AddRange(new object[] {
            resources.GetString("schemev2ComboBox.Items"),
            resources.GetString("schemev2ComboBox.Items1"),
            resources.GetString("schemev2ComboBox.Items2")});
            resources.ApplyResources(this.schemev2ComboBox, "schemev2ComboBox");
            this.schemev2ComboBox.Name = "schemev2ComboBox";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // schemev1ComboBox
            // 
            this.schemev1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schemev1ComboBox.FormattingEnabled = true;
            this.schemev1ComboBox.Items.AddRange(new object[] {
            resources.GetString("schemev1ComboBox.Items"),
            resources.GetString("schemev1ComboBox.Items1"),
            resources.GetString("schemev1ComboBox.Items2")});
            resources.ApplyResources(this.schemev1ComboBox, "schemev1ComboBox");
            this.schemev1ComboBox.Name = "schemev1ComboBox";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Sign_KeystorePassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.Text = global::APKToolGUI.Properties.Settings.Default.Sign_KeystorePassword;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // selectKeyStoreFileBtn
            // 
            resources.ApplyResources(this.selectKeyStoreFileBtn, "selectKeyStoreFileBtn");
            this.selectKeyStoreFileBtn.Name = "selectKeyStoreFileBtn";
            this.selectKeyStoreFileBtn.UseVisualStyleBackColor = true;
            // 
            // aliasTxtBox
            // 
            this.aliasTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Sign_Alias", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.aliasTxtBox, "aliasTxtBox");
            this.aliasTxtBox.Name = "aliasTxtBox";
            this.aliasTxtBox.Text = global::APKToolGUI.Properties.Settings.Default.Sign_Alias;
            // 
            // useAliasChkBox
            // 
            resources.ApplyResources(this.useAliasChkBox, "useAliasChkBox");
            this.useAliasChkBox.Checked = global::APKToolGUI.Properties.Settings.Default.Sign_SetAlias;
            this.useAliasChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useAliasChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Sign_SetAlias", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.useAliasChkBox.Name = "useAliasChkBox";
            this.useAliasChkBox.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.ForeColor = System.Drawing.Color.Maroon;
            this.label22.Name = "label22";
            // 
            // keyStoreFileTxtBox
            // 
            this.keyStoreFileTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Sign_KeystoreFilePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.keyStoreFileTxtBox, "keyStoreFileTxtBox");
            this.keyStoreFileTxtBox.Name = "keyStoreFileTxtBox";
            this.keyStoreFileTxtBox.Text = global::APKToolGUI.Properties.Settings.Default.Sign_KeystoreFilePath;
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // useKeyStoreChkBox
            // 
            resources.ApplyResources(this.useKeyStoreChkBox, "useKeyStoreChkBox");
            this.useKeyStoreChkBox.Checked = global::APKToolGUI.Properties.Settings.Default.Sign_UseKeystoreFile;
            this.useKeyStoreChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Sign_UseKeystoreFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.useKeyStoreChkBox.Name = "useKeyStoreChkBox";
            this.useKeyStoreChkBox.UseVisualStyleBackColor = true;
            // 
            // useSigningOutputDir
            // 
            resources.ApplyResources(this.useSigningOutputDir, "useSigningOutputDir");
            this.useSigningOutputDir.Checked = global::APKToolGUI.Properties.Settings.Default.Sign_UseOutputDir;
            this.useSigningOutputDir.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Sign_UseOutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.useSigningOutputDir.Name = "useSigningOutputDir";
            this.useSigningOutputDir.UseVisualStyleBackColor = true;
            // 
            // label_SIGN_PrivateKey
            // 
            resources.ApplyResources(this.label_SIGN_PrivateKey, "label_SIGN_PrivateKey");
            this.label_SIGN_PrivateKey.Name = "label_SIGN_PrivateKey";
            // 
            // label_SIGN_PublicKey
            // 
            resources.ApplyResources(this.label_SIGN_PublicKey, "label_SIGN_PublicKey");
            this.label_SIGN_PublicKey.Name = "label_SIGN_PublicKey";
            // 
            // button_SIGN_BrowseOutputFile
            // 
            resources.ApplyResources(this.button_SIGN_BrowseOutputFile, "button_SIGN_BrowseOutputFile");
            this.button_SIGN_BrowseOutputFile.Name = "button_SIGN_BrowseOutputFile";
            this.button_SIGN_BrowseOutputFile.UseVisualStyleBackColor = true;
            // 
            // textBox_SIGN_OutputFile
            // 
            this.textBox_SIGN_OutputFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Sign_OutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.textBox_SIGN_OutputFile, "textBox_SIGN_OutputFile");
            this.textBox_SIGN_OutputFile.Name = "textBox_SIGN_OutputFile";
            this.textBox_SIGN_OutputFile.Text = global::APKToolGUI.Properties.Settings.Default.Sign_OutputDir;
            // 
            // button_SIGN_BrowsePublicKey
            // 
            resources.ApplyResources(this.button_SIGN_BrowsePublicKey, "button_SIGN_BrowsePublicKey");
            this.button_SIGN_BrowsePublicKey.Name = "button_SIGN_BrowsePublicKey";
            this.button_SIGN_BrowsePublicKey.UseVisualStyleBackColor = true;
            // 
            // button_SIGN_BrowsePrivateKey
            // 
            resources.ApplyResources(this.button_SIGN_BrowsePrivateKey, "button_SIGN_BrowsePrivateKey");
            this.button_SIGN_BrowsePrivateKey.Name = "button_SIGN_BrowsePrivateKey";
            this.button_SIGN_BrowsePrivateKey.UseVisualStyleBackColor = true;
            // 
            // textBox_SIGN_PublicKey
            // 
            this.textBox_SIGN_PublicKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Sign_PublicKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.textBox_SIGN_PublicKey, "textBox_SIGN_PublicKey");
            this.textBox_SIGN_PublicKey.Name = "textBox_SIGN_PublicKey";
            this.textBox_SIGN_PublicKey.Text = global::APKToolGUI.Properties.Settings.Default.Sign_PublicKey;
            // 
            // textBox_SIGN_PrivateKey
            // 
            this.textBox_SIGN_PrivateKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Sign_PrivateKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.textBox_SIGN_PrivateKey, "textBox_SIGN_PrivateKey");
            this.textBox_SIGN_PrivateKey.Name = "textBox_SIGN_PrivateKey";
            this.textBox_SIGN_PrivateKey.Text = global::APKToolGUI.Properties.Settings.Default.Sign_PrivateKey;
            // 
            // tabPageZipAlign
            // 
            resources.ApplyResources(this.tabPageZipAlign, "tabPageZipAlign");
            this.tabPageZipAlign.BackColor = System.Drawing.Color.White;
            this.tabPageZipAlign.Controls.Add(this.groupBox_ZIPALIGN_Options);
            this.tabPageZipAlign.Name = "tabPageZipAlign";
            // 
            // groupBox_ZIPALIGN_Options
            // 
            resources.ApplyResources(this.groupBox_ZIPALIGN_Options, "groupBox_ZIPALIGN_Options");
            this.groupBox_ZIPALIGN_Options.Controls.Add(this.zipalignOutputDirChkBox);
            this.groupBox_ZIPALIGN_Options.Controls.Add(this.signAfterZipalignChkBox);
            this.groupBox_ZIPALIGN_Options.Controls.Add(this.checkBox_ZIPALIGN_Recompress);
            this.groupBox_ZIPALIGN_Options.Controls.Add(this.label_ZIPALIGN_AlignmentBytes);
            this.groupBox_ZIPALIGN_Options.Controls.Add(this.button_ZIPALIGN_BrowseOutputFile);
            this.groupBox_ZIPALIGN_Options.Controls.Add(this.checkBox_ZIPALIGN_CheckAlignment);
            this.groupBox_ZIPALIGN_Options.Controls.Add(this.textBox_ZIPALIGN_OutputFile);
            this.groupBox_ZIPALIGN_Options.Controls.Add(this.checkBox_ZIPALIGN_VerboseOutput);
            this.groupBox_ZIPALIGN_Options.Controls.Add(this.numericUpDown_ZIPALIGN_AlignmentBytes);
            this.groupBox_ZIPALIGN_Options.Controls.Add(this.checkBox_ZIPALIGN_OverwriteOutputFile);
            this.groupBox_ZIPALIGN_Options.Name = "groupBox_ZIPALIGN_Options";
            this.groupBox_ZIPALIGN_Options.TabStop = false;
            // 
            // zipalignOutputDirChkBox
            // 
            resources.ApplyResources(this.zipalignOutputDirChkBox, "zipalignOutputDirChkBox");
            this.zipalignOutputDirChkBox.Checked = global::APKToolGUI.Properties.Settings.Default.Zipalign_UseOutputDir;
            this.zipalignOutputDirChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Zipalign_UseOutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.zipalignOutputDirChkBox.Name = "zipalignOutputDirChkBox";
            this.zipalignOutputDirChkBox.UseVisualStyleBackColor = true;
            // 
            // signAfterZipalignChkBox
            // 
            resources.ApplyResources(this.signAfterZipalignChkBox, "signAfterZipalignChkBox");
            this.signAfterZipalignChkBox.Name = "signAfterZipalignChkBox";
            this.signAfterZipalignChkBox.UseVisualStyleBackColor = true;
            // 
            // checkBox_ZIPALIGN_Recompress
            // 
            resources.ApplyResources(this.checkBox_ZIPALIGN_Recompress, "checkBox_ZIPALIGN_Recompress");
            this.checkBox_ZIPALIGN_Recompress.Checked = global::APKToolGUI.Properties.Settings.Default.Zipalign_Recompress;
            this.checkBox_ZIPALIGN_Recompress.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Zipalign_Recompress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_ZIPALIGN_Recompress.Name = "checkBox_ZIPALIGN_Recompress";
            this.checkBox_ZIPALIGN_Recompress.UseVisualStyleBackColor = true;
            // 
            // label_ZIPALIGN_AlignmentBytes
            // 
            resources.ApplyResources(this.label_ZIPALIGN_AlignmentBytes, "label_ZIPALIGN_AlignmentBytes");
            this.label_ZIPALIGN_AlignmentBytes.Name = "label_ZIPALIGN_AlignmentBytes";
            // 
            // button_ZIPALIGN_BrowseOutputFile
            // 
            resources.ApplyResources(this.button_ZIPALIGN_BrowseOutputFile, "button_ZIPALIGN_BrowseOutputFile");
            this.button_ZIPALIGN_BrowseOutputFile.Name = "button_ZIPALIGN_BrowseOutputFile";
            this.button_ZIPALIGN_BrowseOutputFile.UseVisualStyleBackColor = true;
            // 
            // checkBox_ZIPALIGN_CheckAlignment
            // 
            resources.ApplyResources(this.checkBox_ZIPALIGN_CheckAlignment, "checkBox_ZIPALIGN_CheckAlignment");
            this.checkBox_ZIPALIGN_CheckAlignment.Checked = global::APKToolGUI.Properties.Settings.Default.Zipalign_CheckOnly;
            this.checkBox_ZIPALIGN_CheckAlignment.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Zipalign_CheckOnly", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_ZIPALIGN_CheckAlignment.Name = "checkBox_ZIPALIGN_CheckAlignment";
            this.checkBox_ZIPALIGN_CheckAlignment.UseVisualStyleBackColor = true;
            // 
            // textBox_ZIPALIGN_OutputFile
            // 
            this.textBox_ZIPALIGN_OutputFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Zipalign_OutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.textBox_ZIPALIGN_OutputFile, "textBox_ZIPALIGN_OutputFile");
            this.textBox_ZIPALIGN_OutputFile.Name = "textBox_ZIPALIGN_OutputFile";
            this.textBox_ZIPALIGN_OutputFile.Text = global::APKToolGUI.Properties.Settings.Default.Zipalign_OutputDir;
            // 
            // checkBox_ZIPALIGN_VerboseOutput
            // 
            resources.ApplyResources(this.checkBox_ZIPALIGN_VerboseOutput, "checkBox_ZIPALIGN_VerboseOutput");
            this.checkBox_ZIPALIGN_VerboseOutput.Checked = global::APKToolGUI.Properties.Settings.Default.Zipalign_Verbose;
            this.checkBox_ZIPALIGN_VerboseOutput.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Zipalign_Verbose", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_ZIPALIGN_VerboseOutput.Name = "checkBox_ZIPALIGN_VerboseOutput";
            this.checkBox_ZIPALIGN_VerboseOutput.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_ZIPALIGN_AlignmentBytes
            // 
            this.numericUpDown_ZIPALIGN_AlignmentBytes.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::APKToolGUI.Properties.Settings.Default, "Zipalign_AlignmentInBytes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.numericUpDown_ZIPALIGN_AlignmentBytes, "numericUpDown_ZIPALIGN_AlignmentBytes");
            this.numericUpDown_ZIPALIGN_AlignmentBytes.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown_ZIPALIGN_AlignmentBytes.Name = "numericUpDown_ZIPALIGN_AlignmentBytes";
            this.numericUpDown_ZIPALIGN_AlignmentBytes.Value = global::APKToolGUI.Properties.Settings.Default.Zipalign_AlignmentInBytes;
            // 
            // checkBox_ZIPALIGN_OverwriteOutputFile
            // 
            resources.ApplyResources(this.checkBox_ZIPALIGN_OverwriteOutputFile, "checkBox_ZIPALIGN_OverwriteOutputFile");
            this.checkBox_ZIPALIGN_OverwriteOutputFile.Checked = global::APKToolGUI.Properties.Settings.Default.Zipalign_OverwriteOutputFile;
            this.checkBox_ZIPALIGN_OverwriteOutputFile.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Zipalign_OverwriteOutputFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_ZIPALIGN_OverwriteOutputFile.Name = "checkBox_ZIPALIGN_OverwriteOutputFile";
            this.checkBox_ZIPALIGN_OverwriteOutputFile.UseVisualStyleBackColor = true;
            // 
            // tabPageInstallFramework
            // 
            this.tabPageInstallFramework.BackColor = System.Drawing.Color.White;
            this.tabPageInstallFramework.Controls.Add(this.groupBox1);
            this.tabPageInstallFramework.Controls.Add(this.groupBox_IF_Options);
            resources.ApplyResources(this.tabPageInstallFramework, "tabPageInstallFramework");
            this.tabPageInstallFramework.Name = "tabPageInstallFramework";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openFwFolderBtn);
            this.groupBox1.Controls.Add(this.clearFwBtn);
            this.groupBox1.Controls.Add(this.clearFwBeforeDecodeChkBox);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // openFwFolderBtn
            // 
            resources.ApplyResources(this.openFwFolderBtn, "openFwFolderBtn");
            this.openFwFolderBtn.Name = "openFwFolderBtn";
            this.openFwFolderBtn.UseVisualStyleBackColor = true;
            // 
            // clearFwBtn
            // 
            resources.ApplyResources(this.clearFwBtn, "clearFwBtn");
            this.clearFwBtn.Name = "clearFwBtn";
            this.clearFwBtn.UseVisualStyleBackColor = true;
            // 
            // clearFwBeforeDecodeChkBox
            // 
            resources.ApplyResources(this.clearFwBeforeDecodeChkBox, "clearFwBeforeDecodeChkBox");
            this.clearFwBeforeDecodeChkBox.Checked = global::APKToolGUI.Properties.Settings.Default.Framework_ClearBeforeDecode;
            this.clearFwBeforeDecodeChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearFwBeforeDecodeChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Framework_ClearBeforeDecode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.clearFwBeforeDecodeChkBox.Name = "clearFwBeforeDecodeChkBox";
            this.clearFwBeforeDecodeChkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox_IF_Options
            // 
            resources.ApplyResources(this.groupBox_IF_Options, "groupBox_IF_Options");
            this.groupBox_IF_Options.Controls.Add(this.checkBox_IF_Tag);
            this.groupBox_IF_Options.Controls.Add(this.checkBox_IF_FramePath);
            this.groupBox_IF_Options.Controls.Add(this.textBox_IF_Tag);
            this.groupBox_IF_Options.Controls.Add(this.button_IF_InstallFramework);
            this.groupBox_IF_Options.Controls.Add(this.button_IF_BrowseFrameDir);
            this.groupBox_IF_Options.Controls.Add(this.button_IF_BrowseInputFramePath);
            this.groupBox_IF_Options.Controls.Add(this.textBox_IF_InputFramePath);
            this.groupBox_IF_Options.Controls.Add(this.textBox_IF_FrameDir);
            this.groupBox_IF_Options.Name = "groupBox_IF_Options";
            this.groupBox_IF_Options.TabStop = false;
            // 
            // checkBox_IF_Tag
            // 
            resources.ApplyResources(this.checkBox_IF_Tag, "checkBox_IF_Tag");
            this.checkBox_IF_Tag.Checked = global::APKToolGUI.Properties.Settings.Default.InstallFramework_UseTag;
            this.checkBox_IF_Tag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "InstallFramework_UseTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_IF_Tag.Name = "checkBox_IF_Tag";
            this.checkBox_IF_Tag.UseVisualStyleBackColor = true;
            // 
            // checkBox_IF_FramePath
            // 
            resources.ApplyResources(this.checkBox_IF_FramePath, "checkBox_IF_FramePath");
            this.checkBox_IF_FramePath.Checked = global::APKToolGUI.Properties.Settings.Default.InstallFramework_UseFrameDir;
            this.checkBox_IF_FramePath.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "InstallFramework_UseFrameDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_IF_FramePath.Name = "checkBox_IF_FramePath";
            this.checkBox_IF_FramePath.UseVisualStyleBackColor = true;
            // 
            // textBox_IF_Tag
            // 
            this.textBox_IF_Tag.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "InstallFramework_Tag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_IF_Tag.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::APKToolGUI.Properties.Settings.Default, "InstallFramework_UseTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_IF_Tag.Enabled = global::APKToolGUI.Properties.Settings.Default.InstallFramework_UseTag;
            resources.ApplyResources(this.textBox_IF_Tag, "textBox_IF_Tag");
            this.textBox_IF_Tag.Name = "textBox_IF_Tag";
            this.textBox_IF_Tag.Text = global::APKToolGUI.Properties.Settings.Default.InstallFramework_Tag;
            // 
            // button_IF_InstallFramework
            // 
            resources.ApplyResources(this.button_IF_InstallFramework, "button_IF_InstallFramework");
            this.button_IF_InstallFramework.Name = "button_IF_InstallFramework";
            this.button_IF_InstallFramework.UseVisualStyleBackColor = true;
            // 
            // button_IF_BrowseFrameDir
            // 
            this.button_IF_BrowseFrameDir.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::APKToolGUI.Properties.Settings.Default, "InstallFramework_UseFrameDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_IF_BrowseFrameDir.Enabled = global::APKToolGUI.Properties.Settings.Default.InstallFramework_UseFrameDir;
            resources.ApplyResources(this.button_IF_BrowseFrameDir, "button_IF_BrowseFrameDir");
            this.button_IF_BrowseFrameDir.Name = "button_IF_BrowseFrameDir";
            this.button_IF_BrowseFrameDir.UseVisualStyleBackColor = true;
            // 
            // button_IF_BrowseInputFramePath
            // 
            resources.ApplyResources(this.button_IF_BrowseInputFramePath, "button_IF_BrowseInputFramePath");
            this.button_IF_BrowseInputFramePath.Name = "button_IF_BrowseInputFramePath";
            this.button_IF_BrowseInputFramePath.UseVisualStyleBackColor = true;
            // 
            // textBox_IF_InputFramePath
            // 
            resources.ApplyResources(this.textBox_IF_InputFramePath, "textBox_IF_InputFramePath");
            this.textBox_IF_InputFramePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "InstallFramework_InputFramePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_IF_InputFramePath.Name = "textBox_IF_InputFramePath";
            this.textBox_IF_InputFramePath.Text = global::APKToolGUI.Properties.Settings.Default.InstallFramework_InputFramePath;
            // 
            // textBox_IF_FrameDir
            // 
            this.textBox_IF_FrameDir.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::APKToolGUI.Properties.Settings.Default, "InstallFramework_UseFrameDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_IF_FrameDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "InstallFramework_FrameDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_IF_FrameDir.Enabled = global::APKToolGUI.Properties.Settings.Default.InstallFramework_UseFrameDir;
            resources.ApplyResources(this.textBox_IF_FrameDir, "textBox_IF_FrameDir");
            this.textBox_IF_FrameDir.Name = "textBox_IF_FrameDir";
            this.textBox_IF_FrameDir.Text = global::APKToolGUI.Properties.Settings.Default.InstallFramework_FrameDir;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.smaliGroupBox);
            this.tabPage1.Controls.Add(this.bakSmaliGroupBox);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // smaliGroupBox
            // 
            this.smaliGroupBox.Controls.Add(this.label29);
            this.smaliGroupBox.Controls.Add(this.smaliUseOutputChkBox);
            this.smaliGroupBox.Controls.Add(this.comSmaliBtn);
            this.smaliGroupBox.Controls.Add(this.smaliBrowseOutputBtn);
            this.smaliGroupBox.Controls.Add(this.smaliBrowseInputDirTxtBox);
            this.smaliGroupBox.Controls.Add(this.smaliBrowseOutputTxtBox);
            this.smaliGroupBox.Controls.Add(this.smaliBrowseInputDirBtn);
            resources.ApplyResources(this.smaliGroupBox, "smaliGroupBox");
            this.smaliGroupBox.Name = "smaliGroupBox";
            this.smaliGroupBox.TabStop = false;
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // smaliUseOutputChkBox
            // 
            resources.ApplyResources(this.smaliUseOutputChkBox, "smaliUseOutputChkBox");
            this.smaliUseOutputChkBox.Checked = global::APKToolGUI.Properties.Settings.Default.Smali_UseOutputDir;
            this.smaliUseOutputChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Smali_UseOutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smaliUseOutputChkBox.Name = "smaliUseOutputChkBox";
            this.smaliUseOutputChkBox.UseVisualStyleBackColor = true;
            // 
            // comSmaliBtn
            // 
            resources.ApplyResources(this.comSmaliBtn, "comSmaliBtn");
            this.comSmaliBtn.Name = "comSmaliBtn";
            this.comSmaliBtn.UseVisualStyleBackColor = true;
            // 
            // smaliBrowseOutputBtn
            // 
            resources.ApplyResources(this.smaliBrowseOutputBtn, "smaliBrowseOutputBtn");
            this.smaliBrowseOutputBtn.Name = "smaliBrowseOutputBtn";
            this.smaliBrowseOutputBtn.UseVisualStyleBackColor = true;
            // 
            // smaliBrowseInputDirTxtBox
            // 
            resources.ApplyResources(this.smaliBrowseInputDirTxtBox, "smaliBrowseInputDirTxtBox");
            this.smaliBrowseInputDirTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Smali_InputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smaliBrowseInputDirTxtBox.Name = "smaliBrowseInputDirTxtBox";
            this.smaliBrowseInputDirTxtBox.Text = global::APKToolGUI.Properties.Settings.Default.Smali_InputDir;
            // 
            // smaliBrowseOutputTxtBox
            // 
            this.smaliBrowseOutputTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Smali_OutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.smaliBrowseOutputTxtBox, "smaliBrowseOutputTxtBox");
            this.smaliBrowseOutputTxtBox.Name = "smaliBrowseOutputTxtBox";
            this.smaliBrowseOutputTxtBox.Text = global::APKToolGUI.Properties.Settings.Default.Smali_OutputDir;
            // 
            // smaliBrowseInputDirBtn
            // 
            resources.ApplyResources(this.smaliBrowseInputDirBtn, "smaliBrowseInputDirBtn");
            this.smaliBrowseInputDirBtn.Name = "smaliBrowseInputDirBtn";
            this.smaliBrowseInputDirBtn.UseVisualStyleBackColor = true;
            // 
            // bakSmaliGroupBox
            // 
            this.bakSmaliGroupBox.Controls.Add(this.label28);
            this.bakSmaliGroupBox.Controls.Add(this.baksmaliUseOutputChkBox);
            this.bakSmaliGroupBox.Controls.Add(this.baksmaliBrowseOutputBtn);
            this.bakSmaliGroupBox.Controls.Add(this.baksmaliBrowseOutputTxtBox);
            this.bakSmaliGroupBox.Controls.Add(this.decSmaliBtn);
            this.bakSmaliGroupBox.Controls.Add(this.baksmaliBrowseInputDexBtn);
            this.bakSmaliGroupBox.Controls.Add(this.baksmaliBrowseInputDexTxtBox);
            resources.ApplyResources(this.bakSmaliGroupBox, "bakSmaliGroupBox");
            this.bakSmaliGroupBox.Name = "bakSmaliGroupBox";
            this.bakSmaliGroupBox.TabStop = false;
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // baksmaliUseOutputChkBox
            // 
            resources.ApplyResources(this.baksmaliUseOutputChkBox, "baksmaliUseOutputChkBox");
            this.baksmaliUseOutputChkBox.Checked = global::APKToolGUI.Properties.Settings.Default.Baksmali_UseOutputDir;
            this.baksmaliUseOutputChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::APKToolGUI.Properties.Settings.Default, "Baksmali_UseOutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.baksmaliUseOutputChkBox.Name = "baksmaliUseOutputChkBox";
            this.baksmaliUseOutputChkBox.UseVisualStyleBackColor = true;
            // 
            // baksmaliBrowseOutputBtn
            // 
            resources.ApplyResources(this.baksmaliBrowseOutputBtn, "baksmaliBrowseOutputBtn");
            this.baksmaliBrowseOutputBtn.Name = "baksmaliBrowseOutputBtn";
            this.baksmaliBrowseOutputBtn.UseVisualStyleBackColor = true;
            // 
            // baksmaliBrowseOutputTxtBox
            // 
            this.baksmaliBrowseOutputTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Baksmali_OutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.baksmaliBrowseOutputTxtBox, "baksmaliBrowseOutputTxtBox");
            this.baksmaliBrowseOutputTxtBox.Name = "baksmaliBrowseOutputTxtBox";
            this.baksmaliBrowseOutputTxtBox.Text = global::APKToolGUI.Properties.Settings.Default.Baksmali_OutputDir;
            // 
            // decSmaliBtn
            // 
            resources.ApplyResources(this.decSmaliBtn, "decSmaliBtn");
            this.decSmaliBtn.Name = "decSmaliBtn";
            this.decSmaliBtn.UseVisualStyleBackColor = true;
            // 
            // baksmaliBrowseInputDexBtn
            // 
            resources.ApplyResources(this.baksmaliBrowseInputDexBtn, "baksmaliBrowseInputDexBtn");
            this.baksmaliBrowseInputDexBtn.Name = "baksmaliBrowseInputDexBtn";
            this.baksmaliBrowseInputDexBtn.UseVisualStyleBackColor = true;
            // 
            // baksmaliBrowseInputDexTxtBox
            // 
            resources.ApplyResources(this.baksmaliBrowseInputDexTxtBox, "baksmaliBrowseInputDexTxtBox");
            this.baksmaliBrowseInputDexTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APKToolGUI.Properties.Settings.Default, "Baksmali_InputDexFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.baksmaliBrowseInputDexTxtBox.Name = "baksmaliBrowseInputDexTxtBox";
            this.baksmaliBrowseInputDexTxtBox.Text = global::APKToolGUI.Properties.Settings.Default.Baksmali_InputDexFile;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStateImage,
            this.toolStripStatusLabelStateText,
            this.toolStripProgressBar1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.SizingGrip = false;
            // 
            // toolStripStatusLabelStateImage
            // 
            this.toolStripStatusLabelStateImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabelStateImage.Name = "toolStripStatusLabelStateImage";
            resources.ApplyResources(this.toolStripStatusLabelStateImage, "toolStripStatusLabelStateImage");
            // 
            // toolStripStatusLabelStateText
            // 
            this.toolStripStatusLabelStateText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripStatusLabelStateText, "toolStripStatusLabelStateText");
            this.toolStripStatusLabelStateText.Name = "toolStripStatusLabelStateText";
            this.toolStripStatusLabelStateText.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripStatusLabelStateText.Spring = true;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 30;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // logGridView
            // 
            this.logGridView.AllowUserToAddRows = false;
            this.logGridView.AllowUserToDeleteRows = false;
            this.logGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.logGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.logGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.logGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.logGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            resources.ApplyResources(this.logGridView, "logGridView");
            this.logGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.logGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImage,
            this.ColumnTime,
            this.ColumnMessage});
            this.logGridView.ContextMenuStrip = this.contextMenuStripLog;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.logGridView.Name = "logGridView";
            this.logGridView.ReadOnly = true;
            this.logGridView.RowHeadersVisible = false;
            this.logGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logGridView.RowTemplate.Height = 15;
            this.logGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logGridView.ShowEditingIcon = false;
            // 
            // ColumnImage
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnImage.Frozen = true;
            resources.ApplyResources(this.ColumnImage, "ColumnImage");
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnTime
            // 
            resources.ApplyResources(this.ColumnTime, "ColumnTime");
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            // 
            // ColumnMessage
            // 
            this.ColumnMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ColumnMessage, "ColumnMessage");
            this.ColumnMessage.Name = "ColumnMessage";
            this.ColumnMessage.ReadOnly = true;
            // 
            // contextMenuStripLog
            // 
            this.contextMenuStripLog.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogToolStripMenuItem});
            this.contextMenuStripLog.Name = "contextMenuStripLog";
            resources.ApplyResources(this.contextMenuStripLog, "contextMenuStripLog");
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            resources.ApplyResources(this.clearLogToolStripMenuItem, "clearLogToolStripMenuItem");
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemHelp});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.saveLogItem,
            this.menuItemSettings,
            this.menuItemExit});
            resources.ApplyResources(this.menuItemFile, "menuItemFile");
            // 
            // saveLogItem
            // 
            this.saveLogItem.Index = 0;
            resources.ApplyResources(this.saveLogItem, "saveLogItem");
            this.saveLogItem.Click += new System.EventHandler(this.saveLogItem_Click);
            // 
            // menuItemSettings
            // 
            this.menuItemSettings.Index = 1;
            resources.ApplyResources(this.menuItemSettings, "menuItemSettings");
            this.menuItemSettings.Click += new System.EventHandler(this.menuItemSettings_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 2;
            resources.ApplyResources(this.menuItemExit, "menuItemExit");
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Index = 1;
            this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemCheckUpdate,
            this.apktoolIssueItem,
            this.menuItemAbout});
            resources.ApplyResources(this.menuItemHelp, "menuItemHelp");
            // 
            // menuItemCheckUpdate
            // 
            this.menuItemCheckUpdate.Index = 0;
            resources.ApplyResources(this.menuItemCheckUpdate, "menuItemCheckUpdate");
            this.menuItemCheckUpdate.Click += new System.EventHandler(this.menuItemCheckUpdate_Click);
            // 
            // apktoolIssueItem
            // 
            this.apktoolIssueItem.Index = 1;
            resources.ApplyResources(this.apktoolIssueItem, "apktoolIssueItem");
            this.apktoolIssueItem.Click += new System.EventHandler(this.apktoolIssueItem_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 2;
            resources.ApplyResources(this.menuItemAbout, "menuItemAbout");
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.logGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControlMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Menu = this.mainMenu1;
            this.Name = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.signPanel.ResumeLayout(false);
            this.signPanel.PerformLayout();
            this.zipalignPanel.ResumeLayout(false);
            this.zipalignPanel.PerformLayout();
            this.comPanel.ResumeLayout(false);
            this.comPanel.PerformLayout();
            this.decPanel.ResumeLayout(false);
            this.decPanel.PerformLayout();
            this.tabPageApkInfo.ResumeLayout(false);
            this.tabPageApkInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apkIconPicBox)).EndInit();
            this.tabPageDecode.ResumeLayout(false);
            this.groupBox_DECODE_Options.ResumeLayout(false);
            this.groupBox_DECODE_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decApiLvlUpDown)).EndInit();
            this.tabPageBuild.ResumeLayout(false);
            this.groupBox_BUILD_Options.ResumeLayout(false);
            this.groupBox_BUILD_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildApiLvlUpDown)).EndInit();
            this.tabPageSign.ResumeLayout(false);
            this.groupBox_SIGN_Options.ResumeLayout(false);
            this.groupBox_SIGN_Options.PerformLayout();
            this.tabPageZipAlign.ResumeLayout(false);
            this.groupBox_ZIPALIGN_Options.ResumeLayout(false);
            this.groupBox_ZIPALIGN_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ZIPALIGN_AlignmentBytes)).EndInit();
            this.tabPageInstallFramework.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_IF_Options.ResumeLayout(false);
            this.groupBox_IF_Options.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.smaliGroupBox.ResumeLayout(false);
            this.smaliGroupBox.PerformLayout();
            this.bakSmaliGroupBox.ResumeLayout(false);
            this.bakSmaliGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).EndInit();
            this.contextMenuStripLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TabControl tabControlMain;
        internal System.Windows.Forms.TabPage tabPageDecode;
        internal System.Windows.Forms.TabPage tabPageSign;
        internal System.Windows.Forms.TabPage tabPageZipAlign;
        internal System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStateText;
        internal System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        internal System.Windows.Forms.DataGridView logGridView;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStateImage;
        internal System.Windows.Forms.ContextMenuStrip contextMenuStripLog;
        internal System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        internal System.Windows.Forms.TabPage tabPageBuild;
        internal System.Windows.Forms.TabPage tabPageInstallFramework;
        internal System.Windows.Forms.TextBox textBox_IF_InputFramePath;
        internal System.Windows.Forms.Button button_IF_BrowseInputFramePath;
        internal System.Windows.Forms.Button button_IF_InstallFramework;
        internal System.Windows.Forms.MainMenu mainMenu1;
        internal System.Windows.Forms.MenuItem menuItemFile;
        internal System.Windows.Forms.MenuItem menuItemHelp;
        internal System.Windows.Forms.MenuItem menuItemSettings;
        internal System.Windows.Forms.MenuItem menuItemExit;
        internal System.Windows.Forms.MenuItem menuItemCheckUpdate;
        internal System.Windows.Forms.MenuItem menuItemAbout;
        internal System.Windows.Forms.GroupBox groupBox_BUILD_Options;
        internal System.Windows.Forms.Button button_BUILD_BrowseOutputAppPath;
        internal System.Windows.Forms.CheckBox checkBox_BUILD_OutputAppPath;
        internal System.Windows.Forms.TextBox textBox_BUILD_OutputAppPath;
        internal System.Windows.Forms.CheckBox checkBox_BUILD_CopyOriginal;
        internal System.Windows.Forms.Button button_BUILD_BrowseFrameDir;
        internal System.Windows.Forms.CheckBox checkBox_BUILD_UseFramework;
        internal System.Windows.Forms.TextBox textBox_BUILD_FrameDir;
        internal System.Windows.Forms.TextBox textBox_BUILD_AaptPath;
        internal System.Windows.Forms.CheckBox checkBox_BUILD_UseAapt;
        internal System.Windows.Forms.Button button_BUILD_BrowseAaptPath;
        internal System.Windows.Forms.CheckBox checkBox_BUILD_ForceAll;
        internal System.Windows.Forms.GroupBox groupBox_IF_Options;
        internal System.Windows.Forms.CheckBox checkBox_IF_Tag;
        internal System.Windows.Forms.TextBox textBox_IF_Tag;
        internal System.Windows.Forms.TextBox textBox_IF_FrameDir;
        internal System.Windows.Forms.CheckBox checkBox_IF_FramePath;
        internal System.Windows.Forms.Button button_IF_BrowseFrameDir;
        internal System.Windows.Forms.GroupBox groupBox_ZIPALIGN_Options;
        internal System.Windows.Forms.Label label_ZIPALIGN_AlignmentBytes;
        internal System.Windows.Forms.NumericUpDown numericUpDown_ZIPALIGN_AlignmentBytes;
        internal System.Windows.Forms.CheckBox checkBox_ZIPALIGN_VerboseOutput;
        internal System.Windows.Forms.CheckBox checkBox_ZIPALIGN_CheckAlignment;
        internal System.Windows.Forms.Button button_ZIPALIGN_BrowseOutputFile;
        internal System.Windows.Forms.TextBox textBox_ZIPALIGN_OutputFile;
        internal System.Windows.Forms.CheckBox checkBox_ZIPALIGN_OverwriteOutputFile;
        internal System.Windows.Forms.CheckBox checkBox_ZIPALIGN_Recompress;
        internal System.Windows.Forms.GroupBox groupBox_SIGN_Options;
        internal System.Windows.Forms.Label label_SIGN_PrivateKey;
        internal System.Windows.Forms.Button button_SIGN_BrowsePrivateKey;
        internal System.Windows.Forms.TextBox textBox_SIGN_PrivateKey;
        internal System.Windows.Forms.Label label_SIGN_PublicKey;
        internal System.Windows.Forms.Button button_SIGN_BrowsePublicKey;
        internal System.Windows.Forms.TextBox textBox_SIGN_PublicKey;
        internal System.Windows.Forms.Button button_SIGN_BrowseOutputFile;
        internal System.Windows.Forms.TextBox textBox_SIGN_OutputFile;
        internal System.Windows.Forms.TabPage tabPageMain;
        internal System.Windows.Forms.GroupBox groupBox_DECODE_Options;
        internal System.Windows.Forms.CheckBox checkBox_DECODE_MatchOriginal;
        internal System.Windows.Forms.CheckBox checkBox_DECODE_KeepBrokenRes;
        internal System.Windows.Forms.CheckBox checkBox_DECODE_Force;
        internal System.Windows.Forms.Panel signPanel;
        internal System.Windows.Forms.TextBox textBox_SIGN_InputFile;
        internal System.Windows.Forms.Button button_SIGN_BrowseInputFile;
        internal System.Windows.Forms.Button button_SIGN_Sign;
        internal System.Windows.Forms.Panel zipalignPanel;
        internal System.Windows.Forms.Button button_ZIPALIGN_Align;
        internal System.Windows.Forms.Button button_ZIPALIGN_BrowseInputFile;
        internal System.Windows.Forms.TextBox textBox_ZIPALIGN_InputFile;
        internal System.Windows.Forms.Panel comPanel;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button button_BUILD_BrowseInputProjectDir;
        internal System.Windows.Forms.Button button_BUILD_Build;
        internal System.Windows.Forms.TextBox textBox_BUILD_InputProjectDir;
        internal System.Windows.Forms.Panel decPanel;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textBox_DECODE_InputAppPath;
        internal System.Windows.Forms.Button button_DECODE_Decode;
        internal System.Windows.Forms.Button button_DECODE_BrowseInputAppPath;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox textBox_DECODE_FrameDir;
        internal System.Windows.Forms.Button button_DECODE_BrowseOutputDirectory;
        internal System.Windows.Forms.CheckBox checkBox_DECODE_UseFramework;
        internal System.Windows.Forms.Button button_DECODE_BrowseFrameDir;
        internal System.Windows.Forms.CheckBox checkBox_DECODE_OutputDirectory;
        internal System.Windows.Forms.TextBox textBox_DECODE_OutputDirectory;
        internal System.Windows.Forms.CheckBox checkBox_DECODE_NoSrc;
        internal System.Windows.Forms.CheckBox checkBox_DECODE_NoRes;
        internal System.Windows.Forms.Button button_OpenMainActivity;
        internal System.Windows.Forms.Button openAndroidMainfestBtn;
        internal System.Windows.Forms.CheckBox checkBox_DECODE_OnlyMainClasses;
        internal System.Windows.Forms.CheckBox checkBox_BUILD_NoCrunch;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.CheckBox checkBox_DECODE_FixError;
        internal System.Windows.Forms.TabPage tabPageApkInfo;
        internal System.Windows.Forms.RichTextBox permTxtBox;
        internal System.Windows.Forms.TextBox buildTxtBox;
        internal System.Windows.Forms.PictureBox apkIconPicBox;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox densityTxtBox;
        internal System.Windows.Forms.TextBox screenTxtBox;
        internal System.Windows.Forms.TextBox minSdkTxtBox;
        internal System.Windows.Forms.TextBox verTxtBox;
        internal System.Windows.Forms.TextBox packNameTxtBox;
        internal System.Windows.Forms.TextBox appTxtBox;
        internal System.Windows.Forms.CheckBox checkBox_DECODE_NoDebugInfo;
        internal System.Windows.Forms.RichTextBox localsTxtBox;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.TextBox targetSdkTxtBox;
        internal System.Windows.Forms.TextBox fileTxtBox;
        internal System.Windows.Forms.Button comApkOpenDir;
        internal System.Windows.Forms.Button decApkOpenDirBtn;
        internal System.Windows.Forms.Button selectedApkOpenDirBtn;
        internal System.Windows.Forms.Button apkComboLinkBtn;
        internal System.Windows.Forms.Button apkPureLinkBtn;
        internal System.Windows.Forms.Button psLinkBtn;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.CheckBox zipalignAfterBuildChkBox;
        internal System.Windows.Forms.CheckBox clearFwBeforeDecodeChkBox;
        internal System.Windows.Forms.Button clearFwBtn;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.CheckBox signAfterBuildChkBox;
        internal System.Windows.Forms.CheckBox signAfterZipalignChkBox;
        internal System.Windows.Forms.CheckBox zipalignOutputDirChkBox;
        internal System.Windows.Forms.CheckBox useSigningOutputDir;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.TextBox keyStoreFileTxtBox;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.CheckBox useKeyStoreChkBox;
        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.Button selectKeyStoreFileBtn;
        internal System.Windows.Forms.TextBox aliasTxtBox;
        internal System.Windows.Forms.CheckBox useAliasChkBox;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.CheckBox checkBox1;
        internal System.Windows.Forms.ComboBox schemev4ComboBox;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.ComboBox schemev3ComboBox;
        internal System.Windows.Forms.Label label26;
        internal System.Windows.Forms.ComboBox schemev2ComboBox;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.ComboBox schemev1ComboBox;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.NumericUpDown decApiLvlUpDown;
        internal System.Windows.Forms.CheckBox decSetApiLvlChkBox;
        internal System.Windows.Forms.NumericUpDown buildApiLvlUpDown;
        internal System.Windows.Forms.CheckBox buildSetApiLvlChkBox;
        internal System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.Button openFwFolderBtn;
        internal System.Windows.Forms.Button selApkFileInfoBtn;
        internal System.Windows.Forms.GroupBox smaliGroupBox;
        internal System.Windows.Forms.GroupBox bakSmaliGroupBox;
        internal System.Windows.Forms.Button comSmaliBtn;
        internal System.Windows.Forms.TextBox smaliBrowseInputDirTxtBox;
        internal System.Windows.Forms.Button smaliBrowseInputDirBtn;
        internal System.Windows.Forms.Button decSmaliBtn;
        internal System.Windows.Forms.Button baksmaliBrowseInputDexBtn;
        internal System.Windows.Forms.TextBox baksmaliBrowseInputDexTxtBox;
        internal System.Windows.Forms.CheckBox smaliUseOutputChkBox;
        internal System.Windows.Forms.Button smaliBrowseOutputBtn;
        internal System.Windows.Forms.TextBox smaliBrowseOutputTxtBox;
        internal System.Windows.Forms.CheckBox baksmaliUseOutputChkBox;
        internal System.Windows.Forms.Button baksmaliBrowseOutputBtn;
        internal System.Windows.Forms.TextBox baksmaliBrowseOutputTxtBox;
        internal System.Windows.Forms.Button openApktoolYmlBtn;
        internal System.Windows.Forms.Button apkAioLinkBtn;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMessage;
        private System.Windows.Forms.MenuItem apktoolIssueItem;
        private System.Windows.Forms.MenuItem saveLogItem;
        internal System.Windows.Forms.Button signApkOpenDirBtn;
        internal System.Windows.Forms.Button alignApkOpenDirBtn;
    }
}

