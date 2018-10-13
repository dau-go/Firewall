using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace WinformsExample
{
    public partial class PropertiesWebsiteTrackingForm : Form
    {
        public delegate void Apply();
        public Apply sen;
        IPDestinationDTO IP = new IPDestinationDTO();
        public PropertiesWebsiteTrackingForm()
        {
            InitializeComponent();
        }
        public void ShowData(IPDestinationDTO show)
        {
            IP = show;
            labName.Text = show.Name;
            if (show.IPDestination.Contains(','))
            {
                string[] s = show.IPDestination.Split(',');
                for (int i = 0; i < s.Length; i++)
                {
                    listView.Items.Add(s[i]);
                }
            }
            else
            {
                listView.Items.Add(show.IPDestination);
            }
            if (show.Statebool == true)
            {
                ckState.Checked = true;
            }
            else
            {
                ckState.Checked = false;
            }
            if (show.Action == "Theo dõi")
            {
                rbAllow.Checked = true;
            }
            else
            {
                rbBlock.Checked = true;
            }
            int month = DateTime.Now.Month;
            dataGridView1.DataSource = IPSourceDAO.LoadDataIPSource(show, month);
            if (month == 1)
            {
                dataGridView2.DataSource = IPSourceDAO.LoadDataIPSource(show, 12);
                dataGridView3.DataSource = IPSourceDAO.LoadDataIPSource(show, 1);
            }
            else if (month == 2)
            {
                dataGridView2.DataSource = IPSourceDAO.LoadDataIPSource(show, 1);
                dataGridView3.DataSource = IPSourceDAO.LoadDataIPSource(show, 12);
            }
            else
            {
                dataGridView2.DataSource = IPSourceDAO.LoadDataIPSource(show, month - 1);
                dataGridView3.DataSource = IPSourceDAO.LoadDataIPSource(show, month - 2);
            }
            dataGridView1.Columns["IPSource"].Width = 144;
            dataGridView2.Columns["IPSource"].Width = 144;
            dataGridView3.Columns["IPSource"].Width = 144;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView2.Columns["ID"].Visible = false;
            dataGridView3.Columns["ID"].Visible = false;
            dataGridView1.Columns["Month"].Visible = false;
            dataGridView2.Columns["Month"].Visible = false;
            dataGridView3.Columns["Month"].Visible = false;
            dataGridView1.Columns["IPDestination"].Visible = false;
            dataGridView2.Columns["IPDestination"].Visible = false;
            dataGridView3.Columns["IPDestination"].Visible = false;
        }

        private void ckState_CheckedChanged(object sender, EventArgs e)
        {
            if (ckState.Checked == true)
            {
                if (IP.Statebool == true)
                {
                    btnApply.Enabled = false;
                }
                else
                {
                    btnApply.Enabled = true;
                }
            }
            else
            {
                if (IP.Statebool == false)
                {
                    btnApply.Enabled = false;
                }
                else
                {
                    btnApply.Enabled = true;
                }
            }
        }

        private void rbAllow_CheckedChanged(object sender, EventArgs e)
        {
            if (IP.Action == "Theo dõi")
            {
                btnApply.Enabled = false;
            }
            else
            {
                btnApply.Enabled = true;
            }
        }

        private void rbBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (IP.Action == "Không theo dõi")
            {
                btnApply.Enabled = false;
            }
            else
            {
                btnApply.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnApply_Click(sender, e);
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            IP.Statebool = ckState.Checked;
            if (ckState.Checked == true)
            {
                IP.State = "On";
            }
            else
            {
                IP.State = "Off";
            }
            if(rbAllow.Checked==true)
            {
                IP.Action = "Theo dõi";
            }
            else
            {
                IP.Action = "Không theo dõi";
            }
            IPDestinationDAO.EditIPDestination(IP);
            sen();
            btnApply.Enabled = false;
        }
    }
}
