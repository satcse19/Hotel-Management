using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManegment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checkin fm2 = new Checkin();
            fm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Checkou fm2 = new Checkou();
            fm2.Show();
            this.Hide();
        }
    }
}
