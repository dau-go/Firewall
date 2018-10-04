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
    public partial class RuleProtocolForm : Form
    {
        public RuleProtocolForm()
        {
            InitializeComponent();
            cbProtocol.SelectedIndex = 0;
            cbLocalport.SelectedIndex = 0;
            cbRemoteport.SelectedIndex = 0;
            Getdata();
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
            label1.Text = "Quy tắc này áp dụng cho các cổng và giao thức nào?";
            label2.Text = "Loại giao thức:";
            label3.Text = "Cổng từ xa";
            label4.Text = "Ví dụ: 80,443, ...";
            label5.Text = "Cổng nội bộ:";
            label6.Text = "Ví dụ: 80,443, ...";
        }
        public void ShowEnglish()
        {
            label1.Text = "To which ports and protocols does this rule apply?";
            label2.Text = "Protocol type:";
            label3.Text = "Remote port:";
            label4.Text = "Example: 80,443,...";
            label5.Text = "Local port:";
            label6.Text = "Example: 80,443,...";
        }
        public void Getdata()
        {
            switch (cbProtocol.Text)
            {
                case "Any":
                    {
                        AddRuleForm.Protocol = 256;
                        break;
                    }
                case "HOPOPT":
                    {
                        AddRuleForm.Protocol = 0;
                        break;
                    }
                case "ICMPv4":
                    {
                        AddRuleForm.Protocol = 1;
                        break;
                    }
                case "IGMP":
                    {
                        AddRuleForm.Protocol = 2;
                        break;
                    }
                case "TCP":
                    {
                        AddRuleForm.Protocol = 6;
                        break;
                    }
                case "UDP":
                    {
                        AddRuleForm.Protocol = 17;
                        break;
                    }
                case "IPv6":
                    {
                        AddRuleForm.Protocol = 41;
                        break;
                    }
                case "IPv6-Route":
                    {
                        AddRuleForm.Protocol = 43;
                        break;
                    }
                case "IPv6-Frag":
                    {
                        AddRuleForm.Protocol = 44;
                        break;
                    }
                case "GRE":
                    {
                        AddRuleForm.Protocol = 47;
                        break;
                    }
                case "ICMPv6":
                    {
                        AddRuleForm.Protocol = 58;
                        break;
                    }
                case "IPv6-NoNxt":
                    {
                        AddRuleForm.Protocol = 59;
                        break;
                    }
                case "IPv6-Opts":
                    {
                        AddRuleForm.Protocol = 60;
                        break;
                    }
                case "VRRP":
                    {
                        AddRuleForm.Protocol = 112;
                        break;
                    }
                case "PGM":
                    {
                        AddRuleForm.Protocol = 113;
                        break;
                    }
                case "L2TP":
                    {
                        AddRuleForm.Protocol = 115;
                        break;
                    }
            }
            if (cbLocalport.Text == "All Ports")
            {
                AddRuleForm.LocalPort = "Any";
            }
            else
            {
                AddRuleForm.LocalPort = txtLocalport.Text;
            }
            if (cbRemoteport.Text == "All Ports")
            {
                AddRuleForm.RemotePort = "Any";
            }
            else
            {
                AddRuleForm.RemotePort = txtLocalport.Text;
            }
        }
        private void cbProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProtocol.Text == "TCP" || cbProtocol.Text == "UDP")
            {
                cbLocalport.Enabled = true;
                cbRemoteport.Enabled = true;
            }
            else
            {
                cbLocalport.Enabled = false;
                cbLocalport.SelectedIndex = 0;
                cbRemoteport.Enabled = false;
                cbRemoteport.SelectedIndex = 0;
                txtLocalport.Enabled = false;
                txtRemoteport.Enabled = false;
                txtLocalport.Text = "";
                txtRemoteport.Text = "";
            }
            Getdata();
        }

        private void cboLocalport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocalport.Text != "All Ports")
            {
                txtLocalport.Enabled = true;
            }
            else
            {
                txtLocalport.Enabled = false;
                txtLocalport.Text = "";
            }
        }

        private void cbRemoteport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRemoteport.Text != "All Ports")
            {
                txtRemoteport.Enabled = true;
            }
            else
            {
                txtRemoteport.Enabled = false;
                txtRemoteport.Text = "";
            }
        }

        private void txtLocalport_TextChanged(object sender, EventArgs e)
        {
            Getdata();
        }
    }
}
