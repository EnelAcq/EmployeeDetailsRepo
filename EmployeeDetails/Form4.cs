using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDetails
{
    public partial class Form4 : Form
    {
        public Form4(string l2,string l3,string l4,string l5,string l6,string l7)
        {
            InitializeComponent();
            label2.Text = l2;
            label3.Text = l3;
            label4.Text = l4;
            label5.Text = l5;
            label6.Text = l6;
            label7.Text = l7;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
