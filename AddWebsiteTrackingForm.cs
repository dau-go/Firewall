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
using System.Net;

namespace WinformsExample
{
    public partial class AddWebsiteTrackingForm : Form
    {
        IPDestinationDTO IP = new IPDestinationDTO();
        public AddWebsiteTrackingForm()
        {
            InitializeComponent();
        }

        private void rbIP_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtIP.Enabled = true;
            IP.Name = txtIP.Text;
        }

        private void rbWeb_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtIP.Enabled = false;
            IP.Name = txtName.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            IP.Name = txtName.Text;
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            IP.Name = txtIP.Text;
            IP.IPDestination = txtIP.Text;
        }
        public bool CheckIP()
        {
            string host = txtName.Text;
            if (host == "") return false;
            IPHostEntry e;
            try
            {
                e = Dns.GetHostEntry(host);
            }
            catch
            {
                return false;
            }
            // Danh sách điạ chỉ IP
            int j = 0;
            string s = "";
            foreach (IPAddress i in e.AddressList)
            {
                if (j == 0)
                {
                    s = i.ToString();
                    j++;
                }
                else
                {
                    s = s + "," + i.ToString();
                }
            }
            IP.IPDestination = s;
            return true;
        }
        public bool ValidateIPv4Subnet()
        {
            if (txtIP.Text == null)
            {
                return false;
            }

            string[] splitValues = txtIP.Text.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }
            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }
        public bool AddRule()
        {
            if (rbIP.Checked == true)
            {
                if (ValidateIPv4Subnet() == false)
                {
                    if (FirewallForm.Lang == 0)
                    {
                        MessageBox.Show("Bạn phải chỉ định địa chỉ hợp lệ.", "Tường Lửa");
                    }
                    else
                    {
                        MessageBox.Show("You must specify a valid address.", "Firewall");
                    }
                    return false;
                }
            }
            else
            {
                if (CheckIP() == false)
                {
                    if (FirewallForm.Lang == 0)
                    {
                        MessageBox.Show("Tên trang web không hợp lệ", "Tường Lửa");
                    }
                    else
                    {
                        MessageBox.Show("Website name is not valid", "Firewall");
                    }
                    return false;
                }
            }
            IP.State = "On";
            IP.Action = "Theo dõi";
            IP.Statebool = true;
            IPDestinationDAO.AddIPDestination(IP);
            return true;
        }
    }
}
