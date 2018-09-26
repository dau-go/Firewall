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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            GeneralForm f = new GeneralForm();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(f);
            f.Visible = true;
            ProgramAndProfileForm f1 = new ProgramAndProfileForm();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(f1);
            f1.Visible = true;
            ScopeForm f3 = new ScopeForm();
            f3.TopLevel = false;
            f3.FormBorderStyle = FormBorderStyle.None;
            f3.Dock = DockStyle.Fill;
            tabPage4.Controls.Add(f3);
            f3.Visible = true;
        }
    }
}
