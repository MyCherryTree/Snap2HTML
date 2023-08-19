namespace Snap2HTML
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchPattern = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkOpenOutput = new System.Windows.Forms.CheckBox();
            this.txtLinkRoot = new System.Windows.Forms.TextBox();
            this.chkLinkFiles = new System.Windows.Forms.CheckBox();
            this.chkHidden = new System.Windows.Forms.CheckBox();
            this.chkSystem = new System.Windows.Forms.CheckBox();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.labelRootFolder = new System.Windows.Forms.Label();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBoxDonate = new System.Windows.Forms.PictureBox();
            this.groupBoxMoreApps = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelAboutSoftware = new System.Windows.Forms.Label();
            this.labelAboutVersion = new System.Windows.Forms.Label();
            this.labelAboutTitle = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate)).BeginInit();
            this.groupBoxMoreApps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(531, 31);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(263, 24);
            this.toolStripStatusLabel1.Text = "Select a root folder to begin...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(507, 465);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtSearchPattern);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtTitle);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.chkOpenOutput);
            this.tabPage1.Controls.Add(this.txtLinkRoot);
            this.tabPage1.Controls.Add(this.chkLinkFiles);
            this.tabPage1.Controls.Add(this.chkHidden);
            this.tabPage1.Controls.Add(this.chkSystem);
            this.tabPage1.Controls.Add(this.cmdCreate);
            this.tabPage1.Controls.Add(this.txtRoot);
            this.tabPage1.Controls.Add(this.labelRootFolder);
            this.tabPage1.Controls.Add(this.cmdBrowse);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(499, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Snapshot";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search pattern:";
            // 
            // txtSearchPattern
            // 
            this.txtSearchPattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Snap2HTML.Properties.Settings.Default, "txtSearchPattern", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSearchPattern.Location = new System.Drawing.Point(32, 230);
            this.txtSearchPattern.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchPattern.Name = "txtSearchPattern";
            this.txtSearchPattern.Size = new System.Drawing.Size(448, 26);
            this.txtSearchPattern.TabIndex = 19;
            this.txtSearchPattern.Text = global::Snap2HTML.Properties.Settings.Default.txtSearchPattern;
            this.toolTip1.SetToolTip(this.txtSearchPattern, "Set search pattern");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Page title:";
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Snap2HTML.Properties.Settings.Default, "txtTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTitle.Location = new System.Drawing.Point(30, 174);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(448, 26);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Text = global::Snap2HTML.Properties.Settings.Default.txtTitle;
            this.toolTip1.SetToolTip(this.txtTitle, "Set the html page title");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Link files:";
            // 
            // chkOpenOutput
            // 
            this.chkOpenOutput.AutoSize = true;
            this.chkOpenOutput.Checked = global::Snap2HTML.Properties.Settings.Default.chkOpenOutput;
            this.chkOpenOutput.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Snap2HTML.Properties.Settings.Default, "chkOpenOutput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkOpenOutput.Location = new System.Drawing.Point(8, 370);
            this.chkOpenOutput.Margin = new System.Windows.Forms.Padding(4);
            this.chkOpenOutput.Name = "chkOpenOutput";
            this.chkOpenOutput.Size = new System.Drawing.Size(248, 24);
            this.chkOpenOutput.TabIndex = 18;
            this.chkOpenOutput.Text = "Open in browser when ready";
            this.chkOpenOutput.UseVisualStyleBackColor = true;
            // 
            // txtLinkRoot
            // 
            this.txtLinkRoot.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Snap2HTML.Properties.Settings.Default, "txtLinkRoot", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLinkRoot.Location = new System.Drawing.Point(30, 323);
            this.txtLinkRoot.Margin = new System.Windows.Forms.Padding(4);
            this.txtLinkRoot.Name = "txtLinkRoot";
            this.txtLinkRoot.Size = new System.Drawing.Size(448, 26);
            this.txtLinkRoot.TabIndex = 6;
            this.txtLinkRoot.Text = global::Snap2HTML.Properties.Settings.Default.txtLinkRoot;
            this.toolTip1.SetToolTip(this.txtLinkRoot, "This is the target files will be linked to. See ReadMe.txt for examples of how to" +
        " make links");
            // 
            // chkLinkFiles
            // 
            this.chkLinkFiles.AutoSize = true;
            this.chkLinkFiles.Checked = global::Snap2HTML.Properties.Settings.Default.chkLinkFiles;
            this.chkLinkFiles.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Snap2HTML.Properties.Settings.Default, "chkLinkFiles", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkLinkFiles.Location = new System.Drawing.Point(30, 294);
            this.chkLinkFiles.Margin = new System.Windows.Forms.Padding(4);
            this.chkLinkFiles.Name = "chkLinkFiles";
            this.chkLinkFiles.Size = new System.Drawing.Size(86, 24);
            this.chkLinkFiles.TabIndex = 5;
            this.chkLinkFiles.Text = "Enable";
            this.toolTip1.SetToolTip(this.chkLinkFiles, "Files can be linked so you can open them from within the html document");
            this.chkLinkFiles.UseVisualStyleBackColor = true;
            this.chkLinkFiles.CheckedChanged += new System.EventHandler(this.chkLinkFiles_CheckedChanged);
            // 
            // chkHidden
            // 
            this.chkHidden.AutoSize = true;
            this.chkHidden.Checked = global::Snap2HTML.Properties.Settings.Default.chkHidden;
            this.chkHidden.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Snap2HTML.Properties.Settings.Default, "chkHidden", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkHidden.Location = new System.Drawing.Point(30, 78);
            this.chkHidden.Margin = new System.Windows.Forms.Padding(4);
            this.chkHidden.Name = "chkHidden";
            this.chkHidden.Size = new System.Drawing.Size(188, 24);
            this.chkHidden.TabIndex = 2;
            this.chkHidden.Text = "Include hidden items";
            this.toolTip1.SetToolTip(this.chkHidden, "This applies to both files and folders");
            this.chkHidden.UseVisualStyleBackColor = true;
            // 
            // chkSystem
            // 
            this.chkSystem.AutoSize = true;
            this.chkSystem.Checked = global::Snap2HTML.Properties.Settings.Default.chkSystem;
            this.chkSystem.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Snap2HTML.Properties.Settings.Default, "chkSystem", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkSystem.Location = new System.Drawing.Point(30, 109);
            this.chkSystem.Margin = new System.Windows.Forms.Padding(4);
            this.chkSystem.Name = "chkSystem";
            this.chkSystem.Size = new System.Drawing.Size(193, 24);
            this.chkSystem.TabIndex = 3;
            this.chkSystem.Text = "Include system items";
            this.toolTip1.SetToolTip(this.chkSystem, "This applies to both files and folders");
            this.chkSystem.UseVisualStyleBackColor = true;
            // 
            // cmdCreate
            // 
            this.cmdCreate.Enabled = false;
            this.cmdCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCreate.Image = ((System.Drawing.Image)(resources.GetObject("cmdCreate.Image")));
            this.cmdCreate.Location = new System.Drawing.Point(278, 370);
            this.cmdCreate.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(200, 40);
            this.cmdCreate.TabIndex = 7;
            this.cmdCreate.Text = " Create Snapshot";
            this.cmdCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // txtRoot
            // 
            this.txtRoot.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Snap2HTML.Properties.Settings.Default, "txtRoot", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRoot.Location = new System.Drawing.Point(30, 42);
            this.txtRoot.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.ReadOnly = true;
            this.txtRoot.Size = new System.Drawing.Size(397, 26);
            this.txtRoot.TabIndex = 0;
            this.txtRoot.Text = global::Snap2HTML.Properties.Settings.Default.txtRoot;
            // 
            // labelRootFolder
            // 
            this.labelRootFolder.AutoSize = true;
            this.labelRootFolder.Location = new System.Drawing.Point(9, 17);
            this.labelRootFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRootFolder.Name = "labelRootFolder";
            this.labelRootFolder.Size = new System.Drawing.Size(96, 20);
            this.labelRootFolder.TabIndex = 1;
            this.labelRootFolder.Text = "Root folder:";
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBrowse.Image = ((System.Drawing.Image)(resources.GetObject("cmdBrowse.Image")));
            this.cmdBrowse.Location = new System.Drawing.Point(438, 35);
            this.cmdBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Padding = new System.Windows.Forms.Padding(3);
            this.cmdBrowse.Size = new System.Drawing.Size(42, 39);
            this.cmdBrowse.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmdBrowse, "Browse for root folder");
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabel5);
            this.tabPage3.Controls.Add(this.linkLabel4);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.pictureBox4);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(499, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Custom Design";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel5.Location = new System.Drawing.Point(26, 264);
            this.linkLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(161, 18);
            this.linkLabel5.TabIndex = 7;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Open contact page";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel4.Location = new System.Drawing.Point(26, 155);
            this.linkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(269, 18);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Open template.html in notepad";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(26, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(428, 46);
            this.label8.TabIndex = 8;
            this.label8.Text = "If you know some html/css you can modify the template yourself to better suit you" +
    "r needs:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(26, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 68);
            this.label7.TabIndex = 6;
            this.label7.Text = "You are also welcome to contact me and I can help you for a small compensation:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(261, 198);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 128);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(26, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 101);
            this.label4.TabIndex = 0;
            this.label4.Text = "Did you know that it is possible to change the appearance of the generated html f" +
    "ile? For example you might want to change the logo and colors to match your comp" +
    "any\'s.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBoxDonate);
            this.tabPage2.Controls.Add(this.groupBoxMoreApps);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.labelAboutSoftware);
            this.tabPage2.Controls.Add(this.labelAboutVersion);
            this.tabPage2.Controls.Add(this.labelAboutTitle);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(499, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDonate
            // 
            this.pictureBoxDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDonate.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDonate.Image")));
            this.pictureBoxDonate.Location = new System.Drawing.Point(290, 183);
            this.pictureBoxDonate.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxDonate.Name = "pictureBoxDonate";
            this.pictureBoxDonate.Size = new System.Drawing.Size(74, 21);
            this.pictureBoxDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDonate.TabIndex = 6;
            this.pictureBoxDonate.TabStop = false;
            this.pictureBoxDonate.Click += new System.EventHandler(this.pictureBoxDonate_Click);
            // 
            // groupBoxMoreApps
            // 
            this.groupBoxMoreApps.Controls.Add(this.label33);
            this.groupBoxMoreApps.Controls.Add(this.label32);
            this.groupBoxMoreApps.Controls.Add(this.linkLabel3);
            this.groupBoxMoreApps.Controls.Add(this.label17);
            this.groupBoxMoreApps.Controls.Add(this.linkLabel2);
            this.groupBoxMoreApps.Controls.Add(this.label11);
            this.groupBoxMoreApps.Controls.Add(this.pictureBox3);
            this.groupBoxMoreApps.Controls.Add(this.pictureBox2);
            this.groupBoxMoreApps.Location = new System.Drawing.Point(9, 244);
            this.groupBoxMoreApps.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMoreApps.Name = "groupBoxMoreApps";
            this.groupBoxMoreApps.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMoreApps.Size = new System.Drawing.Size(477, 177);
            this.groupBoxMoreApps.TabIndex = 5;
            this.groupBoxMoreApps.TabStop = false;
            this.groupBoxMoreApps.Text = "More utilities by me";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(314, 37);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(136, 20);
            this.label33.TabIndex = 13;
            this.label33.Text = "Flash Renamer";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(87, 37);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(158, 20);
            this.label32.TabIndex = 10;
            this.label32.Text = "Exif Tag Remover";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel3.Location = new System.Drawing.Point(87, 138);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(89, 18);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Tag = "http://www.rlvision.com/snap2html/about.asp";
            this.linkLabel3.Text = "More info";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(87, 55);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(162, 102);
            this.label17.TabIndex = 11;
            this.label17.Text = "Delete all metadata before publishing images to protect your privacy.";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel2.Location = new System.Drawing.Point(314, 138);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(89, 18);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Tag = "http://www.rlvision.com/flashren/about.asp";
            this.linkLabel2.Text = "More info";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(314, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 98);
            this.label11.TabIndex = 9;
            this.label11.Text = "Advanced file renaming utility that will save you lots of time.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(254, 37);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 37);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(244, 140);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(215, 18);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.rlvision.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelAboutSoftware
            // 
            this.labelAboutSoftware.AutoSize = true;
            this.labelAboutSoftware.Location = new System.Drawing.Point(244, 116);
            this.labelAboutSoftware.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAboutSoftware.Name = "labelAboutSoftware";
            this.labelAboutSoftware.Size = new System.Drawing.Size(242, 18);
            this.labelAboutSoftware.TabIndex = 2;
            this.labelAboutSoftware.Text = "Free Software by RL Vision";
            // 
            // labelAboutVersion
            // 
            this.labelAboutVersion.AutoSize = true;
            this.labelAboutVersion.Location = new System.Drawing.Point(244, 73);
            this.labelAboutVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAboutVersion.Name = "labelAboutVersion";
            this.labelAboutVersion.Size = new System.Drawing.Size(71, 18);
            this.labelAboutVersion.TabIndex = 1;
            this.labelAboutVersion.Text = "version";
            // 
            // labelAboutTitle
            // 
            this.labelAboutTitle.AutoSize = true;
            this.labelAboutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutTitle.Location = new System.Drawing.Point(242, 32);
            this.labelAboutTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAboutTitle.Name = "labelAboutTitle";
            this.labelAboutTitle.Size = new System.Drawing.Size(219, 40);
            this.labelAboutTitle.TabIndex = 0;
            this.labelAboutTitle.Text = "Snap2HTML";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AcceptButton = this.cmdCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 516);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snap2HTML";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate)).EndInit();
            this.groupBoxMoreApps.ResumeLayout(false);
            this.groupBoxMoreApps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.Label labelRootFolder;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label labelAboutSoftware;
		private System.Windows.Forms.Label labelAboutVersion;
		private System.Windows.Forms.Label labelAboutTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkOpenOutput;
        private System.Windows.Forms.TextBox txtLinkRoot;
        private System.Windows.Forms.CheckBox chkLinkFiles;
        private System.Windows.Forms.CheckBox chkHidden;
        private System.Windows.Forms.CheckBox chkSystem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.GroupBox groupBoxMoreApps;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.LinkLabel linkLabel5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBoxDonate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchPattern;
    }
}

