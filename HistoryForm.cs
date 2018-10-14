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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }
        public void ShowTiengViet()
        {
            button1.Text = "Xóa Lịch Sử";
            dataGridView1.Columns["Name"].HeaderText = "Tên Máy";
            dataGridView1.Columns["Day"].HeaderText = "Ngày";
            dataGridView1.Columns["IPSource"].HeaderText = "Địa Chỉ IP";
            dataGridView1.Columns["Time"].HeaderText = "Thời Gian";
        }
        public void ShowEnglish()
        {
            button1.Text = "Delete";
            dataGridView1.Columns["Name"].HeaderText = "Name Computer";
            dataGridView1.Columns["Day"].HeaderText = "Day";
            dataGridView1.Columns["IPSource"].HeaderText = "IP Address";
            dataGridView1.Columns["Time"].HeaderText = "Time";
        }
        int id;
        public void Loaddata(int ID)
        {
            id = ID;
            Detail = Getdata();
            dataGridView1.DataSource = Detail;
            dataGridView1.Columns["Month"].Visible = false;
            dataGridView1.Columns["Year"].Visible = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells["Day"].Value = dataGridView1.Rows[i].Cells["Day"].Value.ToString() + "/" + dataGridView1.Rows[i].Cells["Month"].Value.ToString() + "/" + dataGridView1.Rows[i].Cells["Year"].Value.ToString(); ;
            }
            if (FirewallForm.Lang == 0)
            {
                ShowTiengViet();
            }
            else
            {
                ShowEnglish();
            }
        }
        BindingList<Customer> Detail;
        public BindingList<Customer> Getdata()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            DataTable dt = IPSourceDAO.LoadAllDataIPSource(id);
            DataTable dt1 = ComputerDAO.LoadData();
            DataRow[] re = dt.Select("");
            DataRow[] re1 = dt1.Select("");
            foreach (DataRow row in re)
            {
                foreach (DataRow row1 in re1)
                {
                    string s = "";
                    if (row["IPSource"].ToString() == row1["IP"].ToString())
                    {
                        s = row1["Name"].ToString();
                    }
                    result.Add(new Customer()
                    {
                        Name = s,
                        Day = row["Day"].ToString(),
                        Month = row["Month"].ToString(),
                        Year = row["Year"].ToString(),
                        IPSource = row["IPSource"].ToString(),
                        Time = row["Time"].ToString(),
                    });
                }
            }
            return result;
        }
        public class Customer
        {
            public string Name { get; set; }
            public string Day { get; set; }
            public string Month { get; set; }
            public string Year { get; set; }
            public string IPSource { get; set; }
            public string Time { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (FirewallForm.Lang == 0)
            {
                result = MessageBox.Show("Bạn có chắc chắn muốn xóa? ", "Tường Lửa", MessageBoxButtons.YesNo);
            }
            else
            {
                result = MessageBox.Show("Are you sure you want to delete?", "Firewall", MessageBoxButtons.YesNo);
            }
            if (DialogResult.Yes == result)
            {
                IPSourceDAO.DelIPSurce(id);
                this.Close();
            }
        }
    }
}
