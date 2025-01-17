using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarLP3.try2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;

            //First day of the month

            DateTime startofthemonth = new DateTime(now.Year, now.Month,1);

            //count of days of the month

            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int dayoftheweek = ConvertToInt32(startofthemonth.DayOfWeek.ToString("d"));


        }
    }
}
