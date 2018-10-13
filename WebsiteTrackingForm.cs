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
                Detail = GetDataDel();
            }
            catch
            {

            }
            dataGridView1.Columns["IDDestination"].Visible = false;
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
            menuDisable.Text = "Tắt";
            menuEnable.Text = "Bật";
            menuAllow.Text = "Theo dõi";
            menuBlock.Text = "Ngừng theo dõi";
            menuAdd.Text = "Thêm mới quy tắc";
            menuDel.Text = "Xóa quy tắc";
            menuProperties.Text = "Thuộc Tính";
        }
        public void ShowEnglish()
        {
            dataGridView1.Columns["Name"].HeaderText = "Name Rules";
            dataGridView1.Columns["State"].HeaderText = "State";
            dataGridView1.Columns["Action"].HeaderText = "Action";
            dataGridView1.Columns["IPDestination"].HeaderText = "IPDestination";
            menuDisable.Text = "Turn Off";
            menuEnable.Text = "Turn On";
            menuAllow.Text = "Tracking";
            menuBlock.Text = "Stop tracking";
            menuAdd.Text = "Add New Rule";
            menuDel.Text = "Delete Rule";
            menuProperties.Text = "Properties";
        }

        public void Getdata()
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            IP.ID = int.Parse(dr.Cells["IDDestination"].Value.ToString());
            IP.Statebool = bool.Parse(dr.Cells["Statebool"].Value.ToString());
            IP.Name = dr.Cells["Name"].Value.ToString();
            IP.State = dr.Cells["State"].Value.ToString();
            IP.Action = dr.Cells["Action"].Value.ToString();
            IP.IPDestination = dr.Cells["IPDestination"].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Detail = GetDataDel();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Detail = GetDataDel();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Detail = GetDataDel();
        }

        private void dataGridView1_MouseCaptureChanged(object sender, EventArgs e)
        {
            Detail = GetDataDel();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PropertiesWebsiteTrackingForm f = new PropertiesWebsiteTrackingForm();
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
                if (IP.ID == int.Parse(dataGridView1.Rows[i].Cells["IDDestination"].Value.ToString()))
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
        BindingList<Customer> Detail;
        private BindingList<Customer> GetDataDel()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[i];
                result.Add(new Customer()
                {
                    IDDestination = int.Parse(dr.Cells["IDDestination"].Value.ToString()),
                    Statebool = bool.Parse(dr.Cells["Statebool"].Value.ToString()),
                    Name = dr.Cells["Name"].Value.ToString(),
                    State = dr.Cells["State"].Value.ToString(),
                    Action = dr.Cells["Action"].Value.ToString(),
                    IPDestination = dr.Cells["IPDestination"].Value.ToString()
                });
            }
            return result;
        }
        public class Customer
        {
            public int IDDestination { get; set; }
            public bool Statebool { get; set; }
            public string Name { get; set; }
            public string State { get; set; }
            public string Action { get; set; }
            public string IPDestination { get; set; }
        }
        private void dataGridView1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int t = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["IDDestination"].Value.ToString());
            if (Detail.Count > 1)
            {
                for (int i = 0; i < Detail.Count; i++)
                {
                    if (Detail[i].IDDestination == t)
                    {
                        menuProperties.Visible = false;
                        menuDisable.Visible = false;
                        menuEnable.Visible = false;
                        menuAllow.Visible = false;
                        menuBlock.Visible = false;
                        toolStripSeparator3.Visible = false;
                        for (int j = 0; j < Detail.Count; j++)
                        {
                            if (Detail[j].State == "On")
                            {
                                menuDisable.Visible = true;
                            }
                            else
                            {
                                menuEnable.Visible = true;
                            }
                            if (Detail[j].Action == "Theo dõi")
                            {
                                menuBlock.Visible = true;
                            }
                            else
                            {
                                menuAllow.Visible = true;
                            }
                        }
                        e.ContextMenuStrip = contextMenuStrip1;
                        return;
                    }
                }
            }
            dataGridView1.ClearSelection();
            int rowselected1 = e.RowIndex;
            dataGridView1.Rows[rowselected1].Selected = true;
            toolStripSeparator3.Visible = true;
            e.ContextMenuStrip = contextMenuStrip1;
            Detail = GetDataDel();
            menuProperties.Visible = true;
            if (Detail[0].State == "On")
            {
                menuDisable.Visible = true;
                menuEnable.Visible = false;
            }
            else
            {
                menuDisable.Visible = false;
                menuEnable.Visible = true;
            }
            if (Detail[0].Action == "Theo dõi")
            {
                menuAllow.Visible = false;
                menuBlock.Visible = true;
            }
            else
            {
                menuAllow.Visible = true;
                menuBlock.Visible = false;
            }
        }
        public void Delete()
        {
            IPDestinationDAO.DelIPDestination(IP);
        }

        private void menuDisable_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Detail.Count; i++)
            {
                IP.ID = Detail[i].IDDestination;
                IP.Statebool = Detail[i].Statebool;
                IP.State = Detail[i].State;
                IP.Action = Detail[i].Action;
                IP.Statebool = false;
                IP.State = "Off";
                IPDestinationDAO.EditIPDestination(IP);
                Reload();
            }
        }

        private void menuEnable_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Detail.Count; i++)
            {
                IP.ID = Detail[i].IDDestination;
                IP.Statebool = Detail[i].Statebool;
                IP.State = Detail[i].State;
                IP.Action = Detail[i].Action;
                IP.Statebool = true;
                IP.State = "On";
                IPDestinationDAO.EditIPDestination(IP);
                Reload();
            }
        }

        private void menuBlock_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Detail.Count; i++)
            {
                IP.ID = Detail[i].IDDestination;
                IP.Statebool = Detail[i].Statebool;
                IP.State = Detail[i].State;
                IP.Action = Detail[i].Action;
                IP.Action = "Không theo dõi";
                IPDestinationDAO.EditIPDestination(IP);
                Reload();
            }
        }

        private void menuAllow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Detail.Count; i++)
            {
                IP.ID = Detail[i].IDDestination;
                IP.Statebool = Detail[i].Statebool;
                IP.State = Detail[i].State;
                IP.Action = Detail[i].Action;
                IP.Action = "Theo dõi";
                IPDestinationDAO.EditIPDestination(IP);
                Reload();
            }
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            AddRuleForm.kt = 3;
            AddRuleForm f = new AddRuleForm();
            f.ShowDialog();
        }

        private void menuDel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Detail.Count; i++)
            {
                IP.ID = Detail[i].IDDestination;
                Delete();
            }
            dataGridView1.DataSource = IPDestinationDAO.LoadDataIPDestination();
        }

        private void menuProperties_Click(object sender, EventArgs e)
        {
            PropertiesWebsiteTrackingForm f = new PropertiesWebsiteTrackingForm();
            Getdata();
            f.ShowData(IP);
            f.Show();
            f.sen = new PropertiesWebsiteTrackingForm.Apply(Reload);
        }
    }
}
