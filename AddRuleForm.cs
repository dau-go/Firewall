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
    public partial class AddRuleForm : Form
    {
        private static int _kt;
        public static int kt
        {
            get { return _kt; }
            set { _kt = value; }
        }
        private static string _Name;
        public static string NameRule
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private static string _Description;
        public static string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        private static int _Action;
        public static int Action
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
        private static int _Protocol;
        public static int Protocol
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
        private static int _Profile;
        public static int Profile
        {
            get { return _Profile; }
            set { _Profile = value; }
        }
        AddDomainForm f = new AddDomainForm();
        RuleIPForm f1 = new RuleIPForm();
        RulePortForm f2 = new RulePortForm();
        RuleProfileForm f3 = new RuleProfileForm();
        RuleProgramForm f4 = new RuleProgramForm();
        RulePropertiesForm f5 = new RulePropertiesForm();
        RuleProtocolForm f6 = new RuleProtocolForm();
        RuleTypeForm f7 = new RuleTypeForm();
        int k = 1;
        public AddRuleForm()
        {
            InitializeComponent();
            if (_kt != 2)
            {
                ShowRuleTypeForm();
            }
            else
            {
                ShowAddWebRule();
            }

        }
        public void ShowAddWebRule()
        {
            groupBox1.Controls.Clear();
            groupBox1.Text = "Website blocking rules";
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(f);
            f.Visible = true;
            btnNext.Visible = false;
            btnfis.Visible = true;
        }
        private void ShowRuleTypeForm()
        {
            groupBox1.Controls.Clear();
            groupBox1.Text = "Rule Type";
            f7.send = new RuleTypeForm.SendMessage(GetValueType);
            f7.TopLevel = false;
            f7.FormBorderStyle = FormBorderStyle.None;
            f7.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(f7);
            f7.Visible = true;
        }
        public void GetValueType(int i)
        {
            k = i;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            btnNext.Visible = false;
            btnNext1.Visible = true;
            btnNext2.Visible = false;
            btnNext3.Visible = false;
            btnBack.Visible = true;
            btnBack1.Visible = false;
            btnBack2.Visible = false;
            btnBack3.Visible = false;
            btnfis.Visible = false;
            ShowPro();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowRuleTypeForm();
            btnNext.Visible = true;
            btnNext1.Visible = false;
            btnNext2.Visible = false;
            btnNext3.Visible = false;
            btnBack.Visible = false;
            btnBack1.Visible = false;
            btnBack2.Visible = false;
            btnBack3.Visible = false;
            btnfis.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
        public void ShowPro()
        {
            if (k == 1)
            {
                btnBack.Visible = true;
                groupBox1.Controls.Clear();
                groupBox2.Controls.Clear();
                groupBox3.Controls.Clear();
                groupBox1.Text = "";
                groupBox1.Controls.Add(groupBox2);
                groupBox1.Controls.Add(groupBox3);
                groupBox2.Text = "Properties";
                groupBox3.Text = "Program";
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                //
                f5.TopLevel = false;
                f5.FormBorderStyle = FormBorderStyle.None;
                f5.Dock = DockStyle.Fill;
                groupBox2.Controls.Add(f5);
                f5.Visible = true;
                //
                f4.TopLevel = false;
                f4.FormBorderStyle = FormBorderStyle.None;
                f4.Dock = DockStyle.Fill;
                groupBox3.Controls.Add(f4);
                f4.Visible = true;
            }
            if (k == 2)
            {
                btnBack.Visible = true;
                groupBox1.Controls.Clear();
                groupBox2.Controls.Clear();
                groupBox3.Controls.Clear();
                groupBox1.Text = "";
                groupBox1.Controls.Add(groupBox2);
                groupBox1.Controls.Add(groupBox3);
                groupBox2.Text = "Properties";
                groupBox3.Text = "Program And Port";
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                //
                f5.TopLevel = false;
                f5.FormBorderStyle = FormBorderStyle.None;
                f5.Dock = DockStyle.Fill;
                groupBox2.Controls.Add(f5);
                f5.Visible = true;
                //
                f2.TopLevel = false;
                f2.FormBorderStyle = FormBorderStyle.None;
                f2.Dock = DockStyle.Fill;
                groupBox3.Controls.Add(f2);
                f2.Visible = true;
            }
            if (k == 3)
            {
                btnBack.Visible = true;
                groupBox1.Controls.Clear();
                groupBox2.Controls.Clear();
                groupBox3.Controls.Clear();
                groupBox1.Text = "";
                groupBox1.Controls.Add(groupBox2);
                groupBox1.Controls.Add(groupBox3);
                groupBox2.Text = "Properties";
                groupBox3.Text = "Program";
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                //
                f5.TopLevel = false;
                f5.FormBorderStyle = FormBorderStyle.None;
                f5.Dock = DockStyle.Fill;
                groupBox2.Controls.Add(f5);
                f5.Visible = true;
                //
                f4.TopLevel = false;
                f4.FormBorderStyle = FormBorderStyle.None;
                f4.Dock = DockStyle.Fill;
                groupBox3.Controls.Add(f4);
                f4.Visible = true;
            }
        }
        private void btnNext1_Click(object sender, EventArgs e)
        {
            if (_Name != null)
            {
                switch (k)
                {
                    case 1:
                        {
                            if (_Program != null)
                            {
                                groupBox1.Controls.Clear();
                                groupBox1.Text = "Profile";
                                f3.TopLevel = false;
                                f3.FormBorderStyle = FormBorderStyle.None;
                                f3.Dock = DockStyle.Fill;
                                groupBox1.Controls.Add(f3);
                                f3.Visible = true;
                                btnNext.Visible = false;
                                btnNext1.Visible = false;
                                btnNext2.Visible = false;
                                btnNext3.Visible = false;
                                btnBack.Visible = false;
                                btnBack1.Visible = true;
                                btnBack2.Visible = false;
                                btnBack3.Visible = false;
                                btnfis.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("You must specify a program path", "Firewall");
                            }
                            break;
                        }
                    case 2:
                        {
                            if (_LocalPort != "")
                            {
                                if (_LocalPort != "Any")
                                {
                                    if (ValidatePort(_LocalPort) == false)
                                    {
                                        MessageBox.Show("The port value is incorrect", "Firewall");
                                        break;
                                    }
                                }
                                groupBox1.Controls.Clear();
                                groupBox1.Text = "Profile";
                                f3.TopLevel = false;
                                f3.FormBorderStyle = FormBorderStyle.None;
                                f3.Dock = DockStyle.Fill;
                                groupBox1.Controls.Add(f3);
                                f3.Visible = true;
                                btnNext.Visible = false;
                                btnNext1.Visible = false;
                                btnNext2.Visible = false;
                                btnNext3.Visible = false;
                                btnBack.Visible = false;
                                btnBack1.Visible = true;
                                btnBack2.Visible = false;
                                btnBack3.Visible = false;
                                btnfis.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("You must specify the port you want to add to the rule", "Firewall");
                            }
                            break;
                        }
                    case 3:
                        {
                            if (_Program != null)
                            {
                                groupBox1.Controls.Clear();
                                groupBox1.Text = "Protocol and Port";
                                f6.TopLevel = false;
                                f6.FormBorderStyle = FormBorderStyle.None;
                                f6.Dock = DockStyle.Fill;
                                groupBox1.Controls.Add(f6);
                                f6.Visible = true;
                                btnNext.Visible = false;
                                btnNext1.Visible = false;
                                btnNext2.Visible = true;
                                btnNext3.Visible = false;
                                btnBack.Visible = false;
                                btnBack1.Visible = true;
                                btnBack2.Visible = false;
                                btnBack3.Visible = false;
                                btnfis.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("You must specify a program path", "Firewall");
                            }
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("You must specify the rule name", "Firewall");
            }
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            if (k == 1 || k == 2)
            {
                ShowPro();
            }
            else
            {
                btnBack.Visible = true;
                groupBox1.Controls.Clear();
                groupBox2.Controls.Clear();
                groupBox3.Controls.Clear();
                groupBox1.Text = "";
                groupBox1.Controls.Add(groupBox2);
                groupBox1.Controls.Add(groupBox3);
                groupBox2.Text = "Properties";
                groupBox3.Text = "Program";
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                //
                f5.TopLevel = false;
                f5.FormBorderStyle = FormBorderStyle.None;
                f5.Dock = DockStyle.Fill;
                groupBox2.Controls.Add(f5);
                f5.Visible = true;
                //
                f4.TopLevel = false;
                f4.FormBorderStyle = FormBorderStyle.None;
                f4.Dock = DockStyle.Fill;
                groupBox3.Controls.Add(f4);
                f4.Visible = true;
            }
            btnNext.Visible = false;
            btnNext1.Visible = true;
            btnNext2.Visible = false;
            btnNext3.Visible = false;
            btnBack.Visible = true;
            btnBack1.Visible = false;
            btnBack2.Visible = false;
            btnBack3.Visible = false;
            btnfis.Visible = false;
        }


        private void btnback2_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            groupBox1.Text = "Protocol and Port";
            f6.TopLevel = false;
            f6.FormBorderStyle = FormBorderStyle.None;
            f6.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(f6);
            f6.Visible = true;
            btnNext.Visible = false;
            btnNext1.Visible = false;
            btnNext2.Visible = true;
            btnNext3.Visible = false;
            btnBack.Visible = false;
            btnBack1.Visible = true;
            btnBack2.Visible = false;
            btnBack3.Visible = false;
            btnfis.Visible = false;
        }

        private void btnnext2_Click(object sender, EventArgs e)
        {
            if (_LocalPort != "" || _RemotePort != "")
            {
                if (_LocalPort != "Any")
                {
                    if (ValidatePort(_LocalPort) == false)
                    {
                        MessageBox.Show("The port value is incorrect", "Firewall");
                        return;
                    }
                }
                if (_RemotePort != "Any")
                {
                    if (ValidatePort(_RemotePort) == false)
                    {
                        MessageBox.Show("The port value is incorrect", "Firewall");
                        return;
                    }
                }
                groupBox1.Controls.Clear();
                groupBox1.Text = "Scope";
                f1.TopLevel = false;
                f1.FormBorderStyle = FormBorderStyle.None;
                f1.Dock = DockStyle.Fill;
                groupBox1.Controls.Add(f1);
                f1.Visible = true;
                btnNext.Visible = false;
                btnNext1.Visible = false;
                btnNext2.Visible = false;
                btnNext3.Visible = true;
                btnBack.Visible = false;
                btnBack1.Visible = false;
                btnBack2.Visible = true;
                btnBack3.Visible = false;
                btnfis.Visible = false;
            }
            else
            {
                MessageBox.Show("You must specify the port you want to add to the rule", "Firewall");
            }
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            groupBox1.Text = "Scope";
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(f1);
            f1.Visible = true;
            btnNext.Visible = false;
            btnNext1.Visible = false;
            btnNext2.Visible = false;
            btnNext3.Visible = true;
            btnBack.Visible = false;
            btnBack1.Visible = false;
            btnBack2.Visible = true;
            btnBack3.Visible = false;
            btnfis.Visible = false;
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            groupBox1.Text = "Profile";
            f3.TopLevel = false;
            f3.FormBorderStyle = FormBorderStyle.None;
            f3.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(f3);
            f3.Visible = true;
            btnNext.Visible = false;
            btnNext1.Visible = false;
            btnNext2.Visible = false;
            btnNext3.Visible = false;
            btnBack.Visible = false;
            btnBack1.Visible = false;
            btnBack2.Visible = false;
            btnBack3.Visible = true;
            btnfis.Visible = true;
        }

        private void btnfis_Click(object sender, EventArgs e)
        {
            if (_kt != 2)
            {
                Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
                INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);

                // Let's create a new rule
                INetFwRule2 inboundRule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                inboundRule.Enabled = true;
                inboundRule.Name = _Name;
                inboundRule.Description = _Description;
                switch (k)
                {
                    case 1:
                        {
                            if (_Action == 0)
                            {
                                inboundRule.Action = 0;
                            }
                            if (_Program != "Any")
                            {
                                inboundRule.ApplicationName = _Program;
                            }
                            inboundRule.Profiles = _Profile;
                            break;
                        }
                    case 2:
                        {
                            if (_Action == 0)
                            {
                                inboundRule.Action = 0;
                            }
                            inboundRule.Protocol = _Protocol;
                            if (_LocalPort != "Any")
                            {
                                if (_kt == 1)
                                {
                                    inboundRule.RemotePorts = _LocalPort;
                                }
                                else
                                {
                                    inboundRule.LocalPorts = _LocalPort;
                                }
                            }
                            inboundRule.Profiles = _Profile;
                            break;
                        }
                    case 3:
                        {
                            if (_Action == 0)
                            {
                                inboundRule.Action = 0;
                            }
                            if (_Program != "Any")
                            {
                                inboundRule.ApplicationName = _Program;
                            }
                            inboundRule.Protocol = _Protocol;
                            inboundRule.Profiles = _Profile;
                            if (_LocalPort != "Any")
                            {
                                inboundRule.LocalPorts = _LocalPort;
                            }
                            if (_RemotePort != "Any")
                            {
                                inboundRule.RemotePorts = _RemotePort;
                            }
                            if (_LocalIP != "Any")
                            {
                                inboundRule.LocalAddresses = _LocalIP;
                            }
                            if (_RemoteIP != "Any")
                            {
                                inboundRule.RemoteAddresses = _RemoteIP;
                            }
                            break;
                        }
                }
                if (_kt == 1)
                {
                    inboundRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                }
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                firewallPolicy.Rules.Add(inboundRule);
                this.Close();
            }
            else
            {
                int m = 0;
                try
                {
                    f.Finish();
                    m++;
                }
                catch
                {
                    
                }
                if (m == 1) this.Close();
            }
        }
    }
}
