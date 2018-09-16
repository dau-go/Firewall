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

    public partial class RulePropertiesForm : Form
    {
        public RulePropertiesForm()
        {
            InitializeComponent();
        }
        public void LoadNext()
        {
            AddRuleForm.NameRule = txtName.Text;
            AddRuleForm.Description = txtDescription.Text;
            if (rbAllow.Checked == true)
            {
                AddRuleForm.Action = "NET_FW_ACTION_.NET_FW_ACTION_ALLOW";
            }
            else
            {
                AddRuleForm.Action = "NET_FW_ACTION_.NET_FW_ACTION_BLOCK";
            }
        }
    }
}
