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
    public partial class RuleTypeForm : Form
    {
        public delegate void SendMessage(int rb);
        public SendMessage send;
        public RuleTypeForm()
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
            label1.Text = "Bạn muốn tạo loại quy tắc nào?";
            label2.Text = "Quy tắc kiểm soát kết nối cho một chương trình";
            label3.Text = "Quy tắc kiểm soát kết nối cho cổng TCP hoặc UDP";
            label5.Text = "Quy tắc tùy chỉnh";
            rbProgram.Text ="Chương trình";
            rbPort.Text = "Cổng";
            rbCustom.Text = "Tùy chỉnh";
        }
        public void ShowEnglish()
        {
            label1.Text = "What type of rule would you like to create?";
            label2.Text = "Rule that controls connection for a program";
            label3.Text = "Rule that controls connection for a TCP or UDP port";
            label5.Text = "Custom rule";
            rbProgram.Text = "Program";
            rbPort.Text = "Port";
            rbCustom.Text = "Custom";
        }

        private void rbProgram_CheckedChanged(object sender, EventArgs e)
        {
            send(1);
        }

        private void rbPort_CheckedChanged(object sender, EventArgs e)
        {
            send(2);
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            send(3);
        }
    }
}
