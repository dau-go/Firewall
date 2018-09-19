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
        }
        public void Header(int i)
        {
            if (dataSource.Count() >= 25)
            {
                if (i == 0)
                {
                    dataGridView1.Columns["NameRule"].Width = 220;
                    dataGridView1.Columns["State"].Width = 50;
                    dataGridView1.Columns["Action"].Width = 50;
                }
                else
                {
                    dataGridView1.Columns["NameRule"].Width = 265;
                    dataGridView1.Columns["State"].Width = 60;
                    dataGridView1.Columns["Action"].Width = 60;
                }
            }
            else
            {
                if (i == 0)
                {
                    dataGridView1.Columns["NameRule"].Width = 220;
                    dataGridView1.Columns["State"].Width = 50;
                    dataGridView1.Columns["Action"].Width = 50;
                }
                else
                {
                    dataGridView1.Columns["NameRule"].Width = 263;
                    dataGridView1.Columns["State"].Width = 60;
                    dataGridView1.Columns["Action"].Width = 60;
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
                if (rule.Direction.ToString() == "NET_FW_RULE_DIR_OUT")
                {
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
                        result.Add(new Customer()
                        {
                            Statebool = rule.Enabled,
                            NameRule = rule.Name,
                            State = state,
                            Action = action,
                            TimeFrom = s[0],
                            TimeTo=s[1]
                        });
                    }
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
            public string TimeFrom { get; set; }
            public string TimeTo { get; set; }
        }
    }
}