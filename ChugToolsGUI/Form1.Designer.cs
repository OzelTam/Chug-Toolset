
namespace ChugToolsGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAbortNameCheck = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStartNameCheck = new System.Windows.Forms.Button();
            this.lwCheckResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbCheckUsernames = new System.Windows.Forms.RichTextBox();
            this.txtLoadedCheckPackName = new ChugToolsGUI.UserControls.PlaceholderTextBox();
            this.listLoadedCheckers = new System.Windows.Forms.CheckedListBox();
            this.btnNameCheckLoadPack = new System.Windows.Forms.Button();
            this.txtLoadPackPath = new ChugToolsGUI.UserControls.PlaceholderTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnCreateChecker_URL = new System.Windows.Forms.Button();
            this.Checkertitle_URL = new ChugToolsGUI.UserControls.PlaceholderTextBox();
            this.UrlTextBox_URL = new ChugToolsGUI.UserControls.PlaceholderTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateInfoReq_URL = new System.Windows.Forms.Button();
            this.btn_RemoveInfoReq = new System.Windows.Forms.Button();
            this.FinderTitle_URL = new ChugToolsGUI.UserControls.PlaceholderTextBox();
            this.address_item1_URL = new ChugToolsGUI.UserControls.PlaceholderTextBox();
            this.listInfoReq_URL = new System.Windows.Forms.ListBox();
            this.address_item2_URL = new ChugToolsGUI.UserControls.PlaceholderTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Getby_URL = new System.Windows.Forms.ComboBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnCreateCheckerAPI = new System.Windows.Forms.Button();
            this.txtCheckerURL_API = new ChugToolsGUI.UserControls.PlaceholderTextBox();
            this.txtCheckerName_API = new ChugToolsGUI.UserControls.PlaceholderTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.method_API = new System.Windows.Forms.ComboBox();
            this.groupAvailableInfo = new System.Windows.Forms.GroupBox();
            this.btnRemoveInfoReqAPI = new System.Windows.Forms.Button();
            this.btnAddInfoReqAPI = new System.Windows.Forms.Button();
            this.listInfoReqAPI = new System.Windows.Forms.ListBox();
            this.txtValNameAPI = new ChugToolsGUI.UserControls.PlaceholderTextBox();
            this.txtNodePathAPI = new ChugToolsGUI.UserControls.PlaceholderTextBox();
            this.jsonTree = new System.Windows.Forms.TreeView();
            this.txtTestUserName_API = new ChugToolsGUI.UserControls.PlaceholderTextBox();
            this.btnTest_API = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listNewCheckers = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.removeNewChecker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCreatePack = new System.Windows.Forms.Button();
            this.txtNewPackName = new ChugToolsGUI.UserControls.PlaceholderTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabIcons = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupAvailableInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.TabIcons;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1269, 668);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1261, 638);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Name Check";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1255, 632);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAbortNameCheck);
            this.tabPage3.Controls.Add(this.progressBar1);
            this.tabPage3.Controls.Add(this.btnStartNameCheck);
            this.tabPage3.Controls.Add(this.lwCheckResults);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.rtbCheckUsernames);
            this.tabPage3.Controls.Add(this.txtLoadedCheckPackName);
            this.tabPage3.Controls.Add(this.listLoadedCheckers);
            this.tabPage3.Controls.Add(this.btnNameCheckLoadPack);
            this.tabPage3.Controls.Add(this.txtLoadPackPath);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1247, 599);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Search User";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAbortNameCheck
            // 
            this.btnAbortNameCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbortNameCheck.Enabled = false;
            this.btnAbortNameCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbortNameCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbortNameCheck.Location = new System.Drawing.Point(387, 517);
            this.btnAbortNameCheck.Name = "btnAbortNameCheck";
            this.btnAbortNameCheck.Size = new System.Drawing.Size(97, 34);
            this.btnAbortNameCheck.TabIndex = 9;
            this.btnAbortNameCheck.Text = "Abort Check";
            this.btnAbortNameCheck.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(284, 494);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(724, 17);
            this.progressBar1.TabIndex = 8;
            // 
            // btnStartNameCheck
            // 
            this.btnStartNameCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartNameCheck.Enabled = false;
            this.btnStartNameCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartNameCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartNameCheck.Location = new System.Drawing.Point(284, 517);
            this.btnStartNameCheck.Name = "btnStartNameCheck";
            this.btnStartNameCheck.Size = new System.Drawing.Size(97, 34);
            this.btnStartNameCheck.TabIndex = 7;
            this.btnStartNameCheck.Text = "Start Check";
            this.btnStartNameCheck.UseVisualStyleBackColor = true;
            this.btnStartNameCheck.Click += new System.EventHandler(this.btnStartNameCheck_Click);
            // 
            // lwCheckResults
            // 
            this.lwCheckResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwCheckResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lwCheckResults.HideSelection = false;
            this.lwCheckResults.Location = new System.Drawing.Point(284, 102);
            this.lwCheckResults.Name = "lwCheckResults";
            this.lwCheckResults.Size = new System.Drawing.Size(724, 386);
            this.lwCheckResults.TabIndex = 6;
            this.lwCheckResults.UseCompatibleStateImageBehavior = false;
            this.lwCheckResults.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "USERNAME(S)";
            // 
            // rtbCheckUsernames
            // 
            this.rtbCheckUsernames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbCheckUsernames.Location = new System.Drawing.Point(19, 102);
            this.rtbCheckUsernames.Name = "rtbCheckUsernames";
            this.rtbCheckUsernames.Size = new System.Drawing.Size(259, 473);
            this.rtbCheckUsernames.TabIndex = 4;
            this.rtbCheckUsernames.Text = "";
            // 
            // txtLoadedCheckPackName
            // 
            this.txtLoadedCheckPackName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoadedCheckPackName.Location = new System.Drawing.Point(19, 20);
            this.txtLoadedCheckPackName.Name = "txtLoadedCheckPackName";
            this.txtLoadedCheckPackName.placeHolder = "Checker Pack Name";
            this.txtLoadedCheckPackName.Size = new System.Drawing.Size(206, 25);
            this.txtLoadedCheckPackName.TabIndex = 3;
            // 
            // listLoadedCheckers
            // 
            this.listLoadedCheckers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listLoadedCheckers.FormattingEnabled = true;
            this.listLoadedCheckers.Location = new System.Drawing.Point(1014, 51);
            this.listLoadedCheckers.Name = "listLoadedCheckers";
            this.listLoadedCheckers.Size = new System.Drawing.Size(208, 524);
            this.listLoadedCheckers.TabIndex = 2;
            // 
            // btnNameCheckLoadPack
            // 
            this.btnNameCheckLoadPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNameCheckLoadPack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNameCheckLoadPack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNameCheckLoadPack.Location = new System.Drawing.Point(1143, 20);
            this.btnNameCheckLoadPack.Name = "btnNameCheckLoadPack";
            this.btnNameCheckLoadPack.Size = new System.Drawing.Size(79, 25);
            this.btnNameCheckLoadPack.TabIndex = 1;
            this.btnNameCheckLoadPack.Text = "Load Pack";
            this.btnNameCheckLoadPack.UseVisualStyleBackColor = true;
            this.btnNameCheckLoadPack.Click += new System.EventHandler(this.btnNameCheckLoadPack_Click);
            // 
            // txtLoadPackPath
            // 
            this.txtLoadPackPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoadPackPath.Location = new System.Drawing.Point(231, 20);
            this.txtLoadPackPath.Name = "txtLoadPackPath";
            this.txtLoadPackPath.placeHolder = "Checker Pack Path";
            this.txtLoadPackPath.Size = new System.Drawing.Size(906, 25);
            this.txtLoadPackPath.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControl3);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1247, 599);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Create Checker Pack";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 63);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(952, 533);
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage5.Controls.Add(this.btnCreateChecker_URL);
            this.tabPage5.Controls.Add(this.Checkertitle_URL);
            this.tabPage5.Controls.Add(this.UrlTextBox_URL);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(944, 503);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Create URL Checker";
            // 
            // btnCreateChecker_URL
            // 
            this.btnCreateChecker_URL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateChecker_URL.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCreateChecker_URL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateChecker_URL.ForeColor = System.Drawing.Color.Blue;
            this.btnCreateChecker_URL.Location = new System.Drawing.Point(683, 379);
            this.btnCreateChecker_URL.Name = "btnCreateChecker_URL";
            this.btnCreateChecker_URL.Size = new System.Drawing.Size(231, 45);
            this.btnCreateChecker_URL.TabIndex = 10;
            this.btnCreateChecker_URL.Text = "Create/Add URL Checker =>";
            this.btnCreateChecker_URL.UseVisualStyleBackColor = false;
            this.btnCreateChecker_URL.Click += new System.EventHandler(this.btnCreateChecker_URL_Click);
            // 
            // Checkertitle_URL
            // 
            this.Checkertitle_URL.Location = new System.Drawing.Point(31, 55);
            this.Checkertitle_URL.Name = "Checkertitle_URL";
            this.Checkertitle_URL.placeHolder = "Checker Name";
            this.Checkertitle_URL.Size = new System.Drawing.Size(883, 32);
            this.Checkertitle_URL.TabIndex = 7;
            // 
            // UrlTextBox_URL
            // 
            this.UrlTextBox_URL.Location = new System.Drawing.Point(31, 93);
            this.UrlTextBox_URL.Name = "UrlTextBox_URL";
            this.UrlTextBox_URL.placeHolder = "https://example.com/{username}";
            this.UrlTextBox_URL.Size = new System.Drawing.Size(883, 28);
            this.UrlTextBox_URL.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCreateInfoReq_URL);
            this.groupBox1.Controls.Add(this.btn_RemoveInfoReq);
            this.groupBox1.Controls.Add(this.FinderTitle_URL);
            this.groupBox1.Controls.Add(this.address_item1_URL);
            this.groupBox1.Controls.Add(this.listInfoReq_URL);
            this.groupBox1.Controls.Add(this.address_item2_URL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Getby_URL);
            this.groupBox1.Location = new System.Drawing.Point(28, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 229);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Information";
            // 
            // btnCreateInfoReq_URL
            // 
            this.btnCreateInfoReq_URL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateInfoReq_URL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateInfoReq_URL.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCreateInfoReq_URL.Location = new System.Drawing.Point(517, 171);
            this.btnCreateInfoReq_URL.Name = "btnCreateInfoReq_URL";
            this.btnCreateInfoReq_URL.Size = new System.Drawing.Size(169, 34);
            this.btnCreateInfoReq_URL.TabIndex = 10;
            this.btnCreateInfoReq_URL.Text = "Create Info request";
            this.btnCreateInfoReq_URL.UseVisualStyleBackColor = true;
            this.btnCreateInfoReq_URL.Click += new System.EventHandler(this.btnCreateInfoReq_URL_Click);
            // 
            // btn_RemoveInfoReq
            // 
            this.btn_RemoveInfoReq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RemoveInfoReq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RemoveInfoReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_RemoveInfoReq.Location = new System.Drawing.Point(692, 171);
            this.btn_RemoveInfoReq.Name = "btn_RemoveInfoReq";
            this.btn_RemoveInfoReq.Size = new System.Drawing.Size(165, 34);
            this.btn_RemoveInfoReq.TabIndex = 9;
            this.btn_RemoveInfoReq.Text = "Remove Selected";
            this.btn_RemoveInfoReq.UseVisualStyleBackColor = true;
            this.btn_RemoveInfoReq.Click += new System.EventHandler(this.btn_RemoveInfoReq_Click);
            // 
            // FinderTitle_URL
            // 
            this.FinderTitle_URL.Location = new System.Drawing.Point(27, 59);
            this.FinderTitle_URL.Name = "FinderTitle_URL";
            this.FinderTitle_URL.placeHolder = "Info Title";
            this.FinderTitle_URL.Size = new System.Drawing.Size(345, 25);
            this.FinderTitle_URL.TabIndex = 8;
            // 
            // address_item1_URL
            // 
            this.address_item1_URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.address_item1_URL.Location = new System.Drawing.Point(27, 141);
            this.address_item1_URL.Name = "address_item1_URL";
            this.address_item1_URL.placeHolder = "Item1";
            this.address_item1_URL.Size = new System.Drawing.Size(463, 29);
            this.address_item1_URL.TabIndex = 2;
            // 
            // listInfoReq_URL
            // 
            this.listInfoReq_URL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listInfoReq_URL.FormattingEnabled = true;
            this.listInfoReq_URL.ItemHeight = 17;
            this.listInfoReq_URL.Location = new System.Drawing.Point(517, 59);
            this.listInfoReq_URL.Name = "listInfoReq_URL";
            this.listInfoReq_URL.Size = new System.Drawing.Size(340, 106);
            this.listInfoReq_URL.TabIndex = 6;
            this.listInfoReq_URL.DoubleClick += new System.EventHandler(this.listInfoReq_URL_DoubleClick);
            // 
            // address_item2_URL
            // 
            this.address_item2_URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.address_item2_URL.Location = new System.Drawing.Point(27, 176);
            this.address_item2_URL.Name = "address_item2_URL";
            this.address_item2_URL.placeHolder = "Item2";
            this.address_item2_URL.Size = new System.Drawing.Size(463, 29);
            this.address_item2_URL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Get By";
            // 
            // Getby_URL
            // 
            this.Getby_URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Getby_URL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Getby_URL.FormattingEnabled = true;
            this.Getby_URL.Items.AddRange(new object[] {
            "Attribute Value",
            "Class Name",
            "ID",
            "RegEx",
            "XPath"});
            this.Getby_URL.Location = new System.Drawing.Point(27, 110);
            this.Getby_URL.Name = "Getby_URL";
            this.Getby_URL.Size = new System.Drawing.Size(463, 25);
            this.Getby_URL.Sorted = true;
            this.Getby_URL.TabIndex = 4;
            this.Getby_URL.SelectedIndexChanged += new System.EventHandler(this.Getby_URL_SelectedIndexChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage6.Controls.Add(this.btnCreateCheckerAPI);
            this.tabPage6.Controls.Add(this.txtCheckerURL_API);
            this.tabPage6.Controls.Add(this.txtCheckerName_API);
            this.tabPage6.Controls.Add(this.groupBox2);
            this.tabPage6.Location = new System.Drawing.Point(4, 26);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(944, 503);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Create Web API Checker";
            // 
            // btnCreateCheckerAPI
            // 
            this.btnCreateCheckerAPI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateCheckerAPI.ForeColor = System.Drawing.Color.Blue;
            this.btnCreateCheckerAPI.Location = new System.Drawing.Point(724, 446);
            this.btnCreateCheckerAPI.Name = "btnCreateCheckerAPI";
            this.btnCreateCheckerAPI.Size = new System.Drawing.Size(192, 39);
            this.btnCreateCheckerAPI.TabIndex = 13;
            this.btnCreateCheckerAPI.Text = "Create/Add API Checker =>";
            this.btnCreateCheckerAPI.UseVisualStyleBackColor = true;
            this.btnCreateCheckerAPI.Click += new System.EventHandler(this.btnCreateCheckerAPI_Click);
            // 
            // txtCheckerURL_API
            // 
            this.txtCheckerURL_API.Location = new System.Drawing.Point(33, 64);
            this.txtCheckerURL_API.Name = "txtCheckerURL_API";
            this.txtCheckerURL_API.placeHolder = "https://example.com/{username}";
            this.txtCheckerURL_API.Size = new System.Drawing.Size(883, 33);
            this.txtCheckerURL_API.TabIndex = 10;
            // 
            // txtCheckerName_API
            // 
            this.txtCheckerName_API.Location = new System.Drawing.Point(33, 30);
            this.txtCheckerName_API.Name = "txtCheckerName_API";
            this.txtCheckerName_API.placeHolder = "Checker Name";
            this.txtCheckerName_API.Size = new System.Drawing.Size(883, 37);
            this.txtCheckerName_API.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.method_API);
            this.groupBox2.Controls.Add(this.groupAvailableInfo);
            this.groupBox2.Controls.Add(this.txtTestUserName_API);
            this.groupBox2.Controls.Add(this.btnTest_API);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(33, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(883, 337);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Information";
            // 
            // method_API
            // 
            this.method_API.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.method_API.FormattingEnabled = true;
            this.method_API.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.method_API.Location = new System.Drawing.Point(23, 24);
            this.method_API.Name = "method_API";
            this.method_API.Size = new System.Drawing.Size(75, 25);
            this.method_API.TabIndex = 16;
            // 
            // groupAvailableInfo
            // 
            this.groupAvailableInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAvailableInfo.Controls.Add(this.btnRemoveInfoReqAPI);
            this.groupAvailableInfo.Controls.Add(this.btnAddInfoReqAPI);
            this.groupAvailableInfo.Controls.Add(this.listInfoReqAPI);
            this.groupAvailableInfo.Controls.Add(this.txtValNameAPI);
            this.groupAvailableInfo.Controls.Add(this.txtNodePathAPI);
            this.groupAvailableInfo.Controls.Add(this.jsonTree);
            this.groupAvailableInfo.Location = new System.Drawing.Point(17, 55);
            this.groupAvailableInfo.Name = "groupAvailableInfo";
            this.groupAvailableInfo.Size = new System.Drawing.Size(860, 276);
            this.groupAvailableInfo.TabIndex = 15;
            this.groupAvailableInfo.TabStop = false;
            this.groupAvailableInfo.Text = "Available Info";
            // 
            // btnRemoveInfoReqAPI
            // 
            this.btnRemoveInfoReqAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveInfoReqAPI.FlatAppearance.BorderSize = 0;
            this.btnRemoveInfoReqAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveInfoReqAPI.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveInfoReqAPI.Location = new System.Drawing.Point(782, 165);
            this.btnRemoveInfoReqAPI.Name = "btnRemoveInfoReqAPI";
            this.btnRemoveInfoReqAPI.Size = new System.Drawing.Size(33, 25);
            this.btnRemoveInfoReqAPI.TabIndex = 24;
            this.btnRemoveInfoReqAPI.Text = "-";
            this.btnRemoveInfoReqAPI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveInfoReqAPI.UseVisualStyleBackColor = true;
            this.btnRemoveInfoReqAPI.Click += new System.EventHandler(this.btnRemoveInfoReqAPI_Click);
            // 
            // btnAddInfoReqAPI
            // 
            this.btnAddInfoReqAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInfoReqAPI.FlatAppearance.BorderSize = 0;
            this.btnAddInfoReqAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInfoReqAPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddInfoReqAPI.Location = new System.Drawing.Point(821, 165);
            this.btnAddInfoReqAPI.Name = "btnAddInfoReqAPI";
            this.btnAddInfoReqAPI.Size = new System.Drawing.Size(33, 25);
            this.btnAddInfoReqAPI.TabIndex = 23;
            this.btnAddInfoReqAPI.Text = "+";
            this.btnAddInfoReqAPI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddInfoReqAPI.UseVisualStyleBackColor = true;
            this.btnAddInfoReqAPI.Click += new System.EventHandler(this.btnAddInfoReqAPI_Click);
            // 
            // listInfoReqAPI
            // 
            this.listInfoReqAPI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listInfoReqAPI.FormattingEnabled = true;
            this.listInfoReqAPI.ItemHeight = 17;
            this.listInfoReqAPI.Location = new System.Drawing.Point(6, 193);
            this.listInfoReqAPI.Name = "listInfoReqAPI";
            this.listInfoReqAPI.Size = new System.Drawing.Size(848, 72);
            this.listInfoReqAPI.TabIndex = 22;
            // 
            // txtValNameAPI
            // 
            this.txtValNameAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtValNameAPI.Location = new System.Drawing.Point(6, 162);
            this.txtValNameAPI.Name = "txtValNameAPI";
            this.txtValNameAPI.placeHolder = "Value Name";
            this.txtValNameAPI.Size = new System.Drawing.Size(269, 25);
            this.txtValNameAPI.TabIndex = 21;
            // 
            // txtNodePathAPI
            // 
            this.txtNodePathAPI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodePathAPI.Location = new System.Drawing.Point(281, 162);
            this.txtNodePathAPI.Name = "txtNodePathAPI";
            this.txtNodePathAPI.placeHolder = "Value Path";
            this.txtNodePathAPI.Size = new System.Drawing.Size(495, 25);
            this.txtNodePathAPI.TabIndex = 20;
            // 
            // jsonTree
            // 
            this.jsonTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonTree.Location = new System.Drawing.Point(6, 24);
            this.jsonTree.Name = "jsonTree";
            this.jsonTree.Size = new System.Drawing.Size(848, 135);
            this.jsonTree.TabIndex = 17;
            this.jsonTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.jsonTree_AfterSelect);
            // 
            // txtTestUserName_API
            // 
            this.txtTestUserName_API.Location = new System.Drawing.Point(104, 24);
            this.txtTestUserName_API.Name = "txtTestUserName_API";
            this.txtTestUserName_API.placeHolder = "Test Username (Enter an username that already exists)";
            this.txtTestUserName_API.Size = new System.Drawing.Size(317, 25);
            this.txtTestUserName_API.TabIndex = 11;
            // 
            // btnTest_API
            // 
            this.btnTest_API.Location = new System.Drawing.Point(427, 24);
            this.btnTest_API.Name = "btnTest_API";
            this.btnTest_API.Size = new System.Drawing.Size(75, 25);
            this.btnTest_API.TabIndex = 10;
            this.btnTest_API.Text = "Test API";
            this.btnTest_API.UseVisualStyleBackColor = true;
            this.btnTest_API.Click += new System.EventHandler(this.btnTest_API_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(1375, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Remove Selected";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listNewCheckers);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(955, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 533);
            this.panel1.TabIndex = 1;
            // 
            // listNewCheckers
            // 
            this.listNewCheckers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listNewCheckers.FormattingEnabled = true;
            this.listNewCheckers.ItemHeight = 17;
            this.listNewCheckers.Location = new System.Drawing.Point(0, 17);
            this.listNewCheckers.Name = "listNewCheckers";
            this.listNewCheckers.Size = new System.Drawing.Size(289, 466);
            this.listNewCheckers.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.removeNewChecker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 483);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 50);
            this.panel2.TabIndex = 2;
            // 
            // removeNewChecker
            // 
            this.removeNewChecker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeNewChecker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeNewChecker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeNewChecker.Location = new System.Drawing.Point(0, 0);
            this.removeNewChecker.Name = "removeNewChecker";
            this.removeNewChecker.Size = new System.Drawing.Size(289, 50);
            this.removeNewChecker.TabIndex = 0;
            this.removeNewChecker.Text = "Remove Selected";
            this.removeNewChecker.UseVisualStyleBackColor = true;
            this.removeNewChecker.Click += new System.EventHandler(this.removeNewChecker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Checkers";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCreatePack);
            this.panel3.Controls.Add(this.txtNewPackName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1241, 60);
            this.panel3.TabIndex = 4;
            // 
            // btnCreatePack
            // 
            this.btnCreatePack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreatePack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreatePack.ForeColor = System.Drawing.Color.White;
            this.btnCreatePack.Location = new System.Drawing.Point(1099, 14);
            this.btnCreatePack.Name = "btnCreatePack";
            this.btnCreatePack.Size = new System.Drawing.Size(125, 33);
            this.btnCreatePack.TabIndex = 4;
            this.btnCreatePack.Text = "Create Pack";
            this.btnCreatePack.UseVisualStyleBackColor = false;
            this.btnCreatePack.Click += new System.EventHandler(this.btnCreatePack_Click);
            // 
            // txtNewPackName
            // 
            this.txtNewPackName.Location = new System.Drawing.Point(18, 17);
            this.txtNewPackName.Name = "txtNewPackName";
            this.txtNewPackName.placeHolder = "Pack Name";
            this.txtNewPackName.Size = new System.Drawing.Size(1063, 27);
            this.txtNewPackName.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1261, 638);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TabIcons
            // 
            this.TabIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.TabIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TabIcons.ImageStream")));
            this.TabIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.TabIcons.Images.SetKeyName(0, "profilePic.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1269, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 693);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Chug Tools GUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupAvailableInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listNewCheckers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button removeNewChecker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList TabIcons;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox Getby_URL;
        private UserControls.PlaceholderTextBox address_item2_URL;
        private UserControls.PlaceholderTextBox address_item1_URL;
        private UserControls.PlaceholderTextBox UrlTextBox_URL;
        private System.Windows.Forms.Label label2;
        private UserControls.PlaceholderTextBox Checkertitle_URL;
        private System.Windows.Forms.ListBox listInfoReq_URL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateInfoReq_URL;
        private System.Windows.Forms.Button btn_RemoveInfoReq;
        private UserControls.PlaceholderTextBox FinderTitle_URL;
        private System.Windows.Forms.Button btnCreateChecker_URL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCreatePack;
        private UserControls.PlaceholderTextBox txtNewPackName;
        private System.Windows.Forms.Button btnNameCheckLoadPack;
        private UserControls.PlaceholderTextBox txtLoadPackPath;
        private UserControls.PlaceholderTextBox txtLoadedCheckPackName;
        private System.Windows.Forms.CheckedListBox listLoadedCheckers;
        private System.Windows.Forms.Button btnStartNameCheck;
        private System.Windows.Forms.ListView lwCheckResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbCheckUsernames;
        private System.Windows.Forms.TabPage tabPage6;
        private UserControls.PlaceholderTextBox txtCheckerName_API;
        private UserControls.PlaceholderTextBox txtCheckerURL_API;
        private System.Windows.Forms.GroupBox groupBox2;
        private UserControls.PlaceholderTextBox txtTestUserName_API;
        private System.Windows.Forms.Button btnTest_API;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox method_API;
        private System.Windows.Forms.GroupBox groupAvailableInfo;
        private System.Windows.Forms.TreeView jsonTree;
        private System.Windows.Forms.Button btnRemoveInfoReqAPI;
        private System.Windows.Forms.Button btnAddInfoReqAPI;
        private System.Windows.Forms.ListBox listInfoReqAPI;
        private UserControls.PlaceholderTextBox txtValNameAPI;
        private UserControls.PlaceholderTextBox txtNodePathAPI;
        private System.Windows.Forms.Button btnCreateCheckerAPI;
        private System.Windows.Forms.Button btnAbortNameCheck;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

