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
            label1.Text = "Áp dụng khi máy tính được kết nối với tên miền của nó.";
            label2.Text = "Áp dụng khi máy tính được kết nối với vị trí mạng bảo mật.";
            label3.Text = "Áp dụng khi máy tính được kết nối với vị trí mạng công khai.";
            cbDomain.Text = "Tên Miền";
            cbPrivate.Text = "Bảo Mật";
            cbPublic.Text = "Công Khai";
        }
        public void ShowEnglish()
        {
            label1.Text = "Applies when a computer is connected to its corporate domain.";
            label2.Text = "Applies when a computer is connected to private network location.";
            label3.Text = "Applies when a computer is connectied to public network location.";
            cbDomain.Text = "Domain";
            cbPrivate.Text = "Private";
            cbPublic.Text = "Public";
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
