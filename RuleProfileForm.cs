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
            AddRuleForm.Profile = 7;
        }
    }
}
