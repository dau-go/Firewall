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
        }
        TabPage tab1 = new TabPage();
        TabPage tab2 = new TabPage();
        private void Remove()
        {
            tabControl1.TabPages.Remove(tab1);
            tabControl1.TabPages.Remove(tab2);
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (treeView1.SelectedNode.Name)
            {
                case "Inbound":
                    {
                        Remove();
                        tab1.Text = "Inbound Rules";
                        InboundForm f = new InboundForm();
                        f.TopLevel = false;
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.Dock = DockStyle.Fill;
                        tab1.Controls.Add(f);
                        f.Visible = true;
                        tabControl1.TabPages.Add(tab1);
                        break;
                    }
                case "Outbound":
                    {
                        Remove();
                        tab2.Text = "Outbound Rules";
                        OutboundForm f = new OutboundForm();
                        f.TopLevel = false;
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.Dock = DockStyle.Fill;
                        tab2.Controls.Add(f);
                        f.Visible = true;
                        tabControl1.TabPages.Add(tab2);
                        break;
                    }
            }
        }
    }
}
