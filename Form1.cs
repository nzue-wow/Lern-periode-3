using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP3
{
    public partial class Form1 : Form
    {
        public static int _year, _month;
        public Form1(string day)
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            label8.Text = monthName.ToUpper() + " " + year;

            DateTime startofTheMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int startDayOfWeek = (int)startofTheMonth.DayOfWeek; // 0 = Sunday, 1 = Monday, ...

            // Add blank controls for days of the previous week
            for (int i = 0; i < startDayOfWeek; i++)
            {
                UserControlday1 uc = new UserControlday1(" ");
                flowLayoutPanel1.Controls.Add(uc);
            }


            // Add controls for each day of the month
            for (int i = 1; i <= daysInMonth; i++)
            {
                UserControlday1 uc = new UserControlday1(i.ToString());
                flowLayoutPanel1.Controls.Add(uc);
            }
        }


    }

}

