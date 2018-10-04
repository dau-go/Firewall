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
    public partial class WebsiteRuleForm : Form
    {
        BindingList<Customer> dataSource;
        int stt = 0;
        public WebsiteRuleForm()
        {
            InitializeComponent();
            dataSource = GetDataSource();
            dataGridView1.DataSource = dataSource;
            dataGridView1.Columns["Statebool"].HeaderText = "";
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
            dataGridView1.Columns["State"].HeaderText = "Trạng Thái";
            dataGridView1.Columns["Action"].HeaderText = "Hoạt Động";
            dataGridView1.Columns["TimeFrom"].HeaderText = "Thời Gian Từ";
            dataGridView1.Columns["TimeTo"].HeaderText = "Thời Gian Đến";
            dataGridView1.Columns["RemoteIP"].HeaderText = "Địa chỉ từ xa";
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
            dataGridView1.Columns["NameRule"].HeaderText = "NameRule";
            dataGridView1.Columns["State"].HeaderText = "State";
            dataGridView1.Columns["Action"].HeaderText = "Action";
            dataGridView1.Columns["TimeFrom"].HeaderText = "Time Out";
            dataGridView1.Columns["TimeTo"].HeaderText = "Time To";
            dataGridView1.Columns["RemoteIP"].HeaderText = "Remote Address";
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
                    dataGridView1.Columns["NameRule"].Width = 400;
                    dataGridView1.Columns["State"].Width = 100;
                    dataGridView1.Columns["Action"].Width = 100;
                    dataGridView1.Columns["TimeFrom"].Width = 145;
                    dataGridView1.Columns["TimeTo"].Width = 145;
                    dataGridView1.Columns["RemoteIP"].Width = 228;
                }
                else
                {
                    dataGridView1.Columns["NameRule"].Width = 466;
                    dataGridView1.Columns["State"].Width = 120;
                    dataGridView1.Columns["Action"].Width = 120;
                    dataGridView1.Columns["RemoteIP"].Width = 300;
                    dataGridView1.Columns["TimeFrom"].Width = 150;
                    dataGridView1.Columns["TimeTo"].Width = 150;
                }
            }
            else
            {
                if (i == 0)
                {
                    dataGridView1.Columns["NameRule"].Width = 400;
                    dataGridView1.Columns["State"].Width = 100;
                    dataGridView1.Columns["Action"].Width = 100;
                    dataGridView1.Columns["TimeFrom"].Width = 145;
                    dataGridView1.Columns["TimeTo"].Width = 145;
                    dataGridView1.Columns["RemoteIP"].Width = 245;
                }
                else
                {
                    dataGridView1.Columns["NameRule"].Width = 483;
                    dataGridView1.Columns["State"].Width = 120;
                    dataGridView1.Columns["Action"].Width = 120;
                    dataGridView1.Columns["RemoteIP"].Width = 300;
                    dataGridView1.Columns["TimeFrom"].Width = 150;
                    dataGridView1.Columns["TimeTo"].Width = 150;
                }
            }
        }
        public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            var firewallRule = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            foreach (INetFwRule rule in firewallRule.Rules)
            {
                string state = "", action = "";
                if (rule.Grouping == "Domain")
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
                    string[] s = rule.Description.Split('-');
                    string[] s1 = rule.RemoteAddresses.Split('/', ',');
                    string s2 = "";
                    for (int i = 0; i < s1.Length; i = i + 2)
                    {
                        if (s2 == "")
                        {
                            s2 = s1[i];
                        }
                        else
                        {
                            s2 = s2 + "," + s1[i];
                        }
                    }
                    if (FirewallForm.Action == "1")
                    {
                        if (FirewallForm.State == "1")
                        {
                            stt++;
                            result.Add(new Customer()
                            {
                                STT = stt - 1,
                                Statebool = rule.Enabled,
                                NameRule = rule.Name,
                                State = state,
                                Action = action,
                                RemoteIP = s2,
                                TimeFrom = s[0],
                                TimeTo = s[1]
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
                                    State = state,
                                    Action = action,
                                    RemoteIP = s2,
                                    TimeFrom = s[0],
                                    TimeTo = s[1]
                                });
                            }
                        }
                    }
                    else
                    {
                        if (FirewallForm.Action == action)
                        {
                            if (FirewallForm.State == "1")
                            {
                                stt++;
                                result.Add(new Customer()
                                {
                                    STT = stt - 1,
                                    Statebool = rule.Enabled,
                                    NameRule = rule.Name,
                                    State = state,
                                    Action = action,
                                    RemoteIP = s2,
                                    TimeFrom = s[0],
                                    TimeTo = s[1]
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
                                        State = state,
                                        Action = action,
                                        RemoteIP = s2,
                                        TimeFrom = s[0],
                                        TimeTo = s[1]
                                    });
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
                string state = "", action = "";
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
                result.Add(new Customer()
                {
                    STT = int.Parse(dr.Cells["STT"].Value.ToString()),
                    NameRule = dr.Cells["NameRule"].Value.ToString(),
                    State = state,
                    Action = action,
                    RemoteIP = dr.Cells["RemoteIP"].Value.ToString(),
                    TimeFrom = dr.Cells["TimeFrom"].Value.ToString(),
                    TimeTo = dr.Cells["TimeTo"].Value.ToString()
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
        public class Customer
        {
            public int STT { get; set; }
            public bool Statebool { get; set; }
            public string NameRule { get; set; }
            public string State { get; set; }
            public string Action { get; set; }
            public string RemoteIP { get; set; }
            public string TimeFrom { get; set; }
            public string TimeTo { get; set; }
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Detail = GetDataDel();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Detail = GetDataDel();
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditForm.NameRule = Detail[0].NameRule;
            EditForm.State = Detail[0].State;
            EditForm.Action = Detail[0].Action;
            EditForm.Program = "Any";
            EditForm.Profile = "Domain, Private, Public";
            EditForm.Protocol = "Any";
            EditForm.LocalIP = "Any";
            EditForm.RemoteIP = Detail[0].RemoteIP;
            EditForm.LocalPort = "Any";
            EditForm.RemotePort = "Any";
            EditForm f = new EditForm();
            f.editform1();
            f.Show();
            f.send = new EditForm.SendMessage(Reload);
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(1, 226, 230);
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
            stt = 0;
            dataSource = GetDataSource();
            dataGridView1.DataSource = dataSource;
            dataGridView1.Rows[0].Selected = false;
            for (int i = 0; i < Detail.Count; i++)
            {
                dataGridView1.Rows[Detail[i].STT].Selected = true;
            }
        }

        private void menuEnable_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Detail.Count; i++)
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                var rule = firewallPolicy.Rules.Item(Detail[i].NameRule);
                rule.Enabled = true;
            }
            stt = 0;
            dataSource = GetDataSource();
            dataGridView1.DataSource = dataSource;
            dataGridView1.Rows[0].Selected = false;
            for (int i = 0; i < Detail.Count; i++)
            {
                dataGridView1.Rows[Detail[i].STT].Selected = true;
            }
        }

        private void menuBlock_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Detail.Count; i++)
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                var rule = firewallPolicy.Rules.Item(Detail[i].NameRule);
                rule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            }
            stt = 0;
            dataSource = GetDataSource();
            dataGridView1.DataSource = dataSource;
            dataGridView1.Rows[0].Selected = false;
            for (int i = 0; i < Detail.Count; i++)
            {
                dataGridView1.Rows[Detail[i].STT].Selected = true;
            }
        }

        private void menuAllow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Detail.Count; i++)
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                var rule = firewallPolicy.Rules.Item(Detail[i].NameRule);
                rule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            }
            stt = 0;
            dataSource = GetDataSource();
            dataGridView1.DataSource = dataSource;
            dataGridView1.Rows[0].Selected = false;
            for (int i = 0; i < Detail.Count; i++)
            {
                dataGridView1.Rows[Detail[i].STT].Selected = true;
            }
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            AddRuleForm.kt = 2;
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
                dataGridView1.Rows[Detail[i].STT].Selected = true;
            }
        }

        private void menuProperties_Click(object sender, EventArgs e)
        {
            EditForm.NameRule = Detail[0].NameRule;
            EditForm.State = Detail[0].State;
            EditForm.Action = Detail[0].Action;
            EditForm.Program = "Any";
            EditForm.Profile = "Domain, Private, Public";
            EditForm.Protocol = "Any";
            EditForm.LocalIP = "Any";
            EditForm.RemoteIP = Detail[0].RemoteIP;
            EditForm.LocalPort = "Any";
            EditForm.RemotePort = "Any";
            EditForm f = new EditForm();
            f.editform1();
            f.Show();
            f.send = new EditForm.SendMessage(Reload);
        }
    }
}