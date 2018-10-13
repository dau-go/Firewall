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
using DAO;
using DTO;

namespace WinformsExample
{
    public partial class WebsiteTrackingForm : Form
    {
        PropertiesWebsiteTrackingForm f = new PropertiesWebsiteTrackingForm();
        IPDestinationDTO IP = new IPDestinationDTO();
        public WebsiteTrackingForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = IPDestinationDAO.LoadDataIPDestination();
            if (FirewallForm.Lang == 0)
            {
                ShowTiengViet();
            }
            else
            {
                ShowEnglish();
            }
            try
            {
                dataGridView1.Rows[0].Selected = true;
            }
            catch
            {

            }
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Statebool"].HeaderText = "";
            dataGridView1.Columns["Statebool"].Width = 20;
            dataGridView1.Columns["Name"].Width = 250;
            dataGridView1.Columns["Action"].Width = 85;
            dataGridView1.Columns["IPDestination"].Width = 150;
        }
        public void ShowTiengViet()
        {
            dataGridView1.Columns["Name"].HeaderText = "Tên Quy Tắc";
            dataGridView1.Columns["State"].HeaderText = "Trạng Thái";
            dataGridView1.Columns["Action"].HeaderText = "Hành Động";
            dataGridView1.Columns["IPDestination"].HeaderText = "IP Đích";
        }
        public void ShowEnglish()
        {
            dataGridView1.Columns["Name"].HeaderText = "Name Rules";
            dataGridView1.Columns["State"].HeaderText = "State";
            dataGridView1.Columns["Action"].HeaderText = "Action";
            dataGridView1.Columns["IPDestination"].HeaderText = "IPDestination";
        }

        public void Getdata()
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            IP.ID = int.Parse(dr.Cells["ID"].Value.ToString());
            IP.Statebool = bool.Parse(dr.Cells["Statebool"].Value.ToString());
            IP.Name = dr.Cells["Name"].Value.ToString();
            IP.State = dr.Cells["State"].Value.ToString();
            IP.Action = dr.Cells["Action"].Value.ToString();
            IP.IPDestination = dr.Cells["IPDestination"].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Getdata();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Getdata();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Getdata();
        }

        private void dataGridView1_MouseCaptureChanged(object sender, EventArgs e)
        {
            Getdata();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Getdata();
            f.ShowData(IP);
            f.Show();
            f.sen = new PropertiesWebsiteTrackingForm.Apply(Reload);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Getdata();
            f.ShowData(IP);
            f.Show();
            f.sen = new PropertiesWebsiteTrackingForm.Apply(Reload);
        }
        public void Reload()
        {
            int d = 0;
            dataGridView1.DataSource = IPDestinationDAO.LoadDataIPDestination();
            dataGridView1.ClearSelection();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (IP.ID == int.Parse(dataGridView1.Rows[i].Cells["ID"].Value.ToString()))
                {
                    d = i;
                    break;
                }
            }
            dataGridView1.Rows[d].Selected = true;
        }
        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(1, 226, 230);
            }
        }
        private void dataGridView1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {

        }
        public void Delete()
        {
            IPDestinationDAO.DelIPDestination(IP);
        }
    }
}
