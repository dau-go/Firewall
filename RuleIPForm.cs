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
    public partial class RuleIPForm : Form
    {
        public RuleIPForm()
        {
            InitializeComponent();
        }
        //Local IP
        private void rbAllLocal_CheckedChanged(object sender, EventArgs e)
        {
            txtLocal.Enabled = false;
            btnAddLocal.Enabled = false;
            btnEditLocal.Enabled = false;
            btnDelLocal.Enabled = false;
        }

        private void rbIPLocal_CheckedChanged(object sender, EventArgs e)
        {
            txtLocal.Enabled = true;
            btnAddLocal.Enabled = true;
        }
    }
}
