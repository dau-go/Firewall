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
        public static string _Profile;
        public static string Profile
        {
            get { return _Profile; }
            set { _Profile = value; }
        }
        public static string _State;
        public static string State
        {
            get { return _State; }
            set { _State = value; }
        }
        public static string _Action;
        public static string Action
        {
            get { return _Action; }
            set { _Action = value; }
        }
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
            treeView1.SelectedNode = treeView1.Nodes[0];
            Profile = "1";
            State = "1";
            Action = "1";
        }
        public void Showview()
        {
            btnAdd.Enabled = true;
            btnAdd.BackgroundImage = Properties.Resources.icons8_plus_24__1_;
            btnReload.Enabled = true;
            btnReload.BackgroundImage = Properties.Resources.icons8_refresh_32;
            btnDel.Enabled = true;
            btnDel.BackgroundImage = Properties.Resources.icons8_trash_24;
        }
        public void ShowUser()
        {
            tab.Controls.Clear();
            tab.Text = "";
            f = new DefaultForm();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            tab.Controls.Add(f);
            f.Visible = true;
            btnAdd.Enabled = false;
            btnAdd.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnReload.Enabled = false;
            btnReload.BackgroundImage = Properties.Resources.icons8_refresh_32__1_;
            btnDel.Enabled = false;
            btnDel.BackgroundImage = Properties.Resources.icons8_trash_24__1_;
            actionToolStripMenuItem.Enabled = false;
        }
        public void ShowDefault()
        {
            tab.Controls.Clear();
            tab.Text = "";
            f = new DefaultForm();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            tab.Controls.Add(f);
            f.Visible = true;
            btnAdd.Enabled = false;
            btnAdd.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnReload.Enabled = false;
            btnReload.BackgroundImage = Properties.Resources.icons8_refresh_32__1_;
            btnDel.Enabled = false;
            btnDel.BackgroundImage = Properties.Resources.icons8_trash_24__1_;
            actionToolStripMenuItem.Enabled = false;
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
            Showview();
            actionToolStripMenuItem.Enabled = true;
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
            Showview();
            actionToolStripMenuItem.Enabled = true;
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
            Showview();
            actionToolStripMenuItem.Enabled = true;
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
            Showview();
            actionToolStripMenuItem.Enabled = true;
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
            Showview();
            actionToolStripMenuItem.Enabled = true;
            Filterprofile.Visible = false;
        }
        public void ShowButon()
        {
            if (demback > 1)
            {
                btnBack.Enabled = true;
                btnBack.BackgroundImage = Properties.Resources.icons8_left_26__1_;
            }
            else
            {
                btnBack.Enabled = false;
                btnBack.BackgroundImage = Properties.Resources.icons8_left_26;
            }
            if (demnext > 0)
            {
                btnNext.Enabled = true;
                btnNext.BackgroundImage = Properties.Resources.icons8_right_26;
            }
            else
            {
                btnNext.Enabled = false;
                btnNext.BackgroundImage = Properties.Resources.icons8_right_26__1_;
            }
        }
        public void LoadData()
        {
            switch (treeView1.SelectedNode.Name)
            {
                case "Web":
                    {
                        if (demback >= Back.Count)
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
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
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
            if (demnext >= Next.Count)
            {
                Next.Add(Back[demback]);
            }
            else
            {
                Next[demnext] = Back[demback];
            }
            if (Back[demback - 1] == 0 || Back[demback - 1] == 3 || Back[demback - 1] == 6)
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
            else if (Back[demback - 1] == 1 || Back[demback - 1] == 2)
            {
                treeView1.SelectedNode = treeView1.Nodes[0].Nodes[Back[demback - 1] - 1];
            }
            else
            {
                treeView1.SelectedNode = treeView1.Nodes[1].Nodes[Back[demback - 1] - 4];
            }
            demnext++;
            demback--;
            ShowButon();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            demnext--;
            if (Next[demnext] == 0 || Next[demnext] == 3 || Next[demnext] == 6)
            {
                if (Next[demnext] == 0)
                {
                    treeView1.SelectedNode = treeView1.Nodes[0];
                }
                if (Next[demnext] == 3)
                {
                    treeView1.SelectedNode = treeView1.Nodes[1];
                }
                if (Next[demnext] == 6)
                {
                    treeView1.SelectedNode = treeView1.Nodes[2];
                }
            }
            else if (Next[demnext] == 1 || Next[demnext] == 2)
            {
                treeView1.SelectedNode = treeView1.Nodes[0].Nodes[Next[demnext] - 1];
            }
            else
            {
                treeView1.SelectedNode = treeView1.Nodes[1].Nodes[Next[demnext] - 4];
            }
            ShowButon();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Reload()
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

        private void menuReload_Click(object sender, EventArgs e)
        {
            Reload();
        }
        public void FilterProfile()
        {
            ShowAllProfile.Checked = false;
            if (Domain.Checked == true)
            {
                if (Private.Checked == true)
                {
                    if (Public.Checked == true)
                    {
                        Profile = "1";
                    }
                    else
                    {
                        Profile = "Domain,Private";
                    }
                }
                else
                {
                    if (Public.Checked == true)
                    {
                        Profile = "Domain,Public";
                    }
                    else
                    {
                        Profile = "Domain";
                    }
                }
            }
            else if (Private.Checked == true)
            {
                if (Public.Checked == true)
                {
                    Profile = "Private,Public";
                }
                else
                {
                    Profile = "Private";
                }
            }
            else
            {
                Profile = "Public";
            }
        }

        private void ShowAllProfile_Click_1(object sender, EventArgs e)
        {
            Profile = "1";
            ShowAllProfile.Checked = true;
            Domain.Checked = false;
            Private.Checked = false;
            Public.Checked = false;
            Reload();
        }

        private void menuadd_Click_1(object sender, EventArgs e)
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

        private void Domian_Click(object sender, EventArgs e)
        {
            if (Domain.Checked == true)
            {
                if (Private.Checked == true || Public.Checked == true)
                {
                    Domain.Checked = false;
                }
            }
            else
            {
                Domain.Checked = true;
            }
            FilterProfile();
            Reload();
        }

        private void Private_Click(object sender, EventArgs e)
        {
            if (Private.Checked == true)
            {
                if (Domain.Checked == true || Public.Checked == true)
                {
                    Private.Checked = false;
                }
            }
            else
            {
                Private.Checked = true;
            }
            FilterProfile();
            Reload();
        }

        private void Public_Click(object sender, EventArgs e)
        {
            if (Public.Checked == true)
            {
                if (Domain.Checked == true || Private.Checked == true)
                {
                    Public.Checked = false;
                }
            }
            else
            {
                Public.Checked = true;
            }
            FilterProfile();
            Reload();
        }

        private void ShowAllState_Click(object sender, EventArgs e)
        {
            ShowAllState.Checked = true;
            Enabled.Checked = false;
            Disabled.Checked = false;
            State = "1";
            Reload();
        }

        private void Enabled_Click(object sender, EventArgs e)
        {
            ShowAllState.Checked = false;
            if(Enabled.Checked==false)
            {
                Enabled.Checked = true;
                Disabled.Checked = false;
            }
            State = "Yes";
            Reload();
        }

        private void Disabled_Click(object sender, EventArgs e)
        {
            ShowAllState.Checked = false;
            if (Disabled.Checked == false)
            {
                Enabled.Checked = false;
                Disabled.Checked = true;
            }
            State = "No";
            Reload();
        }

        private void ShowAllAction_Click(object sender, EventArgs e)
        {
            ShowAllAction.Checked = true;
            Allow.Checked = false;
            Block.Checked = false;
            Action = "1";
            Reload();
        }

        private void Allow_Click(object sender, EventArgs e)
        {
            ShowAllAction.Checked = false;
            if (Allow.Checked == false)
            {
                Allow.Checked = true;
                Block.Checked = false;
            }
            Action = "Allow";
            Reload();
        }

        private void Block_Click(object sender, EventArgs e)
        {
            ShowAllAction.Checked = false;
            if (Block.Checked == false)
            {
                Allow.Checked = false;
                Block.Checked = true;
            }
            Action = "Block";
            Reload();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Profile = "1";
            State = "1";
            Action = "1";
            Reload();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
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
