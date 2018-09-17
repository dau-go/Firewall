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
