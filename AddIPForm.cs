using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WinformsExample
{
    public partial class AddIPForm : Form
    {
        public AddIPForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtSubnet.Enabled = true;
            txtFrom.Enabled = false;
            txtTo.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtSubnet.Enabled = false;
            txtFrom.Enabled = true;
            txtTo.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                IPAddress ipgex = null;
                IPAddress.TryParse(txtSubnet.Text,out ipgex);
                if(ipgex!=null)
                {

                }
                else
                {
                    MessageBox.Show("You must specify a valid address.", "Firewall");
                }
            }
        }
    }
}
