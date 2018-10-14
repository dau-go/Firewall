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
using Extensions;
using DAO;
using DTO;

namespace WinformsExample
{
    public partial class ComputerForm : Form
    {
        public ComputerForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = ComputerDAO.LoadData();
            try
            {
                dataGridView1.Rows[0].Selected = true;
                Detail = Getdata();
            }
            catch
            {

            }
            if (FirewallForm.Lang == 0)
            {
                ShowTiengViet();
            }
            else
            {
                ShowEnglish();
            }
            textBox1.ForeColor = Color.Gray;
        }
        public void ShowTiengViet()
        {
            this.Text = "Quản Lý Máy Tính";
            textBox1.Init("Tên máy");
            textBox2.Init("Địa chỉ IP");
            dataGridView1.Columns["Name"].HeaderText = "Tên Máy";
            dataGridView1.Columns["IP"].HeaderText = "Địa Chỉ IP";
            button1.Text = "Thêm máy";
            button2.Text = "Xóa máy";
        }
        public void ShowEnglish()
        {
            this.Text = "Computer Manager";
            textBox1.Init("Name Computer");
            textBox2.Init("IP Address");
            dataGridView1.Columns["Name"].HeaderText = "Name Computer";
            dataGridView1.Columns["IP"].HeaderText = "IP Address";
            button1.Text = "Add";
            button2.Text = "Delete";
        }
        public bool ValidateIPv4Subnet()
        {
            if (textBox2.Text == null)
            {
                return false;
            }

            string[] splitValues = textBox2.Text.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }
            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text!="Tên Máy"||textBox1.Text!="Name Computer"|| textBox1.Text != "") &&(textBox2.Text!="Địa Hỉ IP"||textBox2.Text!="IP Address"||textBox1.Text != ""))
            {
                if(ValidateIPv4Subnet()==true)
                {
                    ComputerDTO cm = new ComputerDTO();
                    cm.Name = textBox1.Text;
                    cm.IP = textBox2.Text;
                    if(ComputerDAO.AddComputer(cm)==true)
                    {
                        dataGridView1.DataSource = ComputerDAO.LoadData();
                        if (FirewallForm.Lang == 0)
                        {
                            textBox1.Init("Tên máy");
                            textBox2.Init("Địa chỉ IP");
                        }
                        else
                        {
                            textBox1.Init("Name Computer");
                            textBox2.Init("IP Address");
                        }
                    }
                    else
                    {
                        if(FirewallForm.Lang==0)
                        {
                            MessageBox.Show("Tên máy tính đã tồn tại", "Firewall");
                        }
                        else
                        {
                            MessageBox.Show("Computer name already exists", "Firewall");
                        }
                    }
                }
            }
        }
        BindingList<Customer> Detail;
        public BindingList<Customer> Getdata()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[i];
                result.Add(new Customer()
                {
                    Name = dr.Cells["Name"].Value.ToString(),
                    IP = dr.Cells["IP"].Value.ToString(),
                });
            }
            return result;
        }
        public class Customer
        {
            public string Name { get; set; }
            public string IP { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<Detail.Count;i++)
            {
                ComputerDAO.DelComputer(Detail[i].Name);
            }
            dataGridView1.DataSource = ComputerDAO.LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Detail = Getdata();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Detail = Getdata();
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Detail = Getdata();
        }
    }
}
