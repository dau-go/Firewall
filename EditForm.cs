using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsExample
{
    public partial class EditForm : Form
    {
        public delegate void SendMessage();
        public SendMessage send;
        private static string _Name;
        public static string NameRule
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private static string _State;
        public static string State
        {
            get { return _State; }
            set { _State = value; }
        }
        private static string _Description;
        public static string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        private static string _Action;
        public static string Action
        {
            get { return _Action; }
            set { _Action = value; }
        }
        private static string _Program;
        public static string Program
        {
            get { return _Program; }
            set { _Program = value; }
        }
        private static string _Protocol;
        public static string Protocol
        {
            get { return _Protocol; }
            set { _Protocol = value; }
        }
        private static string _LocalPort;
        public static string LocalPort
        {
            get { return _LocalPort; }
            set { _LocalPort = value; }
        }
        private static string _RemotePort;
        public static string RemotePort
        {
            get { return _RemotePort; }
            set { _RemotePort = value; }
        }
        private static string _LocalIP;
        public static string LocalIP
        {
            get { return _LocalIP; }
            set { _LocalIP = value; }
        }
        private static string _RemoteIP;
        public static string RemoteIP
        {
            get { return _RemoteIP; }
            set { _RemoteIP = value; }
        }
        private static string _Profile;
        public static string Profile
        {
            get { return _Profile; }
            set { _Profile = value; }
        }
        private static string _IPFocus;
        public static string IPFocus
        {
            get { return _IPFocus; }
            set { _IPFocus = value; }
        }
        int k;
        public EditForm()
        {
            InitializeComponent();
            tabControl1.Controls.Remove(tabPage5);
            SetRule();
            k = 0;
            if (FirewallForm.Lang == 0)
            {
                ShowTiengViet();
            }
            else
            {
                ShowEnglish();
            }
        }
        public void ShowTiengViet()
        {
            this.Text = "Thuộc Tính";
            tabPage1.Text = "Thông Tin Chung";
            tabPage2.Text = "Chương Trình và Hồ Sơ";
            tabPage3.Text = "Giao Thức và Cổng";
            tabPage4.Text = "Phạm Vi";
            tabPage5.Text = "Thời Gian";
            groupBox1.Text = "Thông Tin Chung";
            groupBox2.Text = "Hoạt Động";
            groupBox3.Text = "Chương Trình";
            groupBox4.Text = "Hồ Sơ";
            groupBox5.Text = "Địa Chỉ IP Từ Xa";
            groupBox6.Text = "Địa Chỉ IP Nội Bộ";
            groupBox7.Text = "Giao Thức và Cổng";
            groupBox8.Text = "Thời Gian";
            label1.Text = "Tên:";
            label2.Text = "Miêu tả:";
            label3.Text = "Hồ sơ được chỉ định áp dụng quy tắc này";
            label4.Text = "Ví Dụ: 80,443,...";
            label5.Text = "Cổng nội bộ:";
            label6.Text = "Ví Dụ: 80,443,...";
            label7.Text = "Cổng từ xa:";
            label8.Text = "Loại giao thức:";
            label9.Text = "Phút";
            label10.Text = "Giờ";
            label11.Text = "Thời gian đến:";
            label12.Text = "Phút";
            label13.Text = "Giờ";
            label14.Text = "Thời gian từ:";
            ckState.Text = "Bật";
            cbDomain.Text = "Tên miền";
            cbPrivate.Text = "Bảo mật";
            cbPublic.Text = "Công khai";
            rbAllow.Text = "Cho phép kết nối";
            rbBlock.Text = "Chặn kết nối";
            rbAllProgram.Text = "Tất cả các chương trình đáp ứng các điều kiện quy định";
            rbThisProgram.Text = "Đường dẫn chương trình:";
            rbAllLocal.Text = "Tất cả địa chỉ IP";
            rbAllRemote.Text = "Tất cả địa chỉ IP";
            rbIPLocal.Text = "Các địa chỉ IP sau:";
            rbIPRemote.Text = "Các địa chỉ IP sau:";
            btnBrowes.Text = "Trình duyệt";
            btnAddLocal.Text = "Thêm...";
            btnEditLocal.Text = "Sửa...";
            btnDelLocal.Text = "Xóa";
            btnAddRemote.Text = "Thêm...";
            btnEditRemote.Text = "Sửa...";
            btnDelRemote.Text = "Xóa";
            btnApply.Text = "Áp dụng";
            btnOK.Text = "Đồng Ý";
            btnCancel.Text = "Hủy";
        }
        public void ShowEnglish()
        {
            this.Text = "Properties";
            tabPage1.Text = "General Information";
            tabPage2.Text = "Program and Profile";
            tabPage3.Text = "Protocol and Ports";
            tabPage4.Text = "Scope";
            tabPage5.Text = "Time";
            groupBox1.Text = "General";
            groupBox2.Text = "Action";
            groupBox3.Text = "Program";
            groupBox4.Text = "Profile";
            groupBox5.Text = "Remote IP Address";
            groupBox6.Text = "Local IP Address";
            groupBox7.Text = "Protocol and Ports";
            groupBox8.Text = "Time";
            label1.Text = "Name:";
            label2.Text = "Description:";
            label3.Text = "Specified profiles to which this rule applies";
            label4.Text = "Example: 80,443,...";
            label5.Text = "Local port:";
            label6.Text = "Example: 80,443,...";
            label7.Text = "Remote port:";
            label8.Text = "Protocol type:";
            label9.Text = "Minute";
            label10.Text = "Hour";
            label11.Text = "Time To:";
            label12.Text = "Minute";
            label13.Text = "Hour";
            label14.Text = "Time From:";
            ckState.Text = "Enable";
            cbDomain.Text = "Domain";
            cbPrivate.Text = "Private";
            cbPublic.Text = "Public";
            rbAllow.Text = "Allow the connection";
            rbBlock.Text = "Block the connection";
            rbAllProgram.Text = "All program that meet the specified conditions";
            rbThisProgram.Text = "This program path:";
            rbAllLocal.Text = "Any IP address";
            rbAllRemote.Text = "Any IP address";
            rbIPLocal.Text = "These IP address:";
            rbIPRemote.Text = "These IP address:";
            btnBrowes.Text = "Browser...";
            btnAddLocal.Text = "Add...";
            btnEditLocal.Text = "Edit...";
            btnDelLocal.Text = "Remove";
            btnAddRemote.Text = "Add...";
            btnEditRemote.Text = "Edit...";
            btnDelRemote.Text = "Remove";
            btnApply.Text = "Apply";
            btnOK.Text = "Ok";
            btnCancel.Text = "Cancel";
        }
        public void editform1()
        {
            var firewallRule = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            var rule = firewallRule.Rules.Item(NameRule);
            tabControl1.Controls.Add(tabPage5);
            string[] s = rule.Description.Split('-', ':');
            Description = rule.Description;
            cbHourFrom.Text = s[0];
            cbMinuteFrom.Text = s[1];
            cbHourTo.Text = s[2];
            cbMinuteTo.Text = s[3];
            rbAllow.Enabled = false;
            rbBlock.Enabled = false;
            txtName.Text = txtName.Text.Split('(')[0];
            k = 1;
        }
        public void SetRule()
        {
            txtName.Text = NameRule;
            txtDescription.Text = Description;
            if (State == "Yes")
            {
                ckState.Checked = true;
            }
            else
            {
                ckState.Checked = false;
            }
            if (Action == "Allow")
            {
                rbAllow.Checked = true;
            }
            else
            {
                rbBlock.Checked = true;
            }
            if (Program == "Any")
            {
                rbAllProgram.Checked = true;
                txtProgram.Enabled = false;
                btnBrowes.Enabled = false;
            }
            else
            {
                rbThisProgram.Checked = true;
                txtProgram.Text = Program;
                btnBrowes.Enabled = true;
            }
            switch (Profile)
            {
                case "Domain":
                    {
                        cbDomain.Checked = true;
                        cbPrivate.Checked = false;
                        cbPublic.Checked = false;
                        break;
                    }
                case "Domain, Private":
                    {
                        cbDomain.Checked = true;
                        cbPrivate.Checked = true;
                        cbPublic.Checked = false;
                        break;
                    }
                case "Domain, Private, Public":
                    {
                        cbDomain.Checked = true;
                        cbPrivate.Checked = true;
                        cbPublic.Checked = true;
                        break;
                    }
                case "Domain, Public":
                    {
                        cbDomain.Checked = true;
                        cbPrivate.Checked = false;
                        cbPublic.Checked = true;
                        break;
                    }
                case "Private":
                    {
                        cbDomain.Checked = false;
                        cbPrivate.Checked = true;
                        cbPublic.Checked = false;
                        break;
                    }
                case "Private, Public":
                    {
                        cbDomain.Checked = false;
                        cbPrivate.Checked = true;
                        cbPublic.Checked = true;
                        break;
                    }
                case "Public":
                    {
                        cbDomain.Checked = false;
                        cbPrivate.Checked = false;
                        cbPublic.Checked = true;
                        break;
                    }
            }
            cbProtocol.Text = Protocol;
            if (LocalPort == "Any")
            {
                cbLocalport.SelectedIndex = 0;
                txtLocalport.Enabled = false;
            }
            else
            {
                cbLocalport.SelectedIndex = 1;
                txtLocalport.Enabled = true;
                txtLocalport.Text = LocalPort;
            }
            if (RemotePort == "Any")
            {
                cbRemoteport.SelectedIndex = 0;
                txtRemoteport.Enabled = false;
            }
            else
            {
                cbRemoteport.SelectedIndex = 1;
                txtRemoteport.Enabled = true;
                txtRemoteport.Text = RemotePort;
            }
            if (LocalIP == "Any")
            {
                rbAllLocal.Checked = true;
                btnAddLocal.Enabled = false;
                btnEditLocal.Enabled = false;
                btnDelLocal.Enabled = false;
            }
            else
            {
                rbIPLocal.Checked = true;
                btnAddLocal.Enabled = true;
                btnEditLocal.Enabled = false;
                btnDelLocal.Enabled = false;
                string[] s = LocalIP.Split(',');
                for (int i = 0; i < s.Length; i++)
                {
                    listView1.Items.Add(s[i]);
                }
            }
            if (RemoteIP == "Any")
            {
                rbAllRemote.Checked = true;
                btnAddRemote.Enabled = false;
                btnEditRemote.Enabled = false;
                btnDelRemote.Enabled = false;
            }
            else
            {
                rbIPLocal.Checked = true;
                btnAddRemote.Enabled = true;
                btnEditRemote.Enabled = false;
                btnDelRemote.Enabled = false;
                string[] s = RemoteIP.Split(',');
                for (int i = 0; i < s.Length; i++)
                {
                    listView2.Items.Add(s[i]);
                }
            }
            var firewallRule = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            foreach (INetFwRule rule in firewallRule.Rules)
            {
                if (NameRule == rule.Name)
                {
                    string s = rule.Grouping;
                    if (s != null)
                    {
                        txtName.ReadOnly = true;
                        txtDescription.ReadOnly = true;
                        rbAllProgram.Enabled = false;
                        rbThisProgram.Enabled = false;
                        txtProgram.ReadOnly = true;
                        btnBrowes.Enabled = false;
                        cbProtocol.Enabled = false;
                        cbLocalport.Enabled = false;
                        cbRemoteport.Enabled = false;
                        txtLocalport.Enabled = false;
                        txtRemoteport.Enabled = false;
                    }
                    else
                    {
                        txtName.ReadOnly = false;
                        txtDescription.ReadOnly = false;
                        rbAllProgram.Enabled = true;
                        rbThisProgram.Enabled = true;
                        txtProgram.ReadOnly = false;
                        if (rbThisProgram.Checked == true)
                        {
                            btnBrowes.Enabled = true;
                        }
                    }
                }
            }
        }

        private void rbAllProgram_CheckedChanged(object sender, EventArgs e)
        {
            txtProgram.Enabled = false;
            btnBrowes.Enabled = false;
        }

        private void rbThisProgram_CheckedChanged(object sender, EventArgs e)
        {
            txtProgram.Enabled = true;
            btnBrowes.Enabled = true;
        }

        private void btnBrowes_Click(object sender, EventArgs e)
        {
            Open.ShowDialog();
            txtProgram.Text = Open.FileName;
        }

        private void cbProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProtocol.Text == "TCP" || cbProtocol.Text == "UDP")
            {
                cbLocalport.Enabled = true;
                cbRemoteport.Enabled = true;
            }
            else
            {
                cbLocalport.Enabled = false;
                cbLocalport.SelectedIndex = 0;
                txtLocalport.Enabled = false;
                txtLocalport.Text = "";
                cbRemoteport.Enabled = false;
                cbRemoteport.SelectedIndex = 0;
                txtRemoteport.Enabled = false;
                txtRemoteport.Text = "";
            }
        }

        private void cbLocalport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocalport.SelectedIndex == 0)
            {
                txtLocalport.Enabled = false;
                txtLocalport.Text = "";
            }
            else
            {
                txtLocalport.Enabled = true;
                txtRemoteport.Text = "";
            }
        }

        private void cbRemoteport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocalport.SelectedIndex == 0)
            {
                txtRemoteport.Enabled = false;
            }
            else
            {
                txtRemoteport.Enabled = true;
            }
        }
        private string GetIPLocal()
        {
            string s = "";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (i == 0)
                {
                    s = listView1.Items[0].Text;
                }
                else
                {
                    s = s + "," + listView1.Items[i].Text;
                }
            }
            return s;
        }
        private string GetIPRemote()
        {
            string s = "";
            for (int i = 0; i < listView2.Items.Count; i++)
            {
                if (i == 0)
                {
                    s = listView2.Items[0].Text;
                }
                else
                {
                    s = s + "," + listView2.Items[i].Text;
                }
            }
            return s;
        }
        //Local IP
        private void rbAllLocal_CheckedChanged(object sender, EventArgs e)
        {
            btnAddLocal.Enabled = false;
            btnEditLocal.Enabled = false;
            btnDelLocal.Enabled = false;
            btnEditRemote.Enabled = false;
            btnDelRemote.Enabled = false;
        }
        private void rbIPLocal_Click(object sender, EventArgs e)
        {
            listView1.Enabled = true;
            btnAddLocal.Enabled = true;
            btnEditLocal.Enabled = false;
            btnDelLocal.Enabled = false;
            btnEditRemote.Enabled = false;
            btnDelRemote.Enabled = false;
        }
        private void rbIPLocal_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Enabled = true;
            btnAddLocal.Enabled = true;
            btnEditLocal.Enabled = false;
            btnDelLocal.Enabled = false;
            btnEditRemote.Enabled = false;
            btnDelRemote.Enabled = false;
        }

        private void btnAddLocal_Click(object sender, EventArgs e)
        {
            AddIPForm f = new AddIPForm(0, 1);
            f.ShowDialog();
            if (_LocalIP != "" || _LocalIP == null)
            {
                listView1.Items.Add(_LocalIP);
            }
            btnEditLocal.Enabled = false;
            btnDelLocal.Enabled = false;
            btnEditRemote.Enabled = false;
            btnDelRemote.Enabled = false;
        }

        private void btnEditLocal_Click(object sender, EventArgs e)
        {
            AddIPForm f = new AddIPForm(2, 1);
            f.ShowDialog();
            listView1.Items[listView1.FocusedItem.Index].Text = _LocalIP;
        }

        private void btnDelLocal_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.FocusedItem);
            btnEditLocal.Enabled = false;
            btnDelLocal.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditLocal.Enabled = true;
            btnDelLocal.Enabled = true;
            _IPFocus = listView1.FocusedItem.Text;
            btnEditRemote.Enabled = false;
            btnDelRemote.Enabled = false;
        }

        //Remote IP
        private void rbAllRemote_CheckedChanged(object sender, EventArgs e)
        {
            btnAddRemote.Enabled = false;
            btnEditRemote.Enabled = false;
            btnDelRemote.Enabled = false;
            btnEditLocal.Enabled = false;
            btnDelLocal.Enabled = false;
        }


        private void rbIPRemote_Click(object sender, EventArgs e)
        {
            listView2.Enabled = true;
            btnAddRemote.Enabled = true;
            btnEditRemote.Enabled = false;
            btnDelRemote.Enabled = false;
            btnEditLocal.Enabled = false;
            btnDelLocal.Enabled = false;
        }

        private void btnAddRemote_Click(object sender, EventArgs e)
        {
            AddIPForm f = new AddIPForm(1, 1);
            f.ShowDialog();
            if (_RemoteIP != "" || _RemoteIP == null)
            {
                listView2.Items.Add(_RemoteIP);
            }
            btnEditRemote.Enabled = false;
            btnDelRemote.Enabled = false;
            btnEditLocal.Enabled = false;
            btnDelLocal.Enabled = false;
        }

        private void btnEditRemote_Click(object sender, EventArgs e)
        {
            AddIPForm f = new AddIPForm(3, 1);
            f.ShowDialog();
            listView2.Items[listView2.FocusedItem.Index].Text = _RemoteIP;
        }

        private void btnDelRemote_Click(object sender, EventArgs e)
        {
            listView2.Items.Remove(listView2.FocusedItem);
            btnEditRemote.Enabled = false;
            btnDelRemote.Enabled = false;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditRemote.Enabled = true;
            btnDelRemote.Enabled = true;
            _IPFocus = listView2.FocusedItem.Text;
            btnEditLocal.Enabled = false;
            btnDelLocal.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Apply() == true)
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Apply();
        }
        public bool Apply()
        {
            var firewallRule = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            var rule = firewallRule.Rules.Item(NameRule);
            //set data
            string localport, remoteport, localIP, remoteIP, program, action, profile = "", state, description;
            int intprofile = 0;
            if (ckState.Checked == true)
            {
                state = "Yes";
            }
            else
            {
                state = "No";
            }
            if (rbAllow.Checked == true)
            {
                action = "Allow";
            }
            else
            {
                action = "Block";
            }
            if (cbDomain.Checked == true && cbPrivate.Checked == true && cbPublic.Checked == true)
            {
                profile = "Domain, Private, Public";
                intprofile = 7;
            }
            if (cbDomain.Checked == false && cbPrivate.Checked == true && cbPublic.Checked == true)
            {
                profile = "Private, Public";
                intprofile = 6;
            }
            if (cbDomain.Checked == true && cbPrivate.Checked == false && cbPublic.Checked == true)
            {
                profile = "Domain, Public";
                intprofile = 5;
            }
            if (cbDomain.Checked == true && cbPrivate.Checked == true && cbPublic.Checked == false)
            {
                profile = "Domain, Private";
                intprofile = 3;
            }
            if (cbDomain.Checked == false && cbPrivate.Checked == false && cbPublic.Checked == true)
            {
                profile = "Public";
                intprofile = 4;
            }
            if (cbDomain.Checked == false && cbPrivate.Checked == true && cbPublic.Checked == false)
            {
                profile = "Private";
                intprofile = 2;
            }
            if (cbDomain.Checked == true && cbPrivate.Checked == false && cbPublic.Checked == false)
            {
                profile = "Domain";
                intprofile = 1;
            }
            if (rbAllProgram.Checked == true)
            {
                program = "Any";
            }
            else
            {
                program = txtProgram.Text;
            }
            localIP = GetIPLocal();
            remoteIP = GetIPRemote();
            if (cbProtocol.Text != "TCP" && cbProtocol.Text != "UDP")
            {
                localport = "Any";
                remoteport = "Any";
            }
            else
            {
                if (cbLocalport.SelectedIndex == 0)
                {
                    localport = "Any";
                    remoteport = "Any";
                }
                else
                {
                    localport = txtLocalport.Text;
                    remoteport = txtRemoteport.Text;
                }
            }
            //check 
            if (NameRule != txtName.Text)
            {
                if (txtName.Text != null && txtName.Text != "")
                {
                    foreach (INetFwRule r in firewallRule.Rules)
                    {
                        if (txtName.Text == r.Name)
                        {
                            if (FirewallForm.Lang == 0)
                            {
                                MessageBox.Show("Tên quy tắc đã tồn tại", "Tường Lửa");
                            }
                            else
                            {
                                MessageBox.Show("Rule name already exists", "Firewall");
                            }
                            return false;
                        }
                    }
                }
                else
                {
                    if (FirewallForm.Lang == 0)
                    {
                        MessageBox.Show("Bạn phải chỉ định tên quy tắc", "Tường Lửa");
                    }
                    else
                    {
                        MessageBox.Show("You must specify the rule name", "Firewall");
                    }
                    return false;
                }
            }
            if (cbLocalport.Text == "All Ports")
            {
                localport = "Any";
            }
            if (cbRemoteport.Text == "All Ports")
            {
                remoteport = "Any";
            }
            if (localport != "Any")
            {
                if (localport != "")
                {
                    if (ValidatePort(localport) == false)
                    {
                        if (FirewallForm.Lang == 0)
                        {
                            MessageBox.Show("Giá trị cổng không chính xác", "Tường Lửa");
                        }
                        else
                        {
                            MessageBox.Show("The port value is incorrect", "Firewall");
                        }
                        return false;
                    }
                }
                else
                {
                    if (FirewallForm.Lang == 0)
                    {
                        MessageBox.Show("Bạn phải chỉ định cổng bạn muốn thêm vào quy tắc", "Tường Lửa");
                    }
                    else
                    {
                        MessageBox.Show("You must specify the port you want to add to the rule", "Firewall");
                    }
                    return false;
                }
            }
            if (remoteport != "Any")
            {
                if (remoteport != "")
                {
                    if (ValidatePort(remoteport) == false)
                    {
                        if (FirewallForm.Lang == 0)
                        {
                            MessageBox.Show("Giá trị cổng không chính xác", "Tường Lửa");
                        }
                        else
                        {
                            MessageBox.Show("The port value is incorrect", "Firewall");
                        }
                        return false;
                    }
                }
                else
                {
                    if (FirewallForm.Lang == 0)
                    {
                        MessageBox.Show("Bạn phải chỉ định cổng bạn muốn thêm vào quy tắc", "Tường Lửa");
                    }
                    else
                    {
                        MessageBox.Show("You must specify the port you want to add to the rule", "Firewall");
                    }
                    return false;
                }
            }
            if (program == null || program == "")
            {
                if (FirewallForm.Lang == 0)
                {
                    MessageBox.Show("Bạn phải chỉ định đường dẫn chương trình", "Tường Lửa");
                }
                else
                {
                    MessageBox.Show("You must specify a program path", "Firewall");
                }
                return false;
            }
            //edit rule
            if (Description != txtDescription.Text)
            {
                rule.Description = txtDescription.Text;
                Description = txtDescription.Text;
            }
            if (State != state)
            {
                if (state == "Yes")
                {
                    rule.Enabled = true;
                    State = "Yes";
                }
                else
                {
                    rule.Enabled = false;
                    State = "No";
                }
            }
            if (Action != action)
            {
                if (action == "Allow")
                {
                    rule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                    Action = action;
                }
                else
                {
                    rule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
                    Action = action;
                }
            }
            if (Program != program)
            {
                if (program != "Any")
                {
                    rule.ApplicationName = program;
                    Program = program;
                }
                else
                {
                    rule.ApplicationName = null;
                    Program = program;
                }
            }
            if (Profile != profile)
            {
                rule.Profiles = intprofile;
                Profile = profile;
            }
            if (Protocol != cbProtocol.Text)
            {
                switch (cbProtocol.Text)
                {
                    case "Any":
                        {
                            rule.Protocol = 256;
                            break;
                        }
                    case "HOPOPT":
                        {
                            rule.Protocol = 0;
                            break;
                        }
                    case "ICMPv4":
                        {
                            rule.Protocol = 1;
                            break;
                        }
                    case "IGMP":
                        {
                            rule.Protocol = 2;
                            break;
                        }
                    case "TCP":
                        {
                            rule.Protocol = 6;
                            break;
                        }
                    case "UDP":
                        {
                            rule.Protocol = 17;
                            break;
                        }
                    case "IPv6":
                        {
                            rule.Protocol = 41;
                            break;
                        }
                    case "IPv6-Route":
                        {
                            rule.Protocol = 43;
                            break;
                        }
                    case "IPv6-Frag":
                        {
                            rule.Protocol = 44;
                            break;
                        }
                    case "GRE":
                        {
                            rule.Protocol = 47;
                            break;
                        }
                    case "ICMPv6":
                        {
                            rule.Protocol = 58;
                            break;
                        }
                    case "IPv6-NoNxt":
                        {
                            rule.Protocol = 59;
                            break;
                        }
                    case "IPv6-Opts":
                        {
                            rule.Protocol = 60;
                            break;
                        }
                    case "VRRP":
                        {
                            rule.Protocol = 112;
                            break;
                        }
                    case "PGM":
                        {
                            rule.Protocol = 113;
                            break;
                        }
                    case "L2TP":
                        {
                            rule.Protocol = 115;
                            break;
                        }
                }
                Protocol = cbProtocol.Text;
            }
            if (LocalPort != localport)
            {
                if (localport != "Any")
                {
                    rule.LocalPorts = localport;
                    LocalIP = localIP;
                }
                else
                {
                    rule.LocalPorts = null;
                    LocalIP = localIP;
                }
            }
            if (RemotePort != remoteport)
            {
                if (remoteport != "Any")
                {
                    rule.RemotePorts = remoteport;
                    RemoteIP = remoteIP;
                }
                else
                {
                    rule.RemotePorts = null;
                    RemoteIP = remoteIP;
                }
            }
            if (LocalIP != localIP)
            {
                if (localIP != "Any")
                {
                    rule.LocalAddresses = localIP;
                    LocalPort = LocalPort;
                }
                else
                {
                    rule.LocalAddresses = null;
                    LocalPort = LocalPort;
                }
            }
            if (RemoteIP != remoteIP)
            {
                if (remoteIP != "Any")
                {
                    rule.RemoteAddresses = remoteIP;
                    RemotePort = remoteport;
                }
                else
                {
                    rule.RemoteAddresses = null;
                    RemotePort = remoteport;
                }
            }
            if (k == 0)
            {
                if (NameRule != txtName.Text)
                {
                    rule.Name = txtName.Text;
                    NameRule = txtName.Text;
                }
            }
            else
            {
                if (Time() == true)
                {
                    description = cbHourFrom.Text + ":" + cbMinuteFrom.Text + "-" + cbHourTo.Text + ":" + cbMinuteTo.Text;
                    if (Description != description)
                    {
                        rule.Description = description;
                        Description = description;
                        rule.Name = txtName.Text + "(" + description + ")";
                        NameRule = txtName.Text + "(" + description + ")";
                    }
                }
            }
            send();
            return true;
        }
        public bool Time()
        {
            int giofrom = int.Parse(cbHourFrom.Text);
            int phutfrom = int.Parse(cbMinuteFrom.Text);
            int gioto = int.Parse(cbHourTo.Text);
            int phutto = int.Parse(cbMinuteTo.Text);
            if (giofrom > gioto)
            {
                return false;
            }
            else if (giofrom == gioto && phutfrom > phutto)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ValidatePort(string s)
        {
            string[] str = s.Split(',', '-');
            try
            {
                for (int i = 0; i < str.Length; i++)
                {
                    int j = int.Parse(str[i]);
                    if (j < 0 || j > 65535)
                    {
                        return false;
                    }
                    if (s.Contains('-') == true)
                    {
                        string[] str1 = s.Split('-');
                        for (int m = 0; m < str1.Length - 1; m++)
                        {
                            string[] str2 = str1[m].Split(',');
                            string[] str3 = str1[m + 1].Split(',');
                            if (int.Parse(str2[str2.Length - 1]) >= int.Parse(str3[0]))
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
