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
