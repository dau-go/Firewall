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
        public EditForm()
        {
            InitializeComponent();
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
            SetRule();
        }
        public void SetRule()
        {
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
            listView1.Enabled = false;
            btnAddLocal.Enabled = false;
            btnEditLocal.Enabled = false;
            btnDelLocal.Enabled = false;
        }

        private void rbIPLocal_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Enabled = true;
            btnAddLocal.Enabled = true;
        }

        private void btnAddLocal_Click(object sender, EventArgs e)
        {
            AddIPForm f = new AddIPForm(0, 1);
            f.ShowDialog();
            if (_LocalIP != "" || _LocalIP == null)
            {
                listView1.Items.Add(_LocalIP);
            }
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
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditRemote.Enabled = true;
            btnDelRemote.Enabled = true;
            _IPFocus = listView1.FocusedItem.Text;
        }

        //Remote IP
        private void rbAllRemote_CheckedChanged(object sender, EventArgs e)
        {
            listView2.Enabled = false;
            btnAddRemote.Enabled = false;
            btnEditRemote.Enabled = false;
            btnDelRemote.Enabled = false;
        }

        private void rbIPRemote_CheckedChanged(object sender, EventArgs e)
        {
            listView2.Enabled = true;
            btnAddRemote.Enabled = true;
        }

        private void btnAddRemote_Click(object sender, EventArgs e)
        {
            AddIPForm f = new AddIPForm(1, 0);
            f.ShowDialog();
            if (_RemoteIP != "" || _RemoteIP == null)
            {
                listView2.Items.Add(_RemoteIP);
            }
        }

        private void btnEditRemote_Click(object sender, EventArgs e)
        {
            AddIPForm f = new AddIPForm(3, 0);
            f.ShowDialog();
            listView2.Items[listView2.FocusedItem.Index].Text = _RemoteIP;
        }

        private void btnDelRemote_Click(object sender, EventArgs e)
        {
            listView2.Items.Remove(listView2.FocusedItem);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditRemote.Enabled = true;
            btnDelRemote.Enabled = true;
            _IPFocus = listView2.FocusedItem.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnApply_Click(sender, e);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var firewallRule = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            var rule = firewallRule.Rules.Item(NameRule);
            //set data
            string localport, remoteport, localIP, remoteIP, program, action, profile = "", state;
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
                    int ktname = 0;
                    foreach (INetFwRule r in firewallRule.Rules)
                    {
                        if (txtName.Text == r.Name)
                        {
                            ktname = 1;
                            break;
                        }
                    }
                    if (ktname == 1)
                    {
                        MessageBox.Show("Rule name already exists", "Firewall");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("You must specify the rule name", "Firewall");
                }
            }
            if (localport != "")
            {
                if (localport != "Any")
                {
                    if (ValidatePort(localport) == false)
                    {
                        MessageBox.Show("The port value is incorrect", "Firewall");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("You must specify the port you want to add to the rule", "Firewall");
                return;
            }
            if (remoteport != "")
            {
                if (remoteport != "Any")
                {
                    if (ValidatePort(remoteport) == false)
                    {
                        MessageBox.Show("The port value is incorrect", "Firewall");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("You must specify the port you want to add to the rule", "Firewall");
                return;
            }
            if (program == null || program == "")
            {
                MessageBox.Show("You must specify a program path", "Firewall");
                return;
            }
            //edit rule
            if (Description != txtDescription.Text)
            {
                rule.Description = txtDescription.Text;
            }
            if (State != state)
            {
                if (state == "Yes")
                {
                    rule.Enabled = true;
                }
                else
                {
                    rule.Enabled = false;
                }
            }
            if (Action != action)
            {
                if (action == "Allow")
                {
                    rule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                }
                else
                {
                    rule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
                }
            }
            if (Program != program)
            {
                if (program != "Any")
                {
                    rule.ApplicationName = program;
                }
                else
                {
                    rule.ApplicationName = null;
                }
            }
            if (Profile != profile)
            {
                rule.Profiles = intprofile;
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
            }
            if (LocalPort != localport)
            {
                if (localport != "Any")
                {
                    rule.LocalPorts = localport;
                }
                else
                {
                    rule.LocalPorts = null;
                }
            }
            if (RemotePort != remoteport)
            {
                if (remoteport != "Any")
                {
                    rule.RemotePorts = remoteport;
                }
                else
                {
                    rule.RemotePorts = null;
                }
            }
            if (LocalIP != localIP)
            {
                if (localIP != "Any")
                {
                    rule.LocalAddresses = localIP;
                }
                else
                {
                    rule.LocalAddresses = null;
                }
            }
            if (RemoteIP != remoteIP)
            {
                if (remoteIP != "Any")
                {
                    rule.RemoteAddresses = remoteIP;
                }
                else
                {
                    rule.RemoteAddresses = null;
                }
            }
            if (NameRule != txtName.Text)
            {
                rule.Name = txtName.Text;
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
