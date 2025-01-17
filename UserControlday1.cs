using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP3
{
    public partial class UserControlday1 : UserControl
    {
        string _day, date, weekdate;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public UserControlday1(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = day;
        }

        private void UserControlday1_Load(object sender, EventArgs e)
        {

        }
    }
}
