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

        }
        public void ShowEnglish()
        {

        }
        public void Loaddata(int ID)
        {
            dataGridView1.DataSource = IPSourceDAO.LoadAllDataIPSource(ID);
            dataGridView1.Columns["Month"].Visible = false;
            dataGridView1.Columns["Year"].Visible = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells["Day"].Value = dataGridView1.Rows[i].Cells["Day"].Value.ToString() + "/" + dataGridView1.Rows[i].Cells["Month"].Value.ToString() + "/" + dataGridView1.Rows[i].Cells["Year"].Value.ToString(); ;
            }
        }
    }
}
