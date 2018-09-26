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
            }
            Getdata();
        }

        private void cboLocalport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocalport.Text != "All Ports")
            {
                txtLocalport.Enabled = true;
            }
        }

        private void cbRemoteport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRemoteport.Text != "All Ports")
            {
                txtRemoteport.Enabled = true;
            }
        }

        private void txtLocalport_TextChanged(object sender, EventArgs e)
        {
            Getdata();
        }
    }
}
