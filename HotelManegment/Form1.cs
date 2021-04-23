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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "t" && textBox2.Text == "t")
            {
               
                Form2 fm2 = new Form2();
                fm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password", "Access Denide", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
