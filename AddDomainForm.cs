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
        public AddDomainForm()
        {
            InitializeComponent();
            int Hour = DateTime.Now.Hour;
            int HourTo = Hour + 1;
            int Minute = DateTime.Now.Minute;
            if (Hour <= 12)
            {
                cbHourFrom.Text = Hour.ToString();
                cbAPFrom.Text = "AM";
            }
            else
            {
                cbHourFrom.Text = (Hour - 12).ToString();
                cbAPFrom.Text = "PM";
            }
            if (HourTo <= 12)
            {
                cbHourTo.Text = HourTo.ToString();
                cbAPTo.Text = "AM";
            }
            else
            {
                cbHourTo.Text = (HourTo - 12).ToString();
                cbAPTo.Text = "PM";
            }
            cbMinuteFrom.Text = Minute.ToString();
            cbMinuteTo.Text = Minute.ToString();
        }
        public string Description()
        {
            string s = cbHourFrom.Text + "/" + cbMinuteFrom.Text + " " + cbAPFrom.Text;
            string s1 = cbHourTo.Text + "/" + cbMinuteTo.Text + " " + cbAPTo.Text;
            return s + "-" + s1;
        }
        public string IP()
        {
            string host = txtName.Text;

            IPHostEntry e = Dns.GetHostEntry(host);

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
            return s;
        }
        public void Finish()
        {
            Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);

            // Let's create a new rule
            INetFwRule2 inboundRule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            inboundRule.Enabled = true;
            inboundRule.Name = txtName.Text;
            inboundRule.Description = Description();
            inboundRule.RemoteAddresses = IP();
            inboundRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Add(inboundRule);
        }
    }
}
