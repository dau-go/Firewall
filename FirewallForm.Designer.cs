namespace WinformsExample
{
    partial class FirewallForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirewallForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Inbound Rules");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Outbound Rules");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Rules Created By The User", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Inbound Rules");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Outbound Rules");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("The Default Rule Of The Windows", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Website Blocking Rules");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Website Tracking");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Website Management", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Introduce = new System.Windows.Forms.ToolStripMenuItem();
            this.FileUser = new System.Windows.Forms.ToolStripMenuItem();
            this.FileInboundUser = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOutboundUser = new System.Windows.Forms.ToolStripMenuItem();
            this.FileDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.FileInboundDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOutboundDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.FileWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Filterprofile = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAllProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Domain = new System.Windows.Forms.ToolStripMenuItem();
            this.Private = new System.Windows.Forms.ToolStripMenuItem();
            this.Public = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterState = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAllState = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Enable = new System.Windows.Forms.ToolStripMenuItem();
            this.Disabled = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterAction = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAllAction = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Allow = new System.Windows.Forms.ToolStripMenuItem();
            this.Block = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Language = new System.Windows.Forms.ToolStripMenuItem();
            this.Tiengviet = new System.Windows.Forms.ToolStripMenuItem();
            this.English = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuComputer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fireToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fireToolStripMenuItem
            // 
            this.fireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Introduce,
            this.FileUser,
            this.FileDefault,
            this.FileWeb,
            this.toolStripSeparator6,
            this.Exit});
            this.fireToolStripMenuItem.Name = "fireToolStripMenuItem";
            this.fireToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fireToolStripMenuItem.Text = "File";
            // 
            // Introduce
            // 
            this.Introduce.Name = "Introduce";
            this.Introduce.Size = new System.Drawing.Size(252, 22);
            this.Introduce.Text = "Introduce";
            this.Introduce.Click += new System.EventHandler(this.Introduce_Click);
            // 
            // FileUser
            // 
            this.FileUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileInboundUser,
            this.FileOutboundUser});
            this.FileUser.Name = "FileUser";
            this.FileUser.Size = new System.Drawing.Size(252, 22);
            this.FileUser.Text = "Rule Created By The User";
            // 
            // FileInboundUser
            // 
            this.FileInboundUser.Name = "FileInboundUser";
            this.FileInboundUser.Size = new System.Drawing.Size(160, 22);
            this.FileInboundUser.Text = "Inbound Rules";
            this.FileInboundUser.Click += new System.EventHandler(this.FileInboundUser_Click);
            // 
            // FileOutboundUser
            // 
            this.FileOutboundUser.Name = "FileOutboundUser";
            this.FileOutboundUser.Size = new System.Drawing.Size(160, 22);
            this.FileOutboundUser.Text = "OutBound Rules";
            this.FileOutboundUser.Click += new System.EventHandler(this.FileOutboundUser_Click);
            // 
            // FileDefault
            // 
            this.FileDefault.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileInboundDefault,
            this.FileOutboundDefault});
            this.FileDefault.Name = "FileDefault";
            this.FileDefault.Size = new System.Drawing.Size(252, 22);
            this.FileDefault.Text = "The Default Rule Of The Windows";
            // 
            // FileInboundDefault
            // 
            this.FileInboundDefault.Name = "FileInboundDefault";
            this.FileInboundDefault.Size = new System.Drawing.Size(160, 22);
            this.FileInboundDefault.Text = "Inbound Rules";
            this.FileInboundDefault.Click += new System.EventHandler(this.FileInboundDefault_Click);
            // 
            // FileOutboundDefault
            // 
            this.FileOutboundDefault.Name = "FileOutboundDefault";
            this.FileOutboundDefault.Size = new System.Drawing.Size(160, 22);
            this.FileOutboundDefault.Text = "Outbound Rules";
            this.FileOutboundDefault.Click += new System.EventHandler(this.FileOutboundDefault_Click);
            // 
            // FileWeb
            // 
            this.FileWeb.Name = "FileWeb";
            this.FileWeb.Size = new System.Drawing.Size(252, 22);
            this.FileWeb.Text = "Website Blocking Rules";
            this.FileWeb.Click += new System.EventHandler(this.FileWeb_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(249, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(252, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Filterprofile,
            this.FilterState,
            this.FilterAction,
            this.Clear});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolToolStripMenuItem.Text = "Tools";
            // 
            // Filterprofile
            // 
            this.Filterprofile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowAllProfile,
            this.toolStripSeparator3,
            this.Domain,
            this.Private,
            this.Public});
            this.Filterprofile.Image = global::WinformsExample.Properties.Resources.icons8_filter_filled_50__1_;
            this.Filterprofile.Name = "Filterprofile";
            this.Filterprofile.Size = new System.Drawing.Size(154, 22);
            this.Filterprofile.Text = "Filter By Profile";
            // 
            // ShowAllProfile
            // 
            this.ShowAllProfile.Checked = true;
            this.ShowAllProfile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowAllProfile.Name = "ShowAllProfile";
            this.ShowAllProfile.Size = new System.Drawing.Size(198, 22);
            this.ShowAllProfile.Text = "Show All";
            this.ShowAllProfile.Click += new System.EventHandler(this.ShowAllProfile_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
            // 
            // Domain
            // 
            this.Domain.Name = "Domain";
            this.Domain.Size = new System.Drawing.Size(198, 22);
            this.Domain.Text = "Filter By Domain Profile";
            this.Domain.Click += new System.EventHandler(this.Domian_Click);
            // 
            // Private
            // 
            this.Private.Name = "Private";
            this.Private.Size = new System.Drawing.Size(198, 22);
            this.Private.Text = "Filter By Private Profile";
            this.Private.Click += new System.EventHandler(this.Private_Click);
            // 
            // Public
            // 
            this.Public.Name = "Public";
            this.Public.Size = new System.Drawing.Size(198, 22);
            this.Public.Text = "Filter By Public Profile";
            this.Public.Click += new System.EventHandler(this.Public_Click);
            // 
            // FilterState
            // 
            this.FilterState.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowAllState,
            this.toolStripSeparator4,
            this.Enable,
            this.Disabled});
            this.FilterState.Image = ((System.Drawing.Image)(resources.GetObject("FilterState.Image")));
            this.FilterState.Name = "FilterState";
            this.FilterState.Size = new System.Drawing.Size(154, 22);
            this.FilterState.Text = "Filter By State";
            // 
            // ShowAllState
            // 
            this.ShowAllState.Checked = true;
            this.ShowAllState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowAllState.Name = "ShowAllState";
            this.ShowAllState.Size = new System.Drawing.Size(164, 22);
            this.ShowAllState.Text = "Show All";
            this.ShowAllState.Click += new System.EventHandler(this.ShowAllState_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // Enable
            // 
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(164, 22);
            this.Enable.Text = "Filter By Enabled";
            this.Enable.Click += new System.EventHandler(this.Enabled_Click);
            // 
            // Disabled
            // 
            this.Disabled.Name = "Disabled";
            this.Disabled.Size = new System.Drawing.Size(164, 22);
            this.Disabled.Text = "Filter By Disabled";
            this.Disabled.Click += new System.EventHandler(this.Disabled_Click);
            // 
            // FilterAction
            // 
            this.FilterAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowAllAction,
            this.toolStripSeparator5,
            this.Allow,
            this.Block});
            this.FilterAction.Image = ((System.Drawing.Image)(resources.GetObject("FilterAction.Image")));
            this.FilterAction.Name = "FilterAction";
            this.FilterAction.Size = new System.Drawing.Size(154, 22);
            this.FilterAction.Text = "Filter By Action";
            // 
            // ShowAllAction
            // 
            this.ShowAllAction.Checked = true;
            this.ShowAllAction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowAllAction.Name = "ShowAllAction";
            this.ShowAllAction.Size = new System.Drawing.Size(149, 22);
            this.ShowAllAction.Text = "Show All";
            this.ShowAllAction.Click += new System.EventHandler(this.ShowAllAction_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(146, 6);
            // 
            // Allow
            // 
            this.Allow.Name = "Allow";
            this.Allow.Size = new System.Drawing.Size(149, 22);
            this.Allow.Text = "Filter By Allow";
            this.Allow.Click += new System.EventHandler(this.Allow_Click);
            // 
            // Block
            // 
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(149, 22);
            this.Block.Text = "Filter By Block";
            this.Block.Click += new System.EventHandler(this.Block_Click);
            // 
            // Clear
            // 
            this.Clear.Image = global::WinformsExample.Properties.Resources.icons8_clear_filters_26;
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(154, 22);
            this.Clear.Text = "Clear All Filter";
            this.Clear.Visible = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Language});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // Language
            // 
            this.Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tiengviet,
            this.English});
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(152, 22);
            this.Language.Text = "Language";
            // 
            // Tiengviet
            // 
            this.Tiengviet.Name = "Tiengviet";
            this.Tiengviet.Size = new System.Drawing.Size(127, 22);
            this.Tiengviet.Text = "Tiếng Việt";
            this.Tiengviet.Click += new System.EventHandler(this.Tiengviet_Click);
            // 
            // English
            // 
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(127, 22);
            this.English.Text = "English";
            this.English.Click += new System.EventHandler(this.English_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.btnTree);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 41);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImage = global::WinformsExample.Properties.Resources.icons8_trash_24__1_;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDel.Enabled = false;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDel.Location = new System.Drawing.Point(128, 16);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(25, 22);
            this.btnDel.TabIndex = 6;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::WinformsExample.Properties.Resources.icons8_plus_24;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(103, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 22);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImage = global::WinformsExample.Properties.Resources.icons8_refresh_32__1_;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReload.Enabled = false;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReload.Location = new System.Drawing.Point(78, 16);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(25, 22);
            this.btnReload.TabIndex = 4;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnTree
            // 
            this.btnTree.BackgroundImage = global::WinformsExample.Properties.Resources.icons8_file_preview_50;
            this.btnTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTree.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTree.Location = new System.Drawing.Point(53, 16);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(25, 22);
            this.btnTree.TabIndex = 3;
            this.btnTree.UseVisualStyleBackColor = true;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::WinformsExample.Properties.Resources.icons8_right_26__1_;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(28, 16);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 22);
            this.btnNext.TabIndex = 2;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleDescription = "Navigate Backward";
            this.btnBack.AccessibleName = "";
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.BackgroundImage = global::WinformsExample.Properties.Resources.icons8_left_26;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Enabled = false;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(3, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 22);
            this.btnBack.TabIndex = 2;
            this.btnBack.Tag = "";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 393);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(212, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 374);
            this.tabControl1.TabIndex = 1;
            // 
            // tab
            // 
            this.tab.Location = new System.Drawing.Point(4, 22);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Windows.Forms.Padding(3);
            this.tab.Size = new System.Drawing.Size(637, 348);
            this.tab.TabIndex = 0;
            this.tab.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(3, 16);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "InboundUser";
            treeNode1.Text = "Inbound Rules";
            treeNode2.Name = "OutboundUser";
            treeNode2.Text = "Outbound Rules";
            treeNode3.Name = "User";
            treeNode3.Text = "Rules Created By The User";
            treeNode4.Name = "InboundDefault";
            treeNode4.Text = "Inbound Rules";
            treeNode5.Name = "OutboundDefault";
            treeNode5.Text = "Outbound Rules";
            treeNode6.Name = "Default";
            treeNode6.Text = "The Default Rule Of The Windows";
            treeNode7.Name = "BlockingWeb";
            treeNode7.Text = "Website Blocking Rules";
            treeNode8.Name = "WebsiteTracking";
            treeNode8.Text = "Website Tracking";
            treeNode9.Name = "Web";
            treeNode9.Text = "Website Management";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(209, 374);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuRefresh,
            this.toolStripSeparator1,
            this.menuComputer});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(202, 22);
            this.menuAdd.Text = "Add Rules";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.Size = new System.Drawing.Size(202, 22);
            this.menuRefresh.Text = "Refresh";
            this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // menuComputer
            // 
            this.menuComputer.Name = "menuComputer";
            this.menuComputer.Size = new System.Drawing.Size(202, 22);
            this.menuComputer.Text = "Computer Management";
            this.menuComputer.Click += new System.EventHandler(this.menuComputer_Click);
            // 
            // FirewallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FirewallForm";
            this.Text = "Firewall";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirewallForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tab;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Filterprofile;
        private System.Windows.Forms.ToolStripMenuItem ShowAllProfile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Domain;
        private System.Windows.Forms.ToolStripMenuItem Private;
        private System.Windows.Forms.ToolStripMenuItem Public;
        private System.Windows.Forms.ToolStripMenuItem FilterState;
        private System.Windows.Forms.ToolStripMenuItem ShowAllState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem Enable;
        private System.Windows.Forms.ToolStripMenuItem Disabled;
        private System.Windows.Forms.ToolStripMenuItem FilterAction;
        private System.Windows.Forms.ToolStripMenuItem ShowAllAction;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem Allow;
        private System.Windows.Forms.ToolStripMenuItem Block;
        private System.Windows.Forms.ToolStripMenuItem Language;
        private System.Windows.Forms.ToolStripMenuItem Tiengviet;
        private System.Windows.Forms.ToolStripMenuItem English;
        private System.Windows.Forms.ToolStripMenuItem Clear;
        private System.Windows.Forms.ToolStripMenuItem FileUser;
        private System.Windows.Forms.ToolStripMenuItem FileDefault;
        private System.Windows.Forms.ToolStripMenuItem FileWeb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem FileInboundUser;
        private System.Windows.Forms.ToolStripMenuItem FileOutboundUser;
        private System.Windows.Forms.ToolStripMenuItem FileInboundDefault;
        private System.Windows.Forms.ToolStripMenuItem FileOutboundDefault;
        private System.Windows.Forms.ToolStripMenuItem Introduce;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuComputer;
    }
}