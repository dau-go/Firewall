using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetFwTypeLib;

namespace WinformsExample
{
    public partial class FirewallForm : Form
    {
        int Header = 0;
        int kt = 0;
        List<int> Next = new List<int>(), Back = new List<int>();
        int demnext = 0, demback = 0;
        InboundForm f1 = new InboundForm();
        OutboundForm f2 = new OutboundForm();
        InboundForm f3 = new InboundForm();
        OutboundForm f4 = new OutboundForm();
        WebsiteRuleForm f5 = new WebsiteRuleForm();
        public FirewallForm()
        {
            InitializeComponent();
            timer1.Start();
            toolTip1.SetToolTip(btnBack, "Navigate Backward");
            toolTip1.SetToolTip(btnNext, "Navigate Forward");
            toolTip1.SetToolTip(btnTree, "Show/Hide Console Tree");
            toolTip1.SetToolTip(btnReload, "Refresh Rule");
            toolTip1.SetToolTip(btnAdd, "Add New Rule");
            toolTip1.SetToolTip(btnDel, "Delete Rule");
            btnBack.BackgroundImage = global::WinformsExample.Properties.Resources.go_next_rtl;
            btnNext.BackgroundImage = global::WinformsExample.Properties.Resources.go_previous_rtl;
            btnReload.BackgroundImage = global::WinformsExample.Properties.Resources.reload__3_;
            btnAdd.BackgroundImage = global::WinformsExample.Properties.Resources.add__1_;
            btnDel.BackgroundImage = global::WinformsExample.Properties.Resources.delete__1_;
        }
        public void ShowUser()
        {
            tab.Controls.Clear();
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
        }
        public void ShowDefault()
        {
            tab.Controls.Clear();
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
        }
        public void ShowInboundUser()
        {
            kt = 0;
            tab.Controls.Clear();
            tab.Text = "Inbound Rules User";
            InboundForm.User = 0;
            f1 = new InboundForm();
            f1.Header(Header);
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            tab.Controls.Add(f1);
            f1.Visible = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
        }
        public void ShowOutboundUser()
        {
            kt = 1;
            tab.Controls.Clear();
            tab.Text = "Outbound Rules User";
            OutboundForm.User = 0;
            f2 = new OutboundForm();
            f2.Header(Header);
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            tab.Controls.Add(f2);
            f2.Visible = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
        }
        public void ShowInboundDefault()
        {
            kt = 0;
            tab.Controls.Clear();
            tab.Text = "Inbound Rules Default";
            InboundForm.User = 1;
            f3 = new InboundForm();
            f3.Header(Header);
            f3.TopLevel = false;
            f3.FormBorderStyle = FormBorderStyle.None;
            f3.Dock = DockStyle.Fill;
            tab.Controls.Add(f3);
            f3.Visible = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
        }
        public void ShowOutboundDefault()
        {
            kt = 1;
            tab.Controls.Clear();
            tab.Text = "Outbound Rules Default";
            OutboundForm.User = 1;
            f4 = new OutboundForm();
            f4.Header(Header);
            f4.TopLevel = false;
            f4.FormBorderStyle = FormBorderStyle.None;
            f4.Dock = DockStyle.Fill;
            tab.Controls.Add(f4);
            f4.Visible = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
        }
        public void ShowWebsiteRule()
        {
            kt = 2;
            tab.Controls.Clear();
            tab.Text = "Website blocking rules";
            f5 = new WebsiteRuleForm();
            f5.Header(Header);
            f5.TopLevel = false;
            f5.FormBorderStyle = FormBorderStyle.None;
            f5.Dock = DockStyle.Fill;
            tab.Controls.Add(f5);
            f5.Visible = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
        }
        public void LoadData()
        {
            try
            {
                switch (treeView1.SelectedNode.Name)
                {
                    case "Web":
                        {
                            Next.Add(0);
                            demnext++;
                            ShowWebsiteRule();
                            break;
                        }
                    case "User":
                        {
                            Next.Add(0);
                            demnext++;
                            ShowUser();
                            break;
                        }
                    case "Default":
                        {
                            Next.Add(3);
                            demnext++;
                            ShowDefault();
                            break;
                        }
                    case "InboundUser":
                        {
                            Next.Add(1);
                            demnext++;
                            ShowInboundUser();
                            break;
                        }
                    case "OutboundUser":
                        {
                            Next.Add(2);
                            demnext++;
                            ShowOutboundUser();
                            break;
                        }
                    case "InboundDefault":
                        {
                            Next.Add(4);
                            demnext++;
                            ShowInboundDefault();
                            break;
                        }
                    case "OutboundDefault":
                        {
                            Next.Add(5);
                            demnext++;
                            ShowOutboundDefault();
                            break;
                        }
                }
            }
            catch
            {

            }

        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnBack.BackgroundImage = global::WinformsExample.Properties.Resources.go_next_rtl;
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRuleForm.kt = kt;
            if (kt != 2)
            {
                AddRuleForm f = new AddRuleForm();
                f.ShowDialog();
            }
            else
            {
                AddRuleForm f = new AddRuleForm();
                f.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BindingList<CustomerTimer> dataSource = GetDataSource();
            string TimeTodata, TimeFromdata, NameRule, Action, Description;
            int gio = DateTime.Now.Hour;
            int phut = DateTime.Now.Minute;
            for (int i = 0; i < dataSource.Count; i++)
            {
                NameRule = dataSource[i].NameRule;
                Action = dataSource[i].Action;
                Description = dataSource[i].Description;
                TimeFromdata = dataSource[i].TimeFrom;
                TimeTodata = dataSource[i].TimeTo;
                string[] s = TimeFromdata.Split(':');
                int giofrom = int.Parse(s[0]);
                int phutfrom = int.Parse(s[1]);
                s = TimeTodata.Split(':');
                int gioto = int.Parse(s[0]);
                int phutto = int.Parse(s[1]);
                if ((gio > giofrom && gio < gioto) || (gio == giofrom && phut >= phutfrom && (gio < gioto || (gio == gioto && phut < phutto))))
                {
                    if (Action == "Allow")
                    {

                        INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                        firewallPolicy.Rules.Item(NameRule).Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
                    }
                }
                else
                {
                    if (Action == "Block")
                    {

                        INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                        firewallPolicy.Rules.Item(NameRule).Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                    }
                }
            }
        }
        public BindingList<CustomerTimer> GetDataSource()
        {
            BindingList<CustomerTimer> result = new BindingList<CustomerTimer>();
            INetFwPolicy2 firewallRule = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            foreach (INetFwRule rule in firewallRule.Rules)
            {
                string action = "";
                if (rule.Enabled == true)
                {
                    if (rule.Grouping == "Domain")
                    {
                        if (rule.Action.ToString() == "NET_FW_ACTION_ALLOW")
                        {
                            action = "Allow";
                        }
                        else
                        {
                            action = "Block";
                        }
                        string[] s = rule.Description.Split('-');
                        result.Add(new CustomerTimer()
                        {
                            NameRule = rule.Name,
                            Action = action,
                            Description = rule.Description,
                            TimeFrom = s[0],
                            TimeTo = s[1]
                        });
                    }
                }
            }
            return result;
        }
        public class CustomerTimer
        {
            public string NameRule { get; set; }
            public string Action { get; set; }
            public string Description { get; set; }
            public string TimeFrom { get; set; }
            public string TimeTo { get; set; }
        }
        public class Customer
        {
            public bool Statebool { get; set; }
            public string NameRule { get; set; }
            public string Application { get; set; }
            public string State { get; set; }
            public string Action { get; set; }
            public string Protocol { get; set; }
            public string LocalAddress { get; set; }
            public string RemoteAddress { get; set; }
            public string LocalPort { get; set; }
            public string RemotePort { get; set; }
            public string Profile { get; set; }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            switch (treeView1.SelectedNode.Name)
            {
                case "Web":
                    {

                        break;
                    }
                case "InboundUser":
                    {
                        f1.Delete();
                        ShowInboundUser();
                        break;
                    }
                case "OutboundUser":
                    {
                        break;
                    }
                case "InboundDefault":
                    {
                        break;
                    }
                case "OutboundDefault":
                    {
                        break;
                    }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            if (treeView1.Visible == true)
            {
                treeView1.Visible = false;
                Header = 1;
                LoadData();
            }
            else
            {
                treeView1.Visible = true;
                Header = 0;
                LoadData();
            }
        }
    }
}
