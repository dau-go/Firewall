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
    public partial class RuleIPForm : Form
    {
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
        private static string _IPFocus;
        public static string IPFocus
        {
            get { return _IPFocus; }
            set { _IPFocus = value; }
        }
        public RuleIPForm()
        {
            InitializeComponent();
        }
        private void GetIPLocal()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (i == 0)
                {
                    AddRuleForm.LocalIP = listView1.Items[0].Text;
                }
                else
                {
                    AddRuleForm.LocalIP = AddRuleForm.LocalIP + "," + listView1.Items[i].Text;
                }
            }
        }
        private void GetIPRemote()
        {
            for (int i = 0; i < listView2.Items.Count; i++)
            {
                if (i == 0)
                {
                    AddRuleForm.RemoteIP = listView2.Items[0].Text;
                }
                else
                {
                    AddRuleForm.RemoteIP = AddRuleForm.RemoteIP + "," + listView2.Items[i].Text;
                }
            }
        }
        //Local IP
        private void rbAllLocal_CheckedChanged(object sender, EventArgs e)
        {
            AddRuleForm.LocalIP = "Any";
            listView1.Enabled = false;
            btnAddLocal.Enabled = false;
            btnEditLocal.Enabled = false;
            btnDelLocal.Enabled = false;
        }

        private void rbIPLocal_CheckedChanged(object sender, EventArgs e)
        {
            AddRuleForm.LocalIP = "";
            listView1.Enabled = true;
            btnAddLocal.Enabled = true;
        }

        private void btnAddLocal_Click(object sender, EventArgs e)
        {
            AddIPForm f = new AddIPForm(0);
            f.ShowDialog();
            if (_LocalIP != "" || _LocalIP == null)
            {
                listView1.Items.Add(_LocalIP);
            }
            GetIPLocal();
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            btnEditLocal.Enabled = true;
            btnDelLocal.Enabled = true;
            _IPFocus = listView1.FocusedItem.Text;
        }

        private void btnEditLocal_Click(object sender, EventArgs e)
        {
            AddIPForm f = new AddIPForm(2);
            f.ShowDialog();
            listView1.Items[listView1.FocusedItem.Index].Text = _LocalIP;
            GetIPLocal();
        }
        private void btnDelLocal_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.FocusedItem);
            GetIPLocal();
        }
        //Remote IP

        private void rbAllRemote_CheckedChanged(object sender, EventArgs e)
        {
            AddRuleForm.RemoteIP = "Any";
            listView2.Enabled = false;
            btnAddRemote.Enabled = false;
            btnEditRemote.Enabled = false;
            btnDelRemote.Enabled = false;
        }
        private void rbIPRemote_CheckedChanged(object sender, EventArgs e)
        {
            AddRuleForm.RemoteIP = "";
            listView2.Enabled = true;
            btnAddRemote.Enabled = true;
        }

        private void btnAddRemote_Click(object sender, EventArgs e)
        {
            AddIPForm f = new AddIPForm(1);
            f.ShowDialog();
            if (_RemoteIP != "" || _RemoteIP == null)
            {
                listView2.Items.Add(_RemoteIP);
            }
            GetIPRemote();
        }

        private void btnEditRemote_Click(object sender, EventArgs e)
        {
            AddIPForm f = new AddIPForm(3);
            f.ShowDialog();
            listView2.Items[listView2.FocusedItem.Index].Text = _RemoteIP;
            GetIPRemote();
        }

        private void btnDelRemote_Click(object sender, EventArgs e)
        {
            listView2.Items.Remove(listView2.FocusedItem);
            GetIPRemote();
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            btnEditRemote.Enabled = true;
            btnDelRemote.Enabled = true;
            _IPFocus = listView2.FocusedItem.Text;
        }
    }
}
