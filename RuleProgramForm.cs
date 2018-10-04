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
    public partial class RuleProgramForm : Form
    {
        public RuleProgramForm()
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
            label3.Text = "Quy tắc áp dụng cho tất cả các chương trình trên máy tính";
            rbAllProgram.Text = "Tất cả chương trình";
            rbThisProgram.Text = "Đường dẫn chương trình:";
            btnBrowes.Text = "Trình duyệt";
        }
        public void ShowEnglish()
        {
            label3.Text = "Rules apply to all programs on the computer";
            rbAllProgram.Text = "All program";
            rbThisProgram.Text = "This program path:";
            btnBrowes.Text = "Browser...";
        }
        public void GetProgram()
        {
            if (rbAllProgram.Checked == true)
            {
                AddRuleForm.Program = "Any";
            }
            else
            {
                AddRuleForm.Program = txtProgram.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetProgram();
        }

        private void rbAllProgram_CheckedChanged(object sender, EventArgs e)
        {
            txtProgram.Enabled = false;
            btnBrowes.Enabled = false;
            GetProgram();
        }

        private void rbThisProgram_CheckedChanged(object sender, EventArgs e)
        {
            txtProgram.Enabled = true;
            btnBrowes.Enabled = true;
            GetProgram();
        }

        private void btnBrowes_Click(object sender, EventArgs e)
        {
            Open.ShowDialog();
            txtProgram.Text = Open.FileName;
            GetProgram();
        }
    }
}
