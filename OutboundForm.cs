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
    public partial class OutboundForm : Form
    {
        private static int _User;
        public static int User
        {
            get { return _User; }
            set { _User = value; }
        }
        int stt = 0;
        BindingList<Customer> dataSource;
        public OutboundForm()
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
            try
            {
                dataGridView1.Rows[0].Selected = true;
            }
            catch
            {

            }
            Detail = GetDataDel();
            dataGridView1.Columns["STT"].Visible = false;
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
            dataGridView1.Columns["NameRule"].HeaderText = "Tên Quy Tắc";
            dataGridView1.Columns["Application"].HeaderText = "Ứng Dụng";
            dataGridView1.Columns["State"].HeaderText = "Trạng Thái";
            dataGridView1.Columns["Action"].HeaderText = "Hoạt Động";
            dataGridView1.Columns["Protocol"].HeaderText = "Giao Thức";
            dataGridView1.Columns["LocalAddress"].HeaderText = "Địa Chỉ Nội Bộ";
            dataGridView1.Columns["RemoteAddress"].HeaderText = "Địa chỉ từ xa";
            dataGridView1.Columns["LocalPort"].HeaderText = "Cổng Nội Bộ";
            dataGridView1.Columns["RemotePort"].HeaderText = "Cổng Từ Xa";
            dataGridView1.Columns["Profile"].HeaderText = "Hồ Sơ";
            menuDisable.Text = "Tắt";
            menuEnable.Text = "Bật";
            menuAllow.Text = "Cho phép";
            menuBlock.Text = "Chặn";
            menuAdd.Text = "Thêm mới quy tắc";
            menuDel.Text = "Xóa quy tắc";
            menuProperties.Text = "Thuộc Tính";
        }
        public void ShowEnglish()
        {
            dataGridView1.Columns["NameRule"].HeaderText = "Name Rules";
            dataGridView1.Columns["Application"].HeaderText = "Application Package";
            dataGridView1.Columns["State"].HeaderText = "State";
            dataGridView1.Columns["Action"].HeaderText = "Action";
            dataGridView1.Columns["Protocol"].HeaderText = "Protocol";
            dataGridView1.Columns["LocalAddress"].HeaderText = "Local Address";
            dataGridView1.Columns["RemoteAddress"].HeaderText = "Remote Address";
            dataGridView1.Columns["LocalPort"].HeaderText = "Local Port";
            dataGridView1.Columns["RemotePort"].HeaderText = "Remote Port";
            dataGridView1.Columns["Profile"].HeaderText = "Profile";
            menuDisable.Text = "Disabled";
            menuEnable.Text = "Enabled";
            menuAllow.Text = "Allow";
            menuBlock.Text = "Block";
            menuAdd.Text = "Add New Rule";
            menuDel.Text = "Delete Rule";
            menuProperties.Text = "Properties";
        }
        public void Header(int i)
        {
            if (dataSource.Count() >= 25)
            {
                if (i == 0)
                {
                    dataGridView1.Columns["NameRule"].Width = 300;
                    dataGridView1.Columns["Application"].Width = 200;
                    dataGridView1.Columns["State"].Width = 85;
                    dataGridView1.Columns["Action"].Width = 85;
                    dataGridView1.Columns["LocalAddress"].Width = 110;
                    dataGridView1.Columns["RemoteAddress"].Width = 110;
                    dataGridView1.Columns["LocalPort"].Width = 110;
                    dataGridView1.Columns["RemotePort"].Width = 110;
                    dataGridView1.Columns["Profile"].Width = 120;
                }
                else
                {
                    dataGridView1.Columns["NameRule"].Width = 300;
                    dataGridView1.Columns["Application"].Width = 200;
                    dataGridView1.Columns["State"].Width = 85;
                    dataGridView1.Columns["Action"].Width = 85;
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
                    dataGridView1.Columns["NameRule"].Width = 300;
                    dataGridView1.Columns["Application"].Width = 200;
                    dataGridView1.Columns["State"].Width = 85;
                    dataGridView1.Columns["Action"].Width = 85;
                    dataGridView1.Columns["LocalAddress"].Width = 110;
                    dataGridView1.Columns["RemoteAddress"].Width = 110;
                    dataGridView1.Columns["LocalPort"].Width = 110;
                    dataGridView1.Columns["RemotePort"].Width = 110;
                    dataGridView1.Columns["Profile"].Width = 120;
                }
                else
                {
                    dataGridView1.Columns["NameRule"].Width = 300;
                    dataGridView1.Columns["Application"].Width = 200;
                    dataGridView1.Columns["State"].Width = 85;
                    dataGridView1.Columns["Action"].Width = 85;
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
                string state = "", action = "", app = "", protocol = "", localAddress = "", remoteAddress = "", localport = "", remoteport = "", profile = "", profile1 = "";
                if (_User == 0)
                {
                    if (rule.Direction.ToString() == "NET_FW_RULE_DIR_OUT")
                    {
                        if (rule.Grouping == null)
                        {
                            if (rule.Enabled == true)
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    state = "Bật";
                                }
                                else
                                {
                                    state = "Yes";
                                }
                            }
                            else
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    state = "Tắt";
                                }
                                else
                                {
                                    state = "Yes";
                                }
                            }
                            if (rule.Action.ToString() == "NET_FW_ACTION_ALLOW")
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    action = "Cho phép";
                                }
                                else
                                {
                                    action = "Allow";
                                }
                            }
                            else
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    action = "Chặn";
                                }
                                else
                                {
                                    action = "Block";
                                }
                            }
                            if (rule.ApplicationName == null)
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    app = "Tất cả";
                                }
                                else
                                {
                                    app = "Any";
                                }
                            }
                            else
                            {
                                app = rule.ApplicationName;
                            }
                            switch (rule.Protocol)
                            {
                                case 256:
                                    {
                                        if (FirewallForm.Lang == 0)
                                        {
                                            protocol = "Tất cả";
                                        }
                                        else
                                        {
                                            protocol = "Any";
                                        }
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
                                if (FirewallForm.Lang == 0)
                                {
                                    localAddress = "Tất cả";
                                }
                                else
                                {
                                    localAddress = "Any";
                                }
                            }
                            else
                            {
                                if (rule.LocalAddresses.Contains("/255.255.255.255") == true)
                                {
                                    string[] s = rule.LocalAddresses.Split('/');
                                    localAddress = s[0];
                                }
                                else if (rule.LocalAddresses == "LocalSubnet")
                                {
                                    localAddress = "127.0.0.1";
                                }
                                else
                                {
                                    localAddress = rule.LocalAddresses;
                                }
                            }
                            if (rule.RemoteAddresses == "*")
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    remoteAddress = "Tất cả";
                                }
                                else
                                {
                                    remoteAddress = "Any";
                                }
                            }
                            else
                            {
                                if (rule.RemoteAddresses.Contains("/255.255.255.255") == true)
                                {
                                    string[] s = rule.RemoteAddresses.Split('/');
                                    remoteAddress = s[0];
                                }
                                else if (rule.RemoteAddresses == "LocalSubnet")
                                {
                                    remoteAddress = "127.0.0.1";
                                }
                                else
                                {
                                    remoteAddress = rule.RemoteAddresses;
                                }
                            }
                            if (rule.LocalPorts == "*" || rule.LocalPorts == null)
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    localport = "Tất cả";
                                }
                                else
                                {
                                    localport = "Any";
                                }
                            }
                            else
                            {
                                localport = rule.LocalPorts;
                            }
                            if (rule.RemotePorts == "*" || rule.RemotePorts == null)
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    remoteport = "Tất cả";
                                }
                                else
                                {
                                    remoteport = "Any";
                                }
                            }
                            else
                            {
                                remoteport = rule.RemotePorts;
                            }
                            if (FirewallForm.Lang == 0)
                            {
                                switch (rule.Profiles)
                                {
                                    case 3:
                                        {
                                            profile = "Domain,Private";
                                            profile1 = "Tên miền,Bảo mật";
                                            break;
                                        }
                                    case 7:
                                        {
                                            profile = "Domain,Private,Public";
                                            profile1 = "Tên miền,Bảo mật,Công khai";
                                            break;
                                        }
                                    case 2:
                                        {
                                            profile = "Private";
                                            profile1 = "Bảo mật";
                                            break;
                                        }
                                    case 4:
                                        {
                                            profile = "Public";
                                            profile1 = "Công khai";
                                            break;
                                        }
                                    case 2147483647:
                                        {
                                            profile = "Domain,Private,Public";
                                            profile1 = "Tên miền,Bảo mật,Công khai";
                                            break;
                                        }
                                    case 6:
                                        {
                                            profile = "Private,Public";
                                            profile1 = "Bảo mật,Công khai";
                                            break;
                                        }
                                    case 1:
                                        {
                                            profile = "Domain";
                                            profile1 = "Công khai";
                                            break;
                                        }
                                    case 5:
                                        {
                                            profile = "Domain,Public";
                                            profile1 = "Tên miền,Công khai";
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                switch (rule.Profiles)
                                {
                                    case 3:
                                        {
                                            profile = "Domain,Private";
                                            profile1 = "Domain,Private";
                                            break;
                                        }
                                    case 7:
                                        {
                                            profile = "Domain,Private,Public";
                                            profile1 = "Domain,Private,Public";
                                            break;
                                        }
                                    case 2:
                                        {
                                            profile = "Private";
                                            profile1 = "Private";
                                            break;
                                        }
                                    case 4:
                                        {
                                            profile = "Public";
                                            profile1 = "Public";
                                            break;
                                        }
                                    case 2147483647:
                                        {
                                            profile = "Domain,Private,Public";
                                            profile1 = "Domain,Private,Public";
                                            break;
                                        }
                                    case 6:
                                        {
                                            profile = "Private,Public";
                                            profile1 = "Private,Public";
                                            break;
                                        }
                                    case 1:
                                        {
                                            profile = "Domain";
                                            profile1 = "Domain";
                                            break;
                                        }
                                    case 5:
                                        {
                                            profile = "Domain,Public";
                                            profile1 = "Domain,Public";
                                            break;
                                        }
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
                                            Profile = profile1,
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
                                                Profile = profile1,
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
                                                Profile = profile1,
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
                                                    Profile = profile1,
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
                                                Profile = profile1,
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
                                                    Profile = profile1,
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
                                                    Profile = profile1,
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
                                                        Profile = profile1,
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
                    if (rule.Direction.ToString() == "NET_FW_RULE_DIR_OUT")
                    {
                        if (rule.Grouping != null && rule.Grouping != "Domain")
                        {
                            if (rule.Enabled == true)
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    state = "Bật";
                                }
                                else
                                {
                                    state = "Yes";
                                }
                            }
                            else
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    state = "Tắt";
                                }
                                else
                                {
                                    state = "Yes";
                                }
                            }
                            if (rule.Action.ToString() == "NET_FW_ACTION_ALLOW")
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    action = "Cho phép";
                                }
                                else
                                {
                                    action = "Allow";
                                }
                            }
                            else
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    action = "Chặn";
                                }
                                else
                                {
                                    action = "Block";
                                }
                            }
                            if (rule.ApplicationName == null)
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    app = "Tất cả";
                                }
                                else
                                {
                                    app = "Any";
                                }
                            }
                            else
                            {
                                app = rule.ApplicationName;
                            }
                            switch (rule.Protocol)
                            {
                                case 256:
                                    {
                                        if (FirewallForm.Lang == 0)
                                        {
                                            protocol = "Tất cả";
                                        }
                                        else
                                        {
                                            protocol = "Any";
                                        }
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
                                if (FirewallForm.Lang == 0)
                                {
                                    localAddress = "Tất cả";
                                }
                                else
                                {
                                    localAddress = "Any";
                                }
                            }
                            else
                            {
                                if (rule.LocalAddresses.Contains("/255.255.255.255") == true)
                                {
                                    string[] s = rule.LocalAddresses.Split('/');
                                    localAddress = s[0];
                                }
                                else if (rule.LocalAddresses == "LocalSubnet")
                                {
                                    localAddress = "127.0.0.1";
                                }
                                else
                                {
                                    localAddress = rule.LocalAddresses;
                                }
                            }
                            if (rule.RemoteAddresses == "*")
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    remoteAddress = "Tất cả";
                                }
                                else
                                {
                                    remoteAddress = "Any";
                                }
                            }
                            else
                            {
                                if (rule.RemoteAddresses.Contains("/255.255.255.255") == true)
                                {
                                    string[] s = rule.RemoteAddresses.Split('/');
                                    remoteAddress = s[0];
                                }
                                else if (rule.RemoteAddresses == "LocalSubnet")
                                {
                                    remoteAddress = "127.0.0.1";
                                }
                                else
                                {
                                    remoteAddress = rule.RemoteAddresses;
                                }
                            }
                            if (rule.LocalPorts == "*" || rule.LocalPorts == null)
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    localport = "Tất cả";
                                }
                                else
                                {
                                    localport = "Any";
                                }
                            }
                            else
                            {
                                localport = rule.LocalPorts;
                            }
                            if (rule.RemotePorts == "*" || rule.RemotePorts == null)
                            {
                                if (FirewallForm.Lang == 0)
                                {
                                    remoteport = "Tất cả";
                                }
                                else
                                {
                                    remoteport = "Any";
                                }
                            }
                            else
                            {
                                remoteport = rule.RemotePorts;
                            }
                            if (FirewallForm.Lang == 0)
                            {
                                switch (rule.Profiles)
                                {
                                    case 3:
                                        {
                                            profile = "Domain,Private";
                                            profile1 = "Tên miền,Bảo mật";
                                            break;
                                        }
                                    case 7:
                                        {
                                            profile = "Domain,Private,Public";
                                            profile1 = "Tên miền,Bảo mật,Công khai";
                                            break;
                                        }
                                    case 2:
                                        {
                                            profile = "Private";
                                            profile1 = "Bảo mật";
                                            break;
                                        }
                                    case 4:
                                        {
                                            profile = "Public";
                                            profile1 = "Công khai";
                                            break;
                                        }
                                    case 2147483647:
                                        {
                                            profile = "Domain,Private,Public";
                                            profile1 = "Tên miền,Bảo mật,Công khai";
                                            break;
                                        }
                                    case 6:
                                        {
                                            profile = "Private,Public";
                                            profile1 = "Bảo mật,Công khai";
                                            break;
                                        }
                                    case 1:
                                        {
                                            profile = "Domain";
                                            profile1 = "Công khai";
                                            break;
                                        }
                                    case 5:
                                        {
                                            profile = "Domain,Public";
                                            profile1 = "Tên miền,Công khai";
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                switch (rule.Profiles)
                                {
                                    case 3:
                                        {
                                            profile = "Domain,Private";
                                            profile1 = "Domain,Private";
                                            break;
                                        }
                                    case 7:
                                        {
                                            profile = "Domain,Private,Public";
                                            profile1 = "Domain,Private,Public";
                                            break;
                                        }
                                    case 2:
                                        {
                                            profile = "Private";
                                            profile1 = "Private";
                                            break;
                                        }
                                    case 4:
                                        {
                                            profile = "Public";
                                            profile1 = "Public";
                                            break;
                                        }
                                    case 2147483647:
                                        {
                                            profile = "Domain,Private,Public";
                                            profile1 = "Domain,Private,Public";
                                            break;
                                        }
                                    case 6:
                                        {
                                            profile = "Private,Public";
                                            profile1 = "Private,Public";
                                            break;
                                        }
                                    case 1:
                                        {
                                            profile = "Domain";
                                            profile1 = "Domain";
                                            break;
                                        }
                                    case 5:
                                        {
                                            profile = "Domain,Public";
                                            profile1 = "Domain,Public";
                                            break;
                                        }
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
                                            Profile = profile1,
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
                                                Profile = profile1,
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
                                                Profile = profile1,
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
                                                    Profile = profile1,
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
                                                Profile = profile1,
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
                                                    Profile = profile1,
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
                                                    Profile = profile1,
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
                                                        Profile = profile1,
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
        BindingList<Customer> Detail;
        private BindingList<Customer> GetDataDel()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[i];
                int t = int.Parse(dr.Cells["STT"].Value.ToString());
                string state = "", action = "", app = "", protocol = "", localAddress = "", remoteAddress = "", localport = "", remoteport = "", profile = "";
                if (dr.Cells["Application"].Value.ToString() == "Any" || dr.Cells["Application"].Value.ToString() == "Tất cả")
                {
                    app = "Any";
                }
                else
                {
                    app = dr.Cells["Application"].Value.ToString();
                }
                if (dr.Cells["State"].Value.ToString() == "Yes" || dr.Cells["State"].Value.ToString() == "Bật")
                {
                    state = "Yes";
                }
                else
                {
                    state = "No";
                }
                if (dr.Cells["Action"].Value.ToString() == "Allow" || dr.Cells["Action"].Value.ToString() == "Cho phép")
                {
                    action = "Allow";
                }
                else
                {
                    action = "Block";
                }
                if (dr.Cells["Protocol"].Value.ToString() == "Tất cả" || dr.Cells["Protocol"].Value.ToString() == "Any")
                {
                    protocol = "Any";
                }
                else
                {
                    protocol = dr.Cells["Protocol"].Value.ToString();
                }
                if (dr.Cells["LocalAddress"].Value.ToString() == "Tất cả" || dr.Cells["LocalAddress"].Value.ToString() == "Any")
                {
                    localAddress = "Any";
                }
                else
                {
                    localAddress = dr.Cells["LocalAddress"].Value.ToString();
                }
                if (dr.Cells["LocalAddress"].Value.ToString() == "Tất cả" || dr.Cells["LocalAddress"].Value.ToString() == "Any")
                {
                    localAddress = "Any";
                }
                else
                {
                    localAddress = dr.Cells["LocalAddress"].Value.ToString();
                }
                if (dr.Cells["RemoteAddress"].Value.ToString() == "Tất cả" || dr.Cells["RemoteAddress"].Value.ToString() == "Any")
                {
                    remoteAddress = "Any";
                }
                else
                {
                    remoteAddress = dr.Cells["RemoteAddress"].Value.ToString();
                }
                if (dr.Cells["LocalPort"].Value.ToString() == "Tất cả" || dr.Cells["LocalPort"].Value.ToString() == "Any")
                {
                    localport = "Any";
                }
                else
                {
                    localport = dr.Cells["LocalPort"].Value.ToString();
                }
                if (dr.Cells["RemotePort"].Value.ToString() == "Tất cả" || dr.Cells["RemotePort"].Value.ToString() == "Any")
                {
                    remoteport = "Any";
                }
                else
                {
                    remoteport = dr.Cells["RemotePort"].Value.ToString();
                }
                if (FirewallForm.Lang == 0)
                {
                    switch (dr.Cells["Profile"].Value.ToString())
                    {
                        case "Tên miền":
                            {
                                profile = "Domain";
                                break;
                            }
                        case "Bảo mật":
                            {
                                profile = "Private";
                                break;
                            }
                        case "Công khai":
                            {
                                profile = "Public";
                                break;
                            }
                        case "Tên miền,Bảo mật":
                            {
                                profile = "Domain,Private";
                                break;
                            }
                        case "Tên miền,Bảo mật,Công khai":
                            {
                                profile = "Domain,Private,Public";
                                break;
                            }
                        case "Bảo mật,Công khai":
                            {
                                profile = "Private,Public";
                                break;
                            }
                        case "Tên miền,Công khai":
                            {
                                profile = "Domain,Public";
                                break;
                            }
                    }
                }
                else
                {
                    profile = dr.Cells["Profile"].Value.ToString();
                }
                result.Add(new Customer()
                {
                    STT = int.Parse(dr.Cells["STT"].Value.ToString()),
                    NameRule = dr.Cells["NameRule"].Value.ToString(),
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
            return result;
        }
        public void Delete()
        {
            for (int i = 0; i < Detail.Count; i++)
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                firewallPolicy.Rules.Remove(Detail[i].NameRule);
            }
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Detail = GetDataDel();
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

        private void dataGridView1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex == -1) return;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Detail = GetDataDel();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Detail = GetDataDel();
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

        private void dataGridView1_MouseCaptureChanged(object sender, EventArgs e)
        {
            Detail = GetDataDel();
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
            AddRuleForm.kt = 1;
            AddRuleForm f = new AddRuleForm();
            f.ShowDialog();
        }

        private void menuDel_Click(object sender, EventArgs e)
        {
            Delete();
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
