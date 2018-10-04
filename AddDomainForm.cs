using NetFwTypeLib;
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
    public partial class AddDomainForm : Form
    {
        string IP;
        public AddDomainForm()
        {
            InitializeComponent();
            cbHourFrom.Text = DateTime.Now.Hour.ToString();
            cbHourTo.Text = (DateTime.Now.Hour + 1).ToString();
            cbMinuteFrom.Text = "00";
            cbMinuteTo.Text = "00";
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
            label1.Text = "Trang Web";
            label2.Text = "Thời Gian Từ";
            label3.Text = "Thời Gian Đến";
            label4.Text = "Giờ";
            label5.Text = "Giờ";
            label6.Text = "Phút";
            label7.Text = "Phút";
        }
        public void ShowEnglish()
        {
            label1.Text = "Website:";
            label2.Text = "Time From:";
            label3.Text = "Time To:";
            label4.Text = "Hour";
            label5.Text = "Hour";
            label6.Text = "Minute";
            label7.Text = "Minute";
        }
        public bool Time()
        {
            int giofrom = int.Parse(cbHourFrom.Text);
            int phutfrom = int.Parse(cbMinuteFrom.Text);
            int gioto = int.Parse(cbHourTo.Text);
            int phutto = int.Parse(cbMinuteTo.Text);
            if (giofrom > gioto)
            {
                return false;
            }
            else if (giofrom == gioto && phutfrom > phutto)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string Description()
        {
            string s = cbHourFrom.Text + ":" + cbMinuteFrom.Text;
            string s1 = cbHourTo.Text + ":" + cbMinuteTo.Text;
            return s + "-" + s1;
        }
        public bool CheckIP()
        {
            string host = txtName.Text;
            if (host == "") return false;
            IPHostEntry e;
            try
            {
                e = Dns.GetHostEntry(host);
            }
            catch
            {
                return false;
            }
            // Danh sách điạ chỉ IP
            int j = 0;
            string s = "";
            foreach (IPAddress i in e.AddressList)
            {
                if (j == 0)
                {
                    s = i.ToString();
                    j++;
                }
                else
                {
                    s = s + "," + i.ToString();
                }
            }
            IP = s;
            return true;
        }
        public void Finish()
        {
            Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);

            // Let's create a new rule
            INetFwRule2 inboundRule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            inboundRule.Enabled = true;
            int gio = DateTime.Now.Hour;
            int phut = DateTime.Now.Minute;
            int giofrom = int.Parse(cbHourFrom.Text);
            int phutfrom = int.Parse(cbMinuteFrom.Text);
            int gioto = int.Parse(cbHourTo.Text);
            int phutto = int.Parse(cbMinuteTo.Text);
            if ((gio > giofrom && gio < gioto) || (gio == giofrom && phut >= phutfrom && (gio < gioto || (gio == gioto && phut < phutto))))
            {
                inboundRule.Action = 0;
            }
            if (Time() == true)
            {
                inboundRule.Description = Description();
                inboundRule.Name = txtName.Text + "(" + inboundRule.Description + ")";
            }
            else
            {
                if (FirewallForm.Lang == 0)
                {
                    MessageBox.Show("Thời gian không hợp lệ", "Tường Lửa");
                }
                else
                {
                    MessageBox.Show("Invalid time", "Firewall");
                }
                inboundRule.RemoteAddresses = "Eror";
            }
            if (CheckIP() == true)
            {
                inboundRule.RemoteAddresses = IP;
            }
            else
            {
                if (FirewallForm.Lang == 0)
                {
                    MessageBox.Show("Tên trang web không hợp lệ", "Tường Lửa");
                }
                else
                {
                    MessageBox.Show("Website name is not valid", "Firewall");
                }
                inboundRule.RemoteAddresses = "Eror";
            }
            int ktname = 0;
            var firewallRule = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            foreach (INetFwRule rule in firewallRule.Rules)
            {
                if (inboundRule.Name == rule.Name)
                {
                    ktname = 1;
                    break;
                }
            }
            if (ktname == 1)
            {
                if (FirewallForm.Lang == 0)
                {
                    MessageBox.Show("Quy tắc đã tồn tại", "Tường Lửa");
                }
                else
                {
                    MessageBox.Show("Rule already exists", "Firewall");
                }
                inboundRule.RemoteAddresses = "Eror";
            }
            inboundRule.Grouping = "Domain";
            inboundRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Add(inboundRule);
        }
    }
}
