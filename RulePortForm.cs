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
    public partial class RulePortForm : Form
    {
        public RulePortForm()
        {
            InitializeComponent();
            if (AddRuleForm.kt == 1)
            {
                rbAllPort.Text = "All remote ports";
                rbSpecPort.Text = "Specific remote ports:";
                label3.Text = "Does this rule apply to all remote ports or specific local ports?";
            }
            GetPort();
        }
        public void GetPort()
        {
            if (rbTCP.Checked == true)
            {
                AddRuleForm.Protocol = 6;
            }
            else
            {
                AddRuleForm.Protocol = 17;
            }
            if (rbAllPort.Checked == true)
            {
                AddRuleForm.LocalPort = "Any";
            }
            else
            {
                AddRuleForm.LocalPort = txtPort.Text;
            }

        }

        private void rbAllPort_CheckedChanged(object sender, EventArgs e)
        {
            txtPort.Enabled = false;
            GetPort();
        }

        private void rbSpecPort_CheckedChanged(object sender, EventArgs e)
        {
            txtPort.Enabled = true;
        }

        private void rbTCP_CheckedChanged(object sender, EventArgs e)
        {
            GetPort();
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            GetPort();
        }
    }
}
