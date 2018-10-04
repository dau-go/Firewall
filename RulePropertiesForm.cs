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
            label3.Text = "Tên quy tắc:";
            label4.Text = "Miêu tả";
            label5.Text = "Hoạt động:";
            rbAllow.Text = "Cho phép";
            rbBlock.Text = "Không cho phép";
        }
        public void ShowEnglish()
        {
            label3.Text = "Name of the rule:";
            label4.Text = "Description:";
            label5.Text = "Action:";
            rbAllow.Text = "Allow";
            rbBlock.Text = "Block";
        }
        public void LoadNext()
        {
            AddRuleForm.NameRule = txtName.Text;
            AddRuleForm.Description = txtDescription.Text;
            if (rbAllow.Checked == true)
            {
                AddRuleForm.Action = 1;
            }
            else
            {
                AddRuleForm.Action = 0;
            }
        }

        private void rbAllow_CheckedChanged(object sender, EventArgs e)
        {
            LoadNext();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            LoadNext();
        }
    }
}
