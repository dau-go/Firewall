using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WinformsExample
{
    public partial class AddIPForm : Form
    {
        int k = 0;
        public AddIPForm(int i)
        {
            InitializeComponent();
            k = i;
            if (k == 2)
            {
                ShowIP();
                k = 0;
            }
            if (k == 3)
            {
                ShowIP();
                k = 1;
            }
        }
        public void ShowIP()
        {
            if (RuleIPForm.IPFocus.Contains("-") == false)
            {
                txtSubnet.Text = RuleIPForm.IPFocus;
            }
            else
            {
                radioButton2.Checked = true;
                string[] s = RuleIPForm.IPFocus.Split('-');
                txtFrom.Text = s[0];
                txtTo.Text = s[1];
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtSubnet.Enabled = true;
            txtFrom.Enabled = false;
            txtTo.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtSubnet.Enabled = false;
            txtFrom.Enabled = true;
            txtTo.Enabled = true;
        }
        public bool ValidateIPv4Subnet()
        {
            if (txtSubnet.Text == null)
            {
                return false;
            }

            string[] splitValues = txtSubnet.Text.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }
            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }
        public bool ValidateIPv4Range()
        {
            if (txtFrom.Text == null || txtTo.Text == null)
            {
                return false;
            }

            string[] splitValues = txtFrom.Text.Split('.');
            string[] splitValues1 = txtTo.Text.Split('.');
            if (splitValues.Length != 4 || splitValues1.Length != 4)
            {
                return false;
            }
            for (int i = 0; i < 3; i++)
            {
                if (splitValues[i] != splitValues1[i])
                {
                    return false;
                }
            }
            if (int.Parse(splitValues[3]) >= int.Parse(splitValues1[3]))
            {
                return false;
            }
            byte tempForParsing;
            try
            {
                splitValues.All(r => byte.TryParse(r, out tempForParsing));
                splitValues1.All(r => byte.TryParse(r, out tempForParsing));
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (ValidateIPv4Subnet() == true)
                {
                    if (k == 0)
                    {
                        RuleIPForm.LocalIP = txtSubnet.Text;
                    }
                    else
                    {
                        RuleIPForm.RemoteIP = txtSubnet.Text;
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You must specify a valid address.", "Firewall");
                }
            }
            else
            {
                if (ValidateIPv4Range() == true)
                {

                    if (k == 0)
                    {
                        RuleIPForm.LocalIP = txtFrom.Text + "-" + txtTo.Text;
                    }
                    else
                    {
                        RuleIPForm.RemoteIP = txtFrom.Text + "-" + txtTo.Text;
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You must specify a valid address.", "Firewall");
                }
            }
        }
    }
}
