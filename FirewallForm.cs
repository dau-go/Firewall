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
        public FirewallForm()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnBack, "Navigate Backward");
            toolTip1.SetToolTip(btnNext, "Navigate Forward");
            toolTip1.SetToolTip(btnTree, "Show/Hide Console Tree");
            toolTip1.SetToolTip(btnReload, "Refresh Rule");
            toolTip1.SetToolTip(btnAdd, "Add New Rule");
            toolTip1.SetToolTip(btnDel, "Delete Rule");
        }
        public void LoadData()
        {
            switch (treeView1.SelectedNode.Name)
            {
                case "InboundUser":
                    {
                        tab.Controls.Clear();
                        tab.Text = "Inbound Rules User";
                        InboundForm f = new InboundForm(0);
                        //f.Loaddata(1);
                        f.TopLevel = false;
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.Dock = DockStyle.Fill;
                        tab.Controls.Add(f);
                        f.Visible = true;
                        break;
                    }
                case "OutboundUser":
                    {
                        tab.Controls.Clear();
                        tab.Text = "Outbound Rules User";
                        OutboundForm f = new OutboundForm(0);
                        f.TopLevel = false;
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.Dock = DockStyle.Fill;
                        tab.Controls.Add(f);
                        f.Visible = true;
                        break;
                    }
                case "InboundDefault":
                    {
                        tab.Controls.Clear();
                        tab.Text = "Inbound Rules Default";
                        InboundForm f = new InboundForm(1);
                        f.TopLevel = false;
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.Dock = DockStyle.Fill;
                        tab.Controls.Add(f);
                        f.Visible = true;
                        break;
                    }
                case "OutboundDefault":
                    {
                        tab.Controls.Clear();
                        tab.Text = "Outbound Rules Default";
                        OutboundForm f = new OutboundForm(1);
                        f.TopLevel = false;
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.Dock = DockStyle.Fill;
                        tab.Controls.Add(f);
                        f.Visible = true;
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

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            if(treeView1.Visible==true)
            {
                treeView1.Visible = false;
                InboundForm
                
            }
            else
            {
                treeView1.Visible = true;
            }
        }
    }
}
