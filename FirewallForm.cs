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
        public FirewallForm()
        {
            InitializeComponent();
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
            InboundForm f = new InboundForm();
            f.Header(Header);
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            tab.Controls.Add(f);
            f.Visible = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
        }
        public void ShowOutboundUser()
        {
            kt = 1;
            tab.Controls.Clear();
            tab.Text = "Outbound Rules User";
            OutboundForm.User = 0;
            OutboundForm f = new OutboundForm();
            f.Header(Header);
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            tab.Controls.Add(f);
            f.Visible = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
        }
        public void ShowInboundDefault()
        {
            kt = 0;
            tab.Controls.Clear();
            tab.Text = "Inbound Rules Default";
            InboundForm.User = 1;
            InboundForm f = new InboundForm();
            f.Header(Header);
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            tab.Controls.Add(f);
            f.Visible = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
        }
        public void ShowOutboundDefault()
        {
            kt = 1;
            tab.Controls.Clear();
            tab.Text = "Outbound Rules Default";
            OutboundForm.User = 1;
            OutboundForm f = new OutboundForm();
            f.Header(Header);
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            tab.Controls.Add(f);
            f.Visible = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
        }
        public void ShowWebsiteRule()
        {
            kt = 2;
            tab.Controls.Clear();
            tab.Text = "Website blocking rules";
            WebsiteRuleForm f = new WebsiteRuleForm();
            f.Header(Header);
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            tab.Controls.Add(f);
            f.Visible = true;
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
            BindingList<Customer> dataSource = GetDataSource();
            string TimeTodata, TimeFromdata, NameRule, Action;
            int gio = DateTime.Now.Hour;
            int phut = DateTime.Now.Minute;
            dataGridView1.DataSource = dataSource;
            for (int i = 0; i < dataSource.Count; i++)
            {
                try
                {
                    NameRule = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    Action = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    TimeFromdata = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    TimeTodata = dataGridView1.Rows[i].Cells[3].Value.ToString();
                }
                catch
                {
                    continue;
                }
                string[] s = TimeFromdata.Split(':');
                int giofrom = int.Parse(s[0]);
                int phutfrom = int.Parse(s[1]);
                s = TimeTodata.Split(':');
                int gioto = int.Parse(s[0]);
                int phutto = int.Parse(s[1]);
                if ((gio > giofrom && gio < gioto) || (gio == giofrom && phut >= phutfrom && (gio < gioto || (gio == gioto && phut < phutto))))
                {
                    if(Action=="Allow")
                    {
                        //Block
                    }
                }
                else
                {
                    if(Action=="Block")
                    {
                        //Allow
                    }
                }
            }
        }
        public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
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
                        result.Add(new Customer()
                        {
                            NameRule = rule.Name,
                            Action = action,
                            TimeFrom = s[0],
                            TimeTo = s[1]
                        });
                    }
                }
            }
            return result;
        }
        public class Customer
        {
            public string NameRule { get; set; }
            public string Action { get; set; }
            public string TimeFrom { get; set; }
            public string TimeTo { get; set; }
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
