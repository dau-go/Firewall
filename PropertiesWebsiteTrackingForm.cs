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
            this.Text = "Thuộc Tính";
            tabPage1.Text = "Thông Tin Chung";
            tabPage2.Text = "Lịch Sử";
            groupBox1.Text = "Thông Tin Chung";
            groupBox2.Text = "Hành Động";
            groupBox3.Text = "Lịch Sử";
            label1.Text = "Tên:";
            label3.Text = "IP Theo Dõi";
            ckState.Text = "Bật";
            rbAllow.Text = "Theo dõi";
            rbBlock.Text = "Không theo dõi";
            label5.Text = "Tháng hiện tại:";
            btnApply.Text = "Áp dụng";
            btnOK.Text = "Đồng Ý";
            btnCancel.Text = "Hủy";
            btnAllHistory.Text = "Tất cả lịch sử";
        }
        public void ShowEnglish()
        {
            this.Text = "Properties";
            tabPage1.Text = "General Information";
            tabPage2.Text = "History";
            groupBox1.Text = "General Information";
            groupBox2.Text = "Action";
            groupBox3.Text = "History";
            label1.Text = "Name:";
            label3.Text = "IP Tracking";
            ckState.Text = "On";
            rbAllow.Text = "Tracking";
            rbBlock.Text = "Don't tracking";
            label5.Text = "This month:";
            btnApply.Text = "Apply";
            btnOK.Text = "Ok";
            btnCancel.Text = "Cancel";
            btnAllHistory.Text = "All History";
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
            dataGridView1.Columns["IPSource"].Width = 200;
            dataGridView1.Columns["Time"].Width = 145;
            dataGridView1.Columns["IDSource"].Visible = false;
            dataGridView1.Columns["IDDestination"].Visible = false;
            dataGridView1.Columns["Month"].Visible = false;
            dataGridView1.Columns["IPDestination"].Visible = false;
            if (FirewallForm.Lang == 0)
            {
                dataGridView1.Columns["IPSource"].HeaderText = "IP Nguồn";
                dataGridView1.Columns["Time"].HeaderText = "Thời Gian";
            }
            else
            {
                dataGridView1.Columns["IPSource"].HeaderText = "IP Source";
                dataGridView1.Columns["Time"].HeaderText = "Time";
            }
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
            if (rbAllow.Checked == true)
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

        private void btnAllHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
