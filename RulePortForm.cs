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
                if (FirewallForm.Lang == 0)
                {
                    rbAllPort.Text = "Tất cả cổng từ xa";
                    rbSpecPort.Text = "Cổng từ xa cụ thể";
                    label3.Text = "Quy tắc này áp dụng cho tất cả các cổng cục bộ hoặc các cổng từ xa cụ thể";
                }
                else
                {
                    rbAllPort.Text = "All remote ports";
                    rbSpecPort.Text = "Specific remote ports:";
                    label3.Text = "This rule applies to all local ports or specific remote ports";
                }
            }
            else
            {
                if (FirewallForm.Lang == 0)
                {
                    rbAllPort.Text = "Tất cả cổng nội bộ";
                    rbSpecPort.Text = "Cổng nội bộ cụ thể";
                    label3.Text = "Quy tắc này áp dụng cho tất cả các cổng cục bộ hoặc các cổng nội bộ cụ thể";
                }
                else
                {
                    rbAllPort.Text = "All local ports";
                    rbSpecPort.Text = "Specific local ports:";
                    label3.Text = "This rule applies to all local ports or specific local ports";
                }
            }
            GetPort();

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
            label1.Text = "Quy tắc này áp dụng cho TCP hoặc UDP";
            label4.Text = "Ví dụ: 80,443, ...";
        }
        public void ShowEnglish()
        {
            label1.Text = "This rule applies to TCP or UDP";
            label4.Text = "Example: 80,443,...";
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
