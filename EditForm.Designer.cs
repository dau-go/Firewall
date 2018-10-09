namespace WinformsExample
{
    partial class EditForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBlock = new System.Windows.Forms.RadioButton();
            this.rbAllow = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckState = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBrowes = new System.Windows.Forms.Button();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.rbThisProgram = new System.Windows.Forms.RadioButton();
            this.rbAllProgram = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPublic = new System.Windows.Forms.CheckBox();
            this.cbPrivate = new System.Windows.Forms.CheckBox();
            this.cbDomain = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtRemoteport = new System.Windows.Forms.TextBox();
            this.txtLocalport = new System.Windows.Forms.TextBox();
            this.cbRemoteport = new System.Windows.Forms.ComboBox();
            this.cbLocalport = new System.Windows.Forms.ComboBox();
            this.cbProtocol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbAllLocal = new System.Windows.Forms.RadioButton();
            this.rbIPLocal = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnAddLocal = new System.Windows.Forms.Button();
            this.btnEditLocal = new System.Windows.Forms.Button();
            this.btnDelLocal = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnDelRemote = new System.Windows.Forms.Button();
            this.btnEditRemote = new System.Windows.Forms.Button();
            this.btnAddRemote = new System.Windows.Forms.Button();
            this.rbIPRemote = new System.Windows.Forms.RadioButton();
            this.rbAllRemote = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbMinuteTo = new System.Windows.Forms.ComboBox();
            this.cbHourTo = new System.Windows.Forms.ComboBox();
            this.cbMinuteFrom = new System.Windows.Forms.ComboBox();
            this.cbHourFrom = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 443);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBlock);
            this.groupBox2.Controls.Add(this.rbAllow);
            this.groupBox2.Location = new System.Drawing.Point(3, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // rbBlock
            // 
            this.rbBlock.AutoSize = true;
            this.rbBlock.Location = new System.Drawing.Point(62, 42);
            this.rbBlock.Name = "rbBlock";
            this.rbBlock.Size = new System.Drawing.Size(126, 17);
            this.rbBlock.TabIndex = 8;
            this.rbBlock.Text = "Block the connection";
            this.rbBlock.UseVisualStyleBackColor = true;
            // 
            // rbAllow
            // 
            this.rbAllow.AutoSize = true;
            this.rbAllow.Checked = true;
            this.rbAllow.Location = new System.Drawing.Point(62, 19);
            this.rbAllow.Name = "rbAllow";
            this.rbAllow.Size = new System.Drawing.Size(124, 17);
            this.rbAllow.TabIndex = 9;
            this.rbAllow.TabStop = true;
            this.rbAllow.Text = "Allow the connection";
            this.rbAllow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckState);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // ckState
            // 
            this.ckState.AutoSize = true;
            this.ckState.Checked = true;
            this.ckState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckState.Location = new System.Drawing.Point(62, 163);
            this.ckState.Name = "ckState";
            this.ckState.Size = new System.Drawing.Size(65, 17);
            this.ckState.TabIndex = 8;
            this.ckState.Text = "Enabled";
            this.ckState.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(62, 84);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(267, 73);
            this.txtDescription.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(267, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Program and Profile";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBrowes);
            this.groupBox3.Controls.Add(this.txtProgram);
            this.groupBox3.Controls.Add(this.rbThisProgram);
            this.groupBox3.Controls.Add(this.rbAllProgram);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 185);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Program";
            // 
            // btnBrowes
            // 
            this.btnBrowes.Location = new System.Drawing.Point(329, 74);
            this.btnBrowes.Name = "btnBrowes";
            this.btnBrowes.Size = new System.Drawing.Size(75, 23);
            this.btnBrowes.TabIndex = 15;
            this.btnBrowes.Text = "Browse...";
            this.btnBrowes.UseVisualStyleBackColor = true;
            this.btnBrowes.Click += new System.EventHandler(this.btnBrowes_Click);
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(59, 76);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(264, 20);
            this.txtProgram.TabIndex = 14;
            // 
            // rbThisProgram
            // 
            this.rbThisProgram.AutoSize = true;
            this.rbThisProgram.Checked = true;
            this.rbThisProgram.Location = new System.Drawing.Point(59, 53);
            this.rbThisProgram.Name = "rbThisProgram";
            this.rbThisProgram.Size = new System.Drawing.Size(113, 17);
            this.rbThisProgram.TabIndex = 12;
            this.rbThisProgram.TabStop = true;
            this.rbThisProgram.Text = "This program path:\r\n";
            this.rbThisProgram.UseVisualStyleBackColor = true;
            this.rbThisProgram.CheckedChanged += new System.EventHandler(this.rbThisProgram_CheckedChanged);
            // 
            // rbAllProgram
            // 
            this.rbAllProgram.AutoSize = true;
            this.rbAllProgram.Location = new System.Drawing.Point(59, 30);
            this.rbAllProgram.Name = "rbAllProgram";
            this.rbAllProgram.Size = new System.Drawing.Size(238, 17);
            this.rbAllProgram.TabIndex = 13;
            this.rbAllProgram.TabStop = true;
            this.rbAllProgram.Text = "All program that meet the specified conditions";
            this.rbAllProgram.UseVisualStyleBackColor = true;
            this.rbAllProgram.CheckedChanged += new System.EventHandler(this.rbAllProgram_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cbPublic);
            this.groupBox4.Controls.Add(this.cbPrivate);
            this.groupBox4.Controls.Add(this.cbDomain);
            this.groupBox4.Location = new System.Drawing.Point(3, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(431, 217);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Specified profiles to which this rule applies";
            // 
            // cbPublic
            // 
            this.cbPublic.AutoSize = true;
            this.cbPublic.Checked = true;
            this.cbPublic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPublic.Location = new System.Drawing.Point(59, 109);
            this.cbPublic.Name = "cbPublic";
            this.cbPublic.Size = new System.Drawing.Size(55, 17);
            this.cbPublic.TabIndex = 2;
            this.cbPublic.Text = "Public";
            this.cbPublic.UseVisualStyleBackColor = true;
            // 
            // cbPrivate
            // 
            this.cbPrivate.AutoSize = true;
            this.cbPrivate.Checked = true;
            this.cbPrivate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrivate.Location = new System.Drawing.Point(59, 86);
            this.cbPrivate.Name = "cbPrivate";
            this.cbPrivate.Size = new System.Drawing.Size(59, 17);
            this.cbPrivate.TabIndex = 3;
            this.cbPrivate.Text = "Private";
            this.cbPrivate.UseVisualStyleBackColor = true;
            // 
            // cbDomain
            // 
            this.cbDomain.AutoSize = true;
            this.cbDomain.Checked = true;
            this.cbDomain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDomain.Location = new System.Drawing.Point(59, 63);
            this.cbDomain.Name = "cbDomain";
            this.cbDomain.Size = new System.Drawing.Size(62, 17);
            this.cbDomain.TabIndex = 4;
            this.cbDomain.Text = "Domain";
            this.cbDomain.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(441, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Protocol and Ports";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtRemoteport);
            this.groupBox7.Controls.Add(this.txtLocalport);
            this.groupBox7.Controls.Add(this.cbRemoteport);
            this.groupBox7.Controls.Add(this.cbLocalport);
            this.groupBox7.Controls.Add(this.cbProtocol);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(431, 408);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Protocol and ports";
            // 
            // txtRemoteport
            // 
            this.txtRemoteport.Enabled = false;
            this.txtRemoteport.Location = new System.Drawing.Point(201, 222);
            this.txtRemoteport.Name = "txtRemoteport";
            this.txtRemoteport.Size = new System.Drawing.Size(121, 20);
            this.txtRemoteport.TabIndex = 11;
            // 
            // txtLocalport
            // 
            this.txtLocalport.Enabled = false;
            this.txtLocalport.Location = new System.Drawing.Point(201, 134);
            this.txtLocalport.Name = "txtLocalport";
            this.txtLocalport.Size = new System.Drawing.Size(121, 20);
            this.txtLocalport.TabIndex = 12;
            // 
            // cbRemoteport
            // 
            this.cbRemoteport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemoteport.Enabled = false;
            this.cbRemoteport.FormattingEnabled = true;
            this.cbRemoteport.Items.AddRange(new object[] {
            "All Ports",
            "Specific Ports"});
            this.cbRemoteport.Location = new System.Drawing.Point(201, 195);
            this.cbRemoteport.Name = "cbRemoteport";
            this.cbRemoteport.Size = new System.Drawing.Size(121, 21);
            this.cbRemoteport.TabIndex = 8;
            this.cbRemoteport.SelectedIndexChanged += new System.EventHandler(this.cbRemoteport_SelectedIndexChanged);
            // 
            // cbLocalport
            // 
            this.cbLocalport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalport.Enabled = false;
            this.cbLocalport.FormattingEnabled = true;
            this.cbLocalport.Items.AddRange(new object[] {
            "All Ports",
            "Specific Ports"});
            this.cbLocalport.Location = new System.Drawing.Point(201, 108);
            this.cbLocalport.Name = "cbLocalport";
            this.cbLocalport.Size = new System.Drawing.Size(121, 21);
            this.cbLocalport.TabIndex = 9;
            this.cbLocalport.SelectedIndexChanged += new System.EventHandler(this.cbLocalport_SelectedIndexChanged);
            // 
            // cbProtocol
            // 
            this.cbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProtocol.FormattingEnabled = true;
            this.cbProtocol.Items.AddRange(new object[] {
            "Any",
            "HOPOPT",
            "ICMPv4",
            "IGMP",
            "TCP",
            "UDP",
            "IPv6",
            "IPv6-Route",
            "IPv6-Frag",
            "GRE",
            "ICMPv6",
            "IPv6-NoNxt",
            "IPv6-Opts",
            "VRRP",
            "PGM",
            "L2TP"});
            this.cbProtocol.Location = new System.Drawing.Point(201, 55);
            this.cbProtocol.Name = "cbProtocol";
            this.cbProtocol.Size = new System.Drawing.Size(121, 21);
            this.cbProtocol.TabIndex = 10;
            this.cbProtocol.SelectedIndexChanged += new System.EventHandler(this.cbProtocol_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Example: 80,443,...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Example: 80,443,...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Local port:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Remote port:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Protocol type:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(441, 417);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Scope";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbAllLocal);
            this.groupBox6.Controls.Add(this.rbIPLocal);
            this.groupBox6.Controls.Add(this.listView1);
            this.groupBox6.Controls.Add(this.btnAddLocal);
            this.groupBox6.Controls.Add(this.btnEditLocal);
            this.groupBox6.Controls.Add(this.btnDelLocal);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(431, 188);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Local IP";
            // 
            // rbAllLocal
            // 
            this.rbAllLocal.AutoSize = true;
            this.rbAllLocal.Checked = true;
            this.rbAllLocal.Location = new System.Drawing.Point(57, 19);
            this.rbAllLocal.Name = "rbAllLocal";
            this.rbAllLocal.Size = new System.Drawing.Size(96, 17);
            this.rbAllLocal.TabIndex = 7;
            this.rbAllLocal.TabStop = true;
            this.rbAllLocal.Text = "Any IP address";
            this.rbAllLocal.UseVisualStyleBackColor = true;
            this.rbAllLocal.CheckedChanged += new System.EventHandler(this.rbAllLocal_CheckedChanged);
            // 
            // rbIPLocal
            // 
            this.rbIPLocal.AutoSize = true;
            this.rbIPLocal.Location = new System.Drawing.Point(57, 42);
            this.rbIPLocal.Name = "rbIPLocal";
            this.rbIPLocal.Size = new System.Drawing.Size(111, 17);
            this.rbIPLocal.TabIndex = 8;
            this.rbIPLocal.Text = "These IP address:";
            this.rbIPLocal.UseVisualStyleBackColor = true;
            this.rbIPLocal.CheckedChanged += new System.EventHandler(this.rbIPLocal_Click);
            this.rbIPLocal.Click += new System.EventHandler(this.rbIPLocal_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Location = new System.Drawing.Point(57, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(248, 81);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnAddLocal
            // 
            this.btnAddLocal.Enabled = false;
            this.btnAddLocal.Location = new System.Drawing.Point(328, 61);
            this.btnAddLocal.Name = "btnAddLocal";
            this.btnAddLocal.Size = new System.Drawing.Size(75, 23);
            this.btnAddLocal.TabIndex = 9;
            this.btnAddLocal.Text = "Add...";
            this.btnAddLocal.UseVisualStyleBackColor = true;
            this.btnAddLocal.Click += new System.EventHandler(this.btnAddLocal_Click);
            // 
            // btnEditLocal
            // 
            this.btnEditLocal.Enabled = false;
            this.btnEditLocal.Location = new System.Drawing.Point(328, 90);
            this.btnEditLocal.Name = "btnEditLocal";
            this.btnEditLocal.Size = new System.Drawing.Size(75, 23);
            this.btnEditLocal.TabIndex = 10;
            this.btnEditLocal.Text = "Edit...";
            this.btnEditLocal.UseVisualStyleBackColor = true;
            this.btnEditLocal.Click += new System.EventHandler(this.btnEditLocal_Click);
            // 
            // btnDelLocal
            // 
            this.btnDelLocal.Enabled = false;
            this.btnDelLocal.Location = new System.Drawing.Point(328, 119);
            this.btnDelLocal.Name = "btnDelLocal";
            this.btnDelLocal.Size = new System.Drawing.Size(75, 23);
            this.btnDelLocal.TabIndex = 11;
            this.btnDelLocal.Text = "Remove";
            this.btnDelLocal.UseVisualStyleBackColor = true;
            this.btnDelLocal.Click += new System.EventHandler(this.btnDelLocal_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listView2);
            this.groupBox5.Controls.Add(this.btnDelRemote);
            this.groupBox5.Controls.Add(this.btnEditRemote);
            this.groupBox5.Controls.Add(this.btnAddRemote);
            this.groupBox5.Controls.Add(this.rbIPRemote);
            this.groupBox5.Controls.Add(this.rbAllRemote);
            this.groupBox5.Location = new System.Drawing.Point(3, 197);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(431, 214);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Remote IP";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(59, 61);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(246, 81);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // btnDelRemote
            // 
            this.btnDelRemote.Enabled = false;
            this.btnDelRemote.Location = new System.Drawing.Point(328, 119);
            this.btnDelRemote.Name = "btnDelRemote";
            this.btnDelRemote.Size = new System.Drawing.Size(75, 23);
            this.btnDelRemote.TabIndex = 10;
            this.btnDelRemote.Text = "Remove";
            this.btnDelRemote.UseVisualStyleBackColor = true;
            this.btnDelRemote.Click += new System.EventHandler(this.btnDelRemote_Click);
            // 
            // btnEditRemote
            // 
            this.btnEditRemote.Enabled = false;
            this.btnEditRemote.Location = new System.Drawing.Point(328, 90);
            this.btnEditRemote.Name = "btnEditRemote";
            this.btnEditRemote.Size = new System.Drawing.Size(75, 23);
            this.btnEditRemote.TabIndex = 11;
            this.btnEditRemote.Text = "Edit...";
            this.btnEditRemote.UseVisualStyleBackColor = true;
            this.btnEditRemote.Click += new System.EventHandler(this.btnEditRemote_Click);
            // 
            // btnAddRemote
            // 
            this.btnAddRemote.Enabled = false;
            this.btnAddRemote.Location = new System.Drawing.Point(328, 61);
            this.btnAddRemote.Name = "btnAddRemote";
            this.btnAddRemote.Size = new System.Drawing.Size(75, 23);
            this.btnAddRemote.TabIndex = 12;
            this.btnAddRemote.Text = "Add...";
            this.btnAddRemote.UseVisualStyleBackColor = true;
            this.btnAddRemote.Click += new System.EventHandler(this.btnAddRemote_Click);
            // 
            // rbIPRemote
            // 
            this.rbIPRemote.AutoSize = true;
            this.rbIPRemote.Location = new System.Drawing.Point(59, 42);
            this.rbIPRemote.Name = "rbIPRemote";
            this.rbIPRemote.Size = new System.Drawing.Size(111, 17);
            this.rbIPRemote.TabIndex = 8;
            this.rbIPRemote.Text = "These IP address:";
            this.rbIPRemote.UseVisualStyleBackColor = true;
            this.rbIPRemote.CheckedChanged += new System.EventHandler(this.rbIPRemote_Click);
            this.rbIPRemote.Click += new System.EventHandler(this.rbIPRemote_Click);
            // 
            // rbAllRemote
            // 
            this.rbAllRemote.AutoSize = true;
            this.rbAllRemote.Checked = true;
            this.rbAllRemote.Location = new System.Drawing.Point(59, 19);
            this.rbAllRemote.Name = "rbAllRemote";
            this.rbAllRemote.Size = new System.Drawing.Size(96, 17);
            this.rbAllRemote.TabIndex = 9;
            this.rbAllRemote.TabStop = true;
            this.rbAllRemote.Text = "Any IP address";
            this.rbAllRemote.UseVisualStyleBackColor = true;
            this.rbAllRemote.CheckedChanged += new System.EventHandler(this.rbAllRemote_CheckedChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.groupBox8);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(441, 417);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Time";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbMinuteTo);
            this.groupBox8.Controls.Add(this.cbHourTo);
            this.groupBox8.Controls.Add(this.cbMinuteFrom);
            this.groupBox8.Controls.Add(this.cbHourFrom);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(431, 408);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Time";
            // 
            // cbMinuteTo
            // 
            this.cbMinuteTo.DropDownHeight = 80;
            this.cbMinuteTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinuteTo.FormattingEnabled = true;
            this.cbMinuteTo.IntegralHeight = false;
            this.cbMinuteTo.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbMinuteTo.Location = new System.Drawing.Point(149, 226);
            this.cbMinuteTo.Name = "cbMinuteTo";
            this.cbMinuteTo.Size = new System.Drawing.Size(96, 21);
            this.cbMinuteTo.TabIndex = 13;
            // 
            // cbHourTo
            // 
            this.cbHourTo.DropDownHeight = 80;
            this.cbHourTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHourTo.FormattingEnabled = true;
            this.cbHourTo.IntegralHeight = false;
            this.cbHourTo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbHourTo.Location = new System.Drawing.Point(149, 188);
            this.cbHourTo.Name = "cbHourTo";
            this.cbHourTo.Size = new System.Drawing.Size(96, 21);
            this.cbHourTo.TabIndex = 14;
            // 
            // cbMinuteFrom
            // 
            this.cbMinuteFrom.DropDownHeight = 80;
            this.cbMinuteFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinuteFrom.FormattingEnabled = true;
            this.cbMinuteFrom.IntegralHeight = false;
            this.cbMinuteFrom.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbMinuteFrom.Location = new System.Drawing.Point(149, 98);
            this.cbMinuteFrom.Name = "cbMinuteFrom";
            this.cbMinuteFrom.Size = new System.Drawing.Size(96, 21);
            this.cbMinuteFrom.TabIndex = 15;
            // 
            // cbHourFrom
            // 
            this.cbHourFrom.DropDownHeight = 80;
            this.cbHourFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHourFrom.FormattingEnabled = true;
            this.cbHourFrom.IntegralHeight = false;
            this.cbHourFrom.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbHourFrom.Location = new System.Drawing.Point(149, 60);
            this.cbHourFrom.Name = "cbHourFrom";
            this.cbHourFrom.Size = new System.Drawing.Size(96, 21);
            this.cbHourFrom.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Minute";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Hour";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Time To:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(265, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Minute";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(265, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Hour";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(110, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Time From:";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(369, 449);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(288, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(207, 449);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Open
            // 
            this.Open.FileName = "openFileDialog1";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(450, 484);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBlock;
        private System.Windows.Forms.RadioButton rbAllow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckState;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBrowes;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.RadioButton rbThisProgram;
        private System.Windows.Forms.RadioButton rbAllProgram;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbPublic;
        private System.Windows.Forms.CheckBox cbPrivate;
        private System.Windows.Forms.CheckBox cbDomain;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbAllLocal;
        private System.Windows.Forms.RadioButton rbIPLocal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAddLocal;
        private System.Windows.Forms.Button btnEditLocal;
        private System.Windows.Forms.Button btnDelLocal;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnDelRemote;
        private System.Windows.Forms.Button btnEditRemote;
        private System.Windows.Forms.Button btnAddRemote;
        private System.Windows.Forms.RadioButton rbIPRemote;
        private System.Windows.Forms.RadioButton rbAllRemote;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtRemoteport;
        private System.Windows.Forms.TextBox txtLocalport;
        private System.Windows.Forms.ComboBox cbRemoteport;
        private System.Windows.Forms.ComboBox cbLocalport;
        private System.Windows.Forms.ComboBox cbProtocol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cbMinuteTo;
        private System.Windows.Forms.ComboBox cbHourTo;
        private System.Windows.Forms.ComboBox cbMinuteFrom;
        private System.Windows.Forms.ComboBox cbHourFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog Open;
    }
}