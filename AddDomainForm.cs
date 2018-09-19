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
    public partial class AddDomainForm : Form
    {
        public AddDomainForm()
        {
            InitializeComponent();
            int Hour = DateTime.Now.Hour;
            int HourTo = Hour + 1;
            int Minute = DateTime.Now.Minute;
            //if (Hour <= 12)
            //{
            //    cbHourFrom.Text = Hour.ToString();
            //    cbAPFrom.Text = "AM";
            //}
            //else
            //{
            //    cbHourFrom.Text = (Hour - 12).ToString();
            //    cbAPFrom.Text = "PM";
            //}
            //if (HourTo <= 12)
            //{
            //    cbHourTo.Text = HourTo.ToString();
            //    cbAPFrom.Text = "AM";
            //}
            //else
            //{
            //    cbHourTo.Text = (HourTo - 12).ToString();
            //    cbAPFrom.Text = "PM";
            //}
            cbMinuteFrom.Text = Minute.ToString();
            cbMinuteTo.Text = Minute.ToString();
        }

    }
}
