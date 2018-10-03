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
        DefaultForm f;
        InboundForm f1;
        OutboundForm f2;
        InboundForm f3;
        OutboundForm f4;
        WebsiteRuleForm f5;
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
            treeView1.SelectedNode = treeView1.Nodes[0];
        }
        public void ShowUser()
        {
            tab.Controls.Clear();
            tab.Text = "1";
            f = new DefaultForm();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            tab.Controls.Add(f);
            f.Visible = true;
            btnAdd.Enabled = false;
            btnReload.Enabled = false;
            btnDel.Enabled = false;

        }
        public void ShowDefault()
        {
            tab.Controls.Clear();
            tab.Text = "2";
            f = new DefaultForm();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            tab.Controls.Add(f);
            f.Visible = true;
            btnAdd.Enabled = false;
            btnReload.Enabled = false;
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
            btnReload.Enabled = true;
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
            btnReload.Enabled = true;
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
            btnReload.Enabled = true;
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
            btnReload.Enabled = true;
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
            btnReload.Enabled = true;
            btnDel.Enabled = true;
        }
        public void ShowButon()
        {
            if (demback > 1)
            {
                btnBack.Enabled = true;
            }
            else
            {
                btnBack.Enabled = false;
            }
            if (demnext > 0)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }
        }
        public void LoadData()
        {
            try
            {
                switch (treeView1.SelectedNode.Name)
                {
                    case "Web":
                        {
                            if(demback>=Back.Count)
                            {
                                Back.Add(6);
                                demback++;
                            }
                            else
                            {
                                Back[demback] = 6;
                                demback++;
                            }
                            ShowWebsiteRule();
                            ShowButon();
                            break;
                        }
                    case "User":
                        {
                            if (demback >= Back.Count)
                            {
                                Back.Add(0);
                                demback++;
                            }
                            else
                            {
                                Back[demback] = 0;
                                demback++;
                            }
                            ShowUser();
                            ShowButon();
                            break;
                        }
                    case "Default":
                        {
                            if (demback >= Back.Count)
                            {
                                Back.Add(3);
                                demback++;
                            }
                            else
                            {
                                Back[demback] = 3;
                                demback++;
                            }
                            ShowDefault();
                            ShowButon();
                            break;
                        }
                    case "InboundUser":
                        {
                            if (demback >= Back.Count)
                            {
                                Back.Add(1);
                                demback++;
                            }
                            else
                            {
                                Back[demback] = 1;
                                demback++;
                            }
                            ShowInboundUser();
                            ShowButon();
                            break;
                        }
                    case "OutboundUser":
                        {
                            if (demback >= Back.Count)
                            {
                                Back.Add(2);
                                demback++;
                            }
                            else
                            {
                                Back[demback] = 2;
                                demback++;
                            }
                            ShowOutboundUser();
                            ShowButon();
                            break;
                        }
                    case "InboundDefault":
                        {
                            if (demback >= Back.Count)
                            {
                                Back.Add(4);
                                demback++;
                            }
                            else
                            {
                                Back[demback] = 4;
                                demback++;
                            }
                            ShowInboundDefault();
                            ShowButon();
                            break;
                        }
                    case "OutboundDefault":
                        {
                            if (demback >= Back.Count)
                            {
                                Back.Add(5);
                                demback++;
                            }
                            else
                            {
                                Back[demback] = 5;
                                demback++;
                            }
                            ShowOutboundDefault();
                            ShowButon();
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
                        f5.Delete();
                        ShowWebsiteRule();
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
                        f2.Delete();
                        ShowOutboundUser();
                        break;
                    }
                case "InboundDefault":
                    {
                        f3.Delete();
                        ShowInboundDefault();
                        break;
                    }
                case "OutboundDefault":
                    {
                        f4.Delete();
                        ShowOutboundDefault();
                        break;
                    }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            demback--;
            if(Back[demback-1]==0|| Back[demback - 1] == 3 || Back[demback - 1] == 6)
            {
                if (Back[demback - 1] == 0)
                {
                    treeView1.SelectedNode = treeView1.Nodes[0];
                }
                if (Back[demback - 1] == 3)
                {
                    treeView1.SelectedNode = treeView1.Nodes[1];
                }
                if (Back[demback - 1] == 6)
                {
                    treeView1.SelectedNode = treeView1.Nodes[2];
                }
            }
            else if(Back[demback-1]==1||Back[demback - 1] == 2)
            {
                treeView1.SelectedNode = treeView1.Nodes[0].Nodes[Back[demback-1]-1];
            }
            else
            {
                treeView1.SelectedNode = treeView1.Nodes[1].Nodes[Back[demback - 1]-4];
            }
            if(demnext>=Next.Count)
            {
                Next.Add(Back[demback - 1]);
            }
            else
            {
                Next[demnext] = Back[demback - 1];
            }
            demnext++;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            demnext--;
            if (Next[demnext - 1] == 0 || Next[demnext - 1] == 3 || Next[demnext - 1] == 6)
            {
                if (Next[demnext - 1] == 0)
                {
                    treeView1.SelectedNode = treeView1.Nodes[0];
                }
                if (Next[demnext - 1] == 3)
                {
                    treeView1.SelectedNode = treeView1.Nodes[1];
                }
                if (Next[demnext - 1] == 6)
                {
                    treeView1.SelectedNode = treeView1.Nodes[2];
                }
            }
            else if (Next[demnext - 1] == 1 || Next[demnext - 1] == 2)
            {
                treeView1.SelectedNode = treeView1.Nodes[0].Nodes[Next[demnext - 1] - 1];
            }
            else
            {
                treeView1.SelectedNode = treeView1.Nodes[1].Nodes[Next[demnext - 1] - 4];
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            switch (treeView1.SelectedNode.Name)
            {
                case "Web":
                    {
                        ShowWebsiteRule();
                        break;
                    }
                case "InboundUser":
                    {
                        ShowInboundUser();
                        break;
                    }
                case "OutboundUser":
                    {
                        ShowOutboundUser();
                        break;
                    }
                case "InboundDefault":
                    {
                        ShowInboundDefault();
                        break;
                    }
                case "OutboundDefault":
                    {
                        ShowOutboundDefault();
                        break;
                    }
            }
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
