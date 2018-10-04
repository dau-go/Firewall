﻿using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsExample
{
    public partial class InboundForm : Form
    {
        private static int _User;
        public static int User
        {
            get { return _User; }
            set { _User = value; }
        }
        int stt = 0;
        BindingList<Customer> dataSource = new BindingList<Customer>();
        public InboundForm()
        {
            InitializeComponent();
            dataSource = GetDataSource();
            dataGridView1.DataSource = dataSource;
            dataGridView1.Columns["Statebool"].HeaderText = "";
            dataGridView1.Columns["NameRule"].HeaderText = "Name Rules";
            dataGridView1.Columns["Application"].HeaderText = "Application Package";
            dataGridView1.Columns["LocalAddress"].HeaderText = "Local Address";
            dataGridView1.Columns["RemoteAddress"].HeaderText = "Remote Address";
            dataGridView1.Columns["LocalPort"].HeaderText = "Local Port";
            dataGridView1.Columns["RemotePort"].HeaderText = "Remote Port";
            dataGridView1.Columns["Statebool"].Width = 20;
            dataGridView1.Columns["STT"].Visible = false;
            try
            {
                dataGridView1.Rows[0].Selected = true;
            }
            catch
            {

            }
            Detail = GetDataDel();
        }
        public void Header(int i)
        {
            if (dataSource.Count() >= 25)
            {
                if (i == 0)
                {
                    dataGridView1.Columns["NameRule"].Width = 220;
                    dataGridView1.Columns["Application"].Width = 138;
                    dataGridView1.Columns["State"].Width = 50;
                    dataGridView1.Columns["Action"].Width = 50;
                    dataGridView1.Columns["LocalAddress"].Width = 110;
                    dataGridView1.Columns["RemoteAddress"].Width = 110;
                    dataGridView1.Columns["LocalPort"].Width = 110;
                    dataGridView1.Columns["RemotePort"].Width = 110;
                    dataGridView1.Columns["Profile"].Width = 120;
                }
                else
                {
                    dataGridView1.Columns["NameRule"].Width = 265;
                    dataGridView1.Columns["Application"].Width = 220;
                    dataGridView1.Columns["State"].Width = 60;
                    dataGridView1.Columns["Action"].Width = 60;
                    dataGridView1.Columns["LocalAddress"].Width = 120;
                    dataGridView1.Columns["RemoteAddress"].Width = 120;
                    dataGridView1.Columns["LocalPort"].Width = 120;
                    dataGridView1.Columns["RemotePort"].Width = 120;
                    dataGridView1.Columns["Profile"].Width = 120;
                }
            }
            else
            {
                if (i == 0)
                {
                    dataGridView1.Columns["NameRule"].Width = 220;
                    dataGridView1.Columns["Application"].Width = 155;
                    dataGridView1.Columns["State"].Width = 50;
                    dataGridView1.Columns["Action"].Width = 50;
                    dataGridView1.Columns["LocalAddress"].Width = 110;
                    dataGridView1.Columns["RemoteAddress"].Width = 110;
                    dataGridView1.Columns["LocalPort"].Width = 110;
                    dataGridView1.Columns["RemotePort"].Width = 110;
                    dataGridView1.Columns["Profile"].Width = 120;
                }
                else
                {
                    dataGridView1.Columns["NameRule"].Width = 263;
                    dataGridView1.Columns["Application"].Width = 230;
                    dataGridView1.Columns["State"].Width = 60;
                    dataGridView1.Columns["Action"].Width = 60;
                    dataGridView1.Columns["LocalAddress"].Width = 120;
                    dataGridView1.Columns["RemoteAddress"].Width = 120;
                    dataGridView1.Columns["LocalPort"].Width = 120;
                    dataGridView1.Columns["RemotePort"].Width = 120;
                    dataGridView1.Columns["Profile"].Width = 130;
                }
            }
        }
        public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            var firewallRule = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            foreach (INetFwRule rule in firewallRule.Rules)
            {
                string state = "", action = "", app = "", protocol = "", localAddress = "", remoteAddress = "", localport = "", remoteport = "", profile = "";
                if (_User == 0)
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
                                case 0:
                                    {
                                        profile = "HOPOPT";
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
                                if (rule.LocalAddresses.Contains("/255.255.255.255") == true)
                                {
                                    string[] s = rule.LocalAddresses.Split('/');
                                    localAddress = s[0];
                                }
                                else
                                {
                                    localAddress = rule.LocalAddresses;
                                }
                            }
                            if (rule.RemoteAddresses == "*")
                            {
                                remoteAddress = "Any";
                            }
                            else
                            {
                                if (rule.RemoteAddresses.Contains("/255.255.255.255") == true)
                                {
                                    string[] s = rule.RemoteAddresses.Split('/');
                                    remoteAddress = s[0];
                                }
                                else
                                {
                                    remoteAddress = rule.RemoteAddresses;
                                }
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
                            if (FirewallForm.Action == "1")
                            {
                                if (FirewallForm.Profile == "1")
                                {
                                    if (FirewallForm.State == "1")
                                    {
                                        stt++;
                                        result.Add(new Customer()
                                        {
                                            STT = stt - 1,
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
                                    else
                                    {
                                        if (FirewallForm.State == state)
                                        {
                                            stt++;
                                            result.Add(new Customer()
                                            {
                                                STT = stt - 1,
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
                                    if (FirewallForm.Profile == profile || profile == "Domain,Private,Public")
                                    {
                                        if (FirewallForm.State == "1")
                                        {
                                            stt++;
                                            result.Add(new Customer()
                                            {
                                                STT = stt - 1,
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
                                        else
                                        {
                                            if (FirewallForm.State == state)
                                            {
                                                stt++;
                                                result.Add(new Customer()
                                                {
                                                    STT = stt - 1,
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
                            }
                            else
                            {
                                if (FirewallForm.Action == action)
                                {
                                    if (FirewallForm.Profile == "1")
                                    {
                                        if (FirewallForm.State == "1")
                                        {
                                            stt++;
                                            result.Add(new Customer()
                                            {
                                                STT = stt - 1,
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
                                        else
                                        {
                                            if (FirewallForm.State == state)
                                            {
                                                stt++;
                                                result.Add(new Customer()
                                                {
                                                    STT = stt - 1,
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
                                        if (FirewallForm.Profile == profile || profile == "Domain,Private,Public")
                                        {
                                            if (FirewallForm.State == "1")
                                            {
                                                stt++;
                                                result.Add(new Customer()
                                                {
                                                    STT = stt - 1,
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
                                            else
                                            {
                                                if (FirewallForm.State == state)
                                                {
                                                    stt++;
                                                    result.Add(new Customer()
                                                    {
                                                        STT = stt - 1,
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
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (rule.Direction.ToString() == "NET_FW_RULE_DIR_IN")
                    {
                        if (rule.Grouping != null && rule.Grouping != "Domain")
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
                                if (rule.LocalAddresses.Contains("/255.255.255.255") == true)
                                {
                                    string[] s = rule.LocalAddresses.Split('/');
                                    localAddress = s[0];
                                }
                                else
                                {
                                    localAddress = rule.LocalAddresses;
                                }
                            }
                            if (rule.RemoteAddresses == "*")
                            {
                                remoteAddress = "Any";
                            }
                            else
                            {
                                if (rule.RemoteAddresses.Contains("/255.255.255.255") == true)
                                {
                                    string[] s = rule.RemoteAddresses.Split('/');
                                    remoteAddress = s[0];
                                }
                                else
                                {
                                    remoteAddress = rule.RemoteAddresses;
                                }
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
                            if (FirewallForm.Action == "1")
                            {
                                if (FirewallForm.Profile == "1")
                                {
                                    if (FirewallForm.State == "1")
                                    {
                                        stt++;
                                        result.Add(new Customer()
                                        {
                                            STT = stt - 1,
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
                                    else
                                    {
                                        if (FirewallForm.State == state)
                                        {
                                            stt++;
                                            result.Add(new Customer()
                                            {
                                                STT = stt - 1,
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
                                    if (FirewallForm.Profile == profile || profile == "Domain,Private,Public")
                                    {
                                        if (FirewallForm.State == "1")
                                        {
                                            stt++;
                                            result.Add(new Customer()
                                            {
                                                STT = stt - 1,
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
                                        else
                                        {
                                            if (FirewallForm.State == state)
                                            {
                                                stt++;
                                                result.Add(new Customer()
                                                {
                                                    STT = stt - 1,
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
                            }
                            else
                            {
                                if (FirewallForm.Action == action)
                                {
                                    if (FirewallForm.Profile == "1")
                                    {
                                        if (FirewallForm.State == "1")
                                        {
                                            stt++;
                                            result.Add(new Customer()
                                            {
                                                STT = stt - 1,
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
                                        else
                                        {
                                            if (FirewallForm.State == state)
                                            {
                                                stt++;
                                                result.Add(new Customer()
                                                {
                                                    STT = stt - 1,
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
                                        if (FirewallForm.Profile == profile || profile == "Domain,Private,Public")
                                        {
                                            if (FirewallForm.State == "1")
                                            {
                                                stt++;
                                                result.Add(new Customer()
                                                {
                                                    STT = stt - 1,
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
                                            else
                                            {
                                                if (FirewallForm.State == state)
                                                {
                                                    stt++;
                                                    result.Add(new Customer()
                                                    {
                                                        STT = stt - 1,
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
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        public class Customer
        {
            public int STT { get; set; }
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
        BindingList<Customer> Detail;
        private BindingList<Customer> GetDataDel()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[i];
                int t = int.Parse(dr.Cells["STT"].Value.ToString());
                result.Add(new Customer()
                {
                    STT = int.Parse(dr.Cells["STT"].Value.ToString()),
                    NameRule = dr.Cells["NameRule"].Value.ToString(),
                    Application = dr.Cells["Application"].Value.ToString(),
                    State = dr.Cells["State"].Value.ToString(),
                    Action = dr.Cells["Action"].Value.ToString(),
                    Protocol = dr.Cells["Protocol"].Value.ToString(),
                    LocalAddress = dr.Cells["LocalAddress"].Value.ToString(),
                    RemoteAddress = dr.Cells["RemoteAddress"].Value.ToString(),
                    LocalPort = dr.Cells["LocalPort"].Value.ToString(),
                    RemotePort = dr.Cells["RemotePort"].Value.ToString(),
                    Profile = dr.Cells["Profile"].Value.ToString(),
                });
            }
            return result;
        }
        public void Delete()
        {
            for (int i = 0; i < Detail.Count; i++)
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                firewallPolicy.Rules.Remove(Detail[i].NameRule);
            }
            //Detail = GetDataDetail();
            //for (int i = 0; i < Detail.Count; i++)
            //{
            //ProcessStartInfo run = new ProcessStartInfo();
            //run.FileName = "cmd.exe";
            //run.Verb = "runas";
            //string s;
            //string s1 = "/C netsh advfirewall firewall delete rule name=" + "\"" + Detail[i].NameRule + "\"";
            //if (Detail[i].Application == "Any")
            //{
            //    if (Detail[i].Protocol == "TCP" || Detail[i].Protocol == "UDP")
            //    {
            //        if (Detail[i].Profile == "Domain,Private,Public")
            //        {

            //            s = string.Format(s1 + " dir=in localip={0} remoteip={1} localport={2} remoteport={3} protocol={4}", Detail[i].LocalAddress, Detail[i].RemoteAddress, Detail[i].LocalPort, Detail[i].RemotePort, Detail[i].Protocol);
            //        }
            //        else
            //        {
            //            s = string.Format(s1 + " dir=in profile={0} localip={1} remoteip={2} localport={3} remoteport={4} protocol={5}", Detail[i].Profile, Detail[i].LocalAddress, Detail[i].RemoteAddress, Detail[i].LocalPort, Detail[i].RemotePort, Detail[i].Protocol);
            //        }
            //    }
            //    else
            //    {
            //        if (Detail[i].Profile == "Domain,Private,Public")
            //        {
            //            s = string.Format(s1 + " dir=in localip={0} remoteip={1}", Detail[i].LocalAddress, Detail[i].RemoteAddress);
            //        }
            //        else
            //        {
            //            s = string.Format(s1 + " dir=in profile={0} localip={1} remoteip={2}", Detail[i].Profile, Detail[i].LocalAddress, Detail[i].RemoteAddress);
            //        }

            //    }
            //}
            //else
            //{
            //    if (Detail[i].Protocol == "TCP" || Detail[i].Protocol == "UDP")
            //    {
            //        if (Detail[i].Profile == "Domain,Private,Public")
            //        {
            //            s = string.Format(s1 + " dir=in program={0} localip={1} remoteip={3} localport={3} remoteport={4} protocol={5}", Detail[i].Application, Detail[i].LocalAddress, Detail[i].RemoteAddress, Detail[i].LocalPort, Detail[i].RemotePort, Detail[i].Protocol);
            //        }
            //        else
            //        {
            //            s = string.Format(s1 + " dir=in program={0} profile={1} localip={2} remoteip={3} localport={4} remoteport={5} protocol={6}", Detail[i].Application, Detail[i].Profile, Detail[i].LocalAddress, Detail[i].RemoteAddress, Detail[i].LocalPort, Detail[i].RemotePort, Detail[i].Protocol);
            //        }
            //    }
            //    else
            //    {
            //        if (Detail[i].Profile == "Domain,Private,Public")
            //        {
            //            s = string.Format(s1 + " dir=in program={0} localip={1} remoteip={2}", Detail[i].Application, Detail[i].LocalAddress, Detail[i].RemoteAddress);
            //        }
            //        else
            //        {
            //            s = string.Format(s1 + " dir=in program={0} profile={1} localip={2} remoteip={3}", Detail[i].Application, Detail[i].Profile, Detail[i].LocalAddress, Detail[i].RemoteAddress);
            //        }

            //    }
            //}
            //run.Arguments = s;
            //run.WindowStyle = ProcessWindowStyle.Hidden;
            //Process.Start(run);
            //}
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(1, 226, 230);
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Detail = GetDataDel();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Detail = GetDataDel();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Detail = GetDataDel();
            EditForm.NameRule = Detail[0].NameRule;
            EditForm.State = Detail[0].State;
            EditForm.Action = Detail[0].Action;
            EditForm.Program = Detail[0].Application;
            EditForm.Profile = Detail[0].Profile;
            EditForm.Protocol = Detail[0].Protocol;
            EditForm.LocalIP = Detail[0].LocalAddress;
            EditForm.RemoteIP = Detail[0].RemoteAddress;
            EditForm.LocalPort = Detail[0].LocalPort;
            EditForm.RemotePort = Detail[0].RemotePort;
            EditForm f = new EditForm();
            f.Show();
            f.send = new EditForm.SendMessage(Reload);
        }

        private void dataGridView1_MouseCaptureChanged(object sender, EventArgs e)
        {
            Detail = GetDataDel();
        }

        private void dataGridView1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.ColumnIndex == -1) return;
            if (Detail.Count > 1)
            {
                for (int i = 0; i < Detail.Count; i++)
                {
                    if (Detail[i].STT == e.RowIndex)
                    {
                        menuProperties.Visible = false;
                        menuDisable.Visible = false;
                        menuEnable.Visible = false;
                        menuAllow.Visible = false;
                        menuBlock.Visible = false;
                        toolStripSeparator3.Visible = false;
                        for (int j = 0; j < Detail.Count; j++)
                        {
                            if (Detail[j].State == "Yes")
                            {
                                menuDisable.Visible = true;
                            }
                            else
                            {
                                menuEnable.Visible = true;
                            }
                            if (Detail[j].Action == "Allow")
                            {
                                menuBlock.Visible = true;
                            }
                            else
                            {
                                menuAllow.Visible = true;
                            }
                        }
                        e.ContextMenuStrip = contextMenuStrip1;
                        return;
                    }
                }
            }
            dataGridView1.ClearSelection();
            int rowselected1 = e.RowIndex;
            dataGridView1.Rows[rowselected1].Selected = true;
            toolStripSeparator3.Visible = true;
            e.ContextMenuStrip = contextMenuStrip1;
            Detail = GetDataDel();
            menuProperties.Visible = true;
            if (Detail[0].State == "Yes")
            {
                menuDisable.Visible = true;
                menuEnable.Visible = false;
            }
            else
            {
                menuDisable.Visible = false;
                menuEnable.Visible = true;
            }
            if (Detail[0].Action == "Allow")
            {
                menuAllow.Visible = false;
                menuBlock.Visible = true;
            }
            else
            {
                menuAllow.Visible = true;
                menuBlock.Visible = false;
            }
        }

        private void menuDisable_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Detail.Count; i++)
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                var rule = firewallPolicy.Rules.Item(Detail[i].NameRule);
                rule.Enabled = false;
            }
            Reload();
        }

        private void menuEnable_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Detail.Count; i++)
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                var rule = firewallPolicy.Rules.Item(Detail[i].NameRule);
                rule.Enabled = true;
            }
            Reload();
        }

        private void menuBlock_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Detail.Count; i++)
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                var rule = firewallPolicy.Rules.Item(Detail[i].NameRule);
                rule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            }
            Reload();
        }

        private void menuAllow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Detail.Count; i++)
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                var rule = firewallPolicy.Rules.Item(Detail[i].NameRule);
                rule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            }
            Reload();
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            AddRuleForm.kt = 0;
            AddRuleForm f = new AddRuleForm();
            f.ShowDialog();
        }

        private void menuDel_Click(object sender, EventArgs e)
        {
            Delete();
            stt = 0;
            dataSource = GetDataSource();
            dataGridView1.DataSource = dataSource;
        }
        public void Reload()
        {
            stt = 0;
            dataSource = GetDataSource();
            dataGridView1.DataSource = dataSource;
            dataGridView1.ClearSelection();
            for (int i = 0; i < Detail.Count; i++)
            {
                try
                {
                    dataGridView1.Rows[Detail[i].STT].Selected = true;
                }
                catch
                {

                }
            }
        }

        private void menuProperties_Click(object sender, EventArgs e)
        {
            EditForm.NameRule = Detail[0].NameRule;
            EditForm.State = Detail[0].State;
            EditForm.Action = Detail[0].Action;
            EditForm.Program = Detail[0].Application;
            EditForm.Profile = Detail[0].Profile;
            EditForm.Protocol = Detail[0].Protocol;
            EditForm.LocalIP = Detail[0].LocalAddress;
            EditForm.RemoteIP = Detail[0].RemoteAddress;
            EditForm.LocalPort = Detail[0].LocalPort;
            EditForm.RemotePort = Detail[0].RemotePort;
            EditForm f = new EditForm();
            f.Show();
            f.send = new EditForm.SendMessage(Reload);
        }
    }
}
