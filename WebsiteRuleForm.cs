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
        public WebsiteRuleForm()
        {
            InitializeComponent();
            dataSource = GetDataSource();
            dataGridView1.DataSource = dataSource;
            dataGridView1.Columns["Statebool"].HeaderText = "";
            dataGridView1.Columns["NameRule"].HeaderText = "Name Rules";
            dataGridView1.Columns["Statebool"].Width = 20;
            dataGridView1.Columns["RemoteIP"].HeaderText = "Remote Address";
            dataGridView1.Columns["TimeFrom"].HeaderText = "Time From";
            dataGridView1.Columns["TimeTo"].HeaderText = "Time To";
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
                    string[] s = rule.Description.Split('-');
                    string[] s1 = rule.RemoteAddresses.Split('/', ',');
                    string s2="";
                    for(int i=0;i<s1.Length;i=i+2)
                    {
                        if(s2=="")
                        {
                            s2 = s1[i];
                        }
                        else
                        {
                            s2 = s2 + "," + s1[i];
                        }
                    }
                    result.Add(new Customer()
                    {
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
            return result;
        }
        public class Customer
        {
            public bool Statebool { get; set; }
            public string NameRule { get; set; }
            public string State { get; set; }
            public string Action { get; set; }
            public string RemoteIP { get; set; }
            public string TimeFrom { get; set; }
            public string TimeTo { get; set; }
        }
    }
}