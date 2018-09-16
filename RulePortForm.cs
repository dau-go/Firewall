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
            if(rbTCP.Checked==true)
            {
                AddRuleForm.Protocol = 6;
            }
            else
            {
                AddRuleForm.Protocol = 17;
            }
            if(rbAllPort.Checked==true)
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
        }

        private void rbSpecPort_CheckedChanged(object sender, EventArgs e)
        {
            txtPort.Enabled = true;
        }
    }
}
