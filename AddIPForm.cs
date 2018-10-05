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
        int k = 0, k1 = 0;
        //k la kiem tra local hay remote, add hay edit
        //k1 la kiem tra form goi ham
        public AddIPForm(int i, int j)
        {
            InitializeComponent();
            k = i; k1 = j;
            if (k == 2)//edit Local IP
            {
                ShowIP();
                k = 0;//Add Local IP
            }
            if (k == 3)//edit Remote IP
            {
                ShowIP();
                k = 1;//Add Remote IP
            }

            if (FirewallForm.Lang == 0)
            {
                ShowTiengViet();
            }
            else
            {
                ShowEnglish();
            }
        }
        public void ShowTiengViet()
        {
            Text = "Địa Chỉ IP";
            label1.Text = "Xác định địa chỉ IP để phù hợp với:";
            label2.Text = "Ví Dụ:  192.168.0.12" + "\n" + "             192.168.0.0";
            label3.Text = "Từ:";
            label4.Text = "Đến:";
        }
        public void ShowEnglish()
        {
            Text = "IP Address";
            label1.Text = "Specify the IP address to match:";
            label2.Text = "Examples:  192.168.0.12" + "\n" + "                  192.168.0.0";
            label3.Text = "From:";
            label4.Text = "To:";
        }
        public void ShowIP()
        {
            if (RuleIPForm.IPFocus.Contains("-") == false)
            {
                if (k1 == 0)
                {
                    txtSubnet.Text = RuleIPForm.IPFocus;
                }
                else
                {
                    txtSubnet.Text = EditForm.IPFocus;
                }
            }
            else
            {
                radioButton2.Checked = true;
                string[] s;
                if (k1 == 0)
                {
                    s = RuleIPForm.IPFocus.Split('-');
                }
                else
                {
                    s = EditForm.IPFocus.Split('-');
                }
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
                        if (k1 == 0)
                        {
                            RuleIPForm.LocalIP = txtSubnet.Text;
                        }
                        else
                        {
                            EditForm.LocalIP = txtSubnet.Text;
                        }
                    }
                    else
                    {
                        if (k1 == 0)
                        {
                            RuleIPForm.RemoteIP = txtSubnet.Text;
                        }
                        else
                        {
                            EditForm.RemoteIP = txtSubnet.Text;
                        }
                    }
                    this.Close();
                }
                else
                {
                    if (FirewallForm.Lang == 0)
                    {
                        MessageBox.Show("Bạn phải chỉ định địa chỉ hợp lệ.", "Tường Lửa");
                    }
                    else
                    {
                        MessageBox.Show("You must specify a valid address.", "Firewall");
                    }
                }
            }
            else
            {
                if (ValidateIPv4Range() == true)
                {

                    if (k == 0)
                    {
                        if (k1 == 0)
                        {
                            RuleIPForm.LocalIP = txtFrom.Text + "-" + txtTo.Text;
                        }
                        else
                        {
                            EditForm.LocalIP = txtFrom.Text + "-" + txtTo.Text;
                        }
                    }
                    else
                    {
                        if (k1 == 0)
                        {
                            RuleIPForm.RemoteIP = txtFrom.Text + "-" + txtTo.Text;
                        }
                        else
                        {
                            EditForm.RemoteIP = txtFrom.Text + "-" + txtTo.Text;
                        }
                    }
                    this.Close();
                }
                else
                {
                    if (FirewallForm.Lang == 0)
                    {
                        MessageBox.Show("Bạn phải chỉ định địa chỉ hợp lệ.", "Tường Lửa");
                    }
                    else
                    {
                        MessageBox.Show("You must specify a valid address.", "Firewall");
                    }
                }
            }
        }
    }
}
