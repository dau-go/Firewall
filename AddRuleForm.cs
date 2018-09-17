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
        private static int _Next1;
        public static int Next1
        {
            get { return _Next1; }
            set { _Next1 = value; }
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
        RuleTypeForm f = new RuleTypeForm();
        RulePropertiesForm f1 = new RulePropertiesForm();
        RuleProgramForm f2 = new RuleProgramForm();
        RulePortForm f3 = new RulePortForm();
        RuleIPForm f4 = new RuleIPForm();
        int k = 1;
        public AddRuleForm()
        {
            InitializeComponent();
        }
        private void AddRuleForm_Load(object sender, EventArgs e)
        {
            ShowRuleTypeForm();
        }
        private void ShowRuleTypeForm()
        {
            groupBox1.Controls.Clear();
            groupBox1.Text = "Rule Type";
            f.send = new RuleTypeForm.SendMessage(GetValueType);
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(f);
            f.Visible = true;
        }
        public void GetValueType(int i)
        {
            k = i;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            ShowPro();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowRuleTypeForm();
            btnNext1.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNext1_Click(object sender, EventArgs e)
        {
            if (_Name != null)
            {
                groupBox1.Controls.Clear();
                groupBox1.Text = "Profile";
                RuleProfileForm f = new RuleProfileForm();
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                groupBox1.Controls.Add(f);
                f.Visible = true;
                btnBack.Visible = false;
                btnBack1.Visible = true;
                btnNext1.Visible = false;
                btnfis.Visible = true;
            }
            else
            {
                MessageBox.Show("You must specify the rule name", "Firewall");
            }
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            ShowPro();
            btnBack1.Visible = false;
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
                f1.TopLevel = false;
                f1.FormBorderStyle = FormBorderStyle.None;
                f1.Dock = DockStyle.Fill;
                groupBox2.Controls.Add(f1);
                f1.Visible = true;
                //
                f2.TopLevel = false;
                f2.FormBorderStyle = FormBorderStyle.None;
                f2.Dock = DockStyle.Fill;
                groupBox3.Controls.Add(f2);
                f2.Visible = true;
                btnNext1.Visible = true;
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
                groupBox3.Text = "Program";
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                //
                f1.TopLevel = false;
                f1.FormBorderStyle = FormBorderStyle.None;
                f1.Dock = DockStyle.Fill;
                groupBox2.Controls.Add(f1);
                f1.Visible = true;
                //
                f3.TopLevel = false;
                f3.FormBorderStyle = FormBorderStyle.None;
                f3.Dock = DockStyle.Fill;
                groupBox3.Controls.Add(f3);
                f3.Visible = true;
                btnNext1.Visible = true;
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
                f1.TopLevel = false;
                f1.FormBorderStyle = FormBorderStyle.None;
                f1.Dock = DockStyle.Fill;
                groupBox2.Controls.Add(f1);
                f1.Visible = true;
                //
                f4.TopLevel = false;
                f4.FormBorderStyle = FormBorderStyle.None;
                f4.Dock = DockStyle.Fill;
                groupBox3.Controls.Add(f4);
                f4.Visible = true;
                btnNext1.Visible = true;
            }
            if (k == 4)
            {

            }
        }

        private void btnfis_Click(object sender, EventArgs e)
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
                            inboundRule.LocalPorts = _LocalPort;
                        }
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
            }
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Add(inboundRule);
            this.Close();
        }
    }
}
