using NetFwTypeLib;
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
    public partial class InboundForm : Form
    {
        int t = 0;
        BindingList<Customer> dataSource;
        public InboundForm(int i)
        {
            InitializeComponent();
            t = i;
            dataSource = GetDataSource();
            dataGridView1.DataSource = dataSource;
        }
        public void Header(int i)
        {
            if(i==0)
            {
                dataGridView1.Columns["Statebool"].HeaderText = "";
                dataGridView1.Columns["Statebool"].Width = 20;
                dataGridView1.Columns["NameRule"].Width = 220;
                dataGridView1.Columns["NameRule"].HeaderText = "Name Rules";
                dataGridView1.Columns["Application"].Width = 155;
                dataGridView1.Columns["Application"].HeaderText = "Application Package";
                dataGridView1.Columns["State"].Width = 50;
                dataGridView1.Columns["Action"].Width = 50;
                dataGridView1.Columns["LocalAddress"].HeaderText = "Local Address";
                dataGridView1.Columns["LocalAddress"].Width = 110;
                dataGridView1.Columns["RemoteAddress"].HeaderText = "Remote Address";
                dataGridView1.Columns["RemoteAddress"].Width = 110;
                dataGridView1.Columns["LocalPort"].HeaderText = "Local Port";
                dataGridView1.Columns["LocalPort"].Width = 110;
                dataGridView1.Columns["RemotePort"].HeaderText = "Remote Port";
                dataGridView1.Columns["RemotePort"].Width = 110;
                dataGridView1.Columns["Profile"].Width = 120;
            }
        }
        public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            var firewallRule = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            foreach (INetFwRule rule in firewallRule.Rules)
            {
                string state = "", action = "", app = "", protocol = "", localAddress = "", remoteAddress = "", localport = "", remoteport = "", profile = "";
                if (t == 0)
                {
                    if (rule.Direction.ToString() == "NET_FW_RULE_DIR_IN")
                    {
                        if (rule.Grouping == null)
                        {
                            if (rule.Enabled == true)
                            {
                                state = "Yes";
                            }
                            else
                            {
                                state = "No";
                            }
                            if (rule.Action.ToString() == "NET_FW_ACTION_ALLOW")
                            {
                                action = "Allow";
                            }
                            else
                            {
                                action = "Block";
                            }
                            if (rule.ApplicationName == null)
                            {
                                app = "Any";
                            }
                            else
                            {
                                app = rule.ApplicationName;
                            }
                            switch (rule.Protocol)
                            {
                                case 256:
                                    {
                                        protocol = "Any";
                                        break;
                                    }
                                case 1:
                                    {
                                        protocol = "ICMPv4";
                                        break;
                                    }
                                case 2:
                                    {
                                        protocol = "IGMP";
                                        break;
                                    }
                                case 6:
                                    {
                                        protocol = "TCP";
                                        break;
                                    }
                                case 17:
                                    {
                                        protocol = "UDP";
                                        break;
                                    }
                                case 41:
                                    {
                                        protocol = "IPv6";
                                        break;
                                    }
                                case 43:
                                    {
                                        protocol = "IPv6-Route";
                                        break;
                                    }
                                case 44:
                                    {
                                        protocol = "IPv6-Frag";
                                        break;
                                    }
                                case 47:
                                    {
                                        protocol = "GRE";
                                        break;
                                    }
                                case 58:
                                    {
                                        protocol = "ICMPv6";
                                        break;
                                    }
                                case 59:
                                    {
                                        protocol = "IPv6-NoNxt";
                                        break;
                                    }
                                case 60:
                                    {
                                        protocol = "IPv6-Opts";
                                        break;
                                    }
                                case 112:
                                    {
                                        protocol = "VRRP";
                                        break;
                                    }
                                case 113:
                                    {
                                        protocol = "PGM";
                                        break;
                                    }
                                case 115:
                                    {
                                        protocol = "L2TP";
                                        break;
                                    }
                            }
                            if (rule.LocalAddresses == "*")
                            {
                                localAddress = "Any";
                            }
                            else
                            {
                                localAddress = rule.LocalAddresses;
                            }
                            if (rule.RemoteAddresses == "*")
                            {
                                remoteAddress = "Any";
                            }
                            else
                            {
                                remoteAddress = rule.RemoteAddresses;
                            }
                            if (rule.LocalPorts == "*" || rule.LocalPorts == null)
                            {
                                localport = "Any";
                            }
                            else
                            {
                                localport = rule.LocalPorts;
                            }
                            if (rule.RemotePorts == "*" || rule.RemotePorts == null)
                            {
                                remoteport = "Any";
                            }
                            else
                            {
                                remoteport = rule.RemotePorts;
                            }
                            switch (rule.Profiles)
                            {
                                case 3:
                                    {
                                        profile = "Domain,Private";
                                        break;
                                    }
                                case 7:
                                    {
                                        profile = "Domain,Private,Public";
                                        break;
                                    }
                                case 2:
                                    {
                                        profile = "Private";
                                        break;
                                    }
                                case 4:
                                    {
                                        profile = "Public";
                                        break;
                                    }
                                case 2147483647:
                                    {
                                        profile = "Domain,Private,Public";
                                        break;
                                    }
                                case 6:
                                    {
                                        profile = "Private,Public";
                                        break;
                                    }
                                case 1:
                                    {
                                        profile = "Domain";
                                        break;
                                    }
                                case 5:
                                    {
                                        profile = "Domain,Public";
                                        break;
                                    }
                            }
                            result.Add(new Customer()
                            {
                                Statebool = rule.Enabled,
                                NameRule = rule.Name,
                                Application = app,
                                State = state,
                                Action = action,
                                Protocol = protocol,
                                LocalAddress = localAddress,
                                RemoteAddress = remoteAddress,
                                LocalPort = localport,
                                RemotePort = remoteport,
                                Profile = profile,
                            });
                        }
                    }
                }
                else
                {
                    if (rule.Direction.ToString() == "NET_FW_RULE_DIR_IN")
                    {
                        if (rule.Grouping != null)
                        {
                            if (rule.Enabled == true)
                            {
                                state = "Yes";
                            }
                            else
                            {
                                state = "No";
                            }
                            if (rule.Action.ToString() == "NET_FW_ACTION_ALLOW")
                            {
                                action = "Allow";
                            }
                            else
                            {
                                action = "Block";
                            }
                            if (rule.ApplicationName == null)
                            {
                                app = "Any";
                            }
                            else
                            {
                                app = rule.ApplicationName;
                            }
                            switch (rule.Protocol)
                            {
                                case 256:
                                    {
                                        protocol = "Any";
                                        break;
                                    }
                                case 1:
                                    {
                                        protocol = "ICMPv4";
                                        break;
                                    }
                                case 2:
                                    {
                                        protocol = "IGMP";
                                        break;
                                    }
                                case 6:
                                    {
                                        protocol = "TCP";
                                        break;
                                    }
                                case 17:
                                    {
                                        protocol = "UDP";
                                        break;
                                    }
                                case 41:
                                    {
                                        protocol = "IPv6";
                                        break;
                                    }
                                case 43:
                                    {
                                        protocol = "IPv6-Route";
                                        break;
                                    }
                                case 44:
                                    {
                                        protocol = "IPv6-Frag";
                                        break;
                                    }
                                case 47:
                                    {
                                        protocol = "GRE";
                                        break;
                                    }
                                case 58:
                                    {
                                        protocol = "ICMPv6";
                                        break;
                                    }
                                case 59:
                                    {
                                        protocol = "IPv6-NoNxt";
                                        break;
                                    }
                                case 60:
                                    {
                                        protocol = "IPv6-Opts";
                                        break;
                                    }
                                case 112:
                                    {
                                        protocol = "VRRP";
                                        break;
                                    }
                                case 113:
                                    {
                                        protocol = "PGM";
                                        break;
                                    }
                                case 115:
                                    {
                                        protocol = "L2TP";
                                        break;
                                    }
                            }
                            if (rule.LocalAddresses == "*")
                            {
                                localAddress = "Any";
                            }
                            else
                            {
                                localAddress = rule.LocalAddresses;
                            }
                            if (rule.RemoteAddresses == "*")
                            {
                                remoteAddress = "Any";
                            }
                            else
                            {
                                remoteAddress = rule.RemoteAddresses;
                            }
                            if (rule.LocalPorts == "*" || rule.LocalPorts == null)
                            {
                                localport = "Any";
                            }
                            else
                            {
                                localport = rule.LocalPorts;
                            }
                            if (rule.RemotePorts == "*" || rule.RemotePorts == null)
                            {
                                remoteport = "Any";
                            }
                            else
                            {
                                remoteport = rule.RemotePorts;
                            }
                            switch (rule.Profiles)
                            {
                                case 3:
                                    {
                                        profile = "Domain,Private";
                                        break;
                                    }
                                case 7:
                                    {
                                        profile = "Domain,Private,Public";
                                        break;
                                    }
                                case 2:
                                    {
                                        profile = "Private";
                                        break;
                                    }
                                case 4:
                                    {
                                        profile = "Public";
                                        break;
                                    }
                                case 2147483647:
                                    {
                                        profile = "Domain,Private,Public";
                                        break;
                                    }
                                case 6:
                                    {
                                        profile = "Private,Public";
                                        break;
                                    }
                                case 1:
                                    {
                                        profile = "Domain";
                                        break;
                                    }
                                case 5:
                                    {
                                        profile = "Domain,Public";
                                        break;
                                    }
                            }
                            result.Add(new Customer()
                            {
                                Statebool = rule.Enabled,
                                NameRule = rule.Name,
                                Application = app,
                                State = state,
                                Action = action,
                                Protocol = protocol,
                                LocalAddress = localAddress,
                                RemoteAddress = remoteAddress,
                                LocalPort = localport,
                                RemotePort = remoteport,
                                Profile = profile,
                            });
                        }
                    }
                }
            }
            return result;
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
    }
}
