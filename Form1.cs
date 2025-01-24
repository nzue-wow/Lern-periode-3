﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalender.besser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }
         
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt1.Text = monthCalendar1.SelectionStart.ToString();
        }
    }
}
