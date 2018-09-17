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
    public partial class RuleProfileForm : Form
    {
        public RuleProfileForm()
        {
            InitializeComponent();
            GetProfile();
        }
        public void GetProfile()
        {
            if (cbDomain.Checked == true && cbPrivate.Checked == true && cbPublic.Checked == true)
            {
                AddRuleForm.Profile = 7;
            }
            if (cbDomain.Checked == false && cbPrivate.Checked == true && cbPublic.Checked == true)
            {
                AddRuleForm.Profile = 6;
            }
            if (cbDomain.Checked == true && cbPrivate.Checked == false && cbPublic.Checked == true)
            {
                AddRuleForm.Profile = 5;
            }
            if (cbDomain.Checked == true && cbPrivate.Checked == true && cbPublic.Checked == false)
            {
                AddRuleForm.Profile = 3;
            }
            if (cbDomain.Checked == false && cbPrivate.Checked == false && cbPublic.Checked == true)
            {
                AddRuleForm.Profile = 4;
            }
            if (cbDomain.Checked == false && cbPrivate.Checked == true && cbPublic.Checked == false)
            {
                AddRuleForm.Profile = 2;
            }
            if (cbDomain.Checked == true && cbPrivate.Checked == false && cbPublic.Checked == false)
            {
                AddRuleForm.Profile = 1;
            }
        }

        private void cbPrivate_CheckedChanged(object sender, EventArgs e)
        {
            GetProfile();
        }
    }
}
