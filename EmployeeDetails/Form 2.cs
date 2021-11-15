using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDetails
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form_2_Load(object sender, EventArgs e)
        {

        }

        private void age_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

    


        private void button1_Click(object sender, EventArgs e)
        {
            if(fname.Text.Length == 0)
            {
                MessageBox.Show("Please enter first name to fully register", "First Name not Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (lname.Text.Length == 0)
            {
                MessageBox.Show("Please enter last name to fully register", "Last Name not Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (age.Text.Length == 0)
            {
                MessageBox.Show("Please enter age to fully register", "Age not Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (gender.SelectedItem==null)
            {
                MessageBox.Show("Please select gender to fully register", "Gender not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (email.Text.Length == 0)
            {
                MessageBox.Show("Please enter  email to fully register", "Email not Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (address.Text.Length == 0)
            {
                MessageBox.Show("Please enter  address to fully register", "Address not Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (phonenumber.Text.Length == 0)
            {
                MessageBox.Show("Please enter  phone number to fully register", "Phone not Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (dept.SelectedItem == null)
            {
                MessageBox.Show("Please select department to fully register", "Department not Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(username.Text.Length == 0)
            {
                MessageBox.Show("Please enter valid username to fully register", "Username not Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(password.Text.Length == 0 )
            {
                MessageBox.Show("Please enter valid password to fully register", "Password not Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlCommand cmd;

                string connectionString = @"Data Source=DESKTOP-8FEISE4;Initial Catalog=VsProject;user=sa;password=password@123";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();


                cmd = new SqlCommand("Insert into EmployeeDetails( UserName,Password,FirstName,LastName,Age,Gender,Email,Address,PhoneNumber,Department) values(@UN,@PS,@FN,@LN,@AG,@GEN,@EM,@ADD,@PN,@DEP)", con);


                cmd.Parameters.AddWithValue("@UN", username.Text);
                cmd.Parameters.AddWithValue("@PS", password.Text);
                cmd.Parameters.AddWithValue("@FN", fname.Text);
                cmd.Parameters.AddWithValue("@LN", lname.Text);
                cmd.Parameters.AddWithValue("@AG", age.Text);
                cmd.Parameters.AddWithValue("@GEN", gender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@EM", email.Text);
                cmd.Parameters.AddWithValue("@ADD", address.Text);
                cmd.Parameters.AddWithValue("@PN", phonenumber.Text);
                cmd.Parameters.AddWithValue("@DEP", dept.SelectedItem.ToString());
                cmd.ExecuteNonQuery();

                this.Hide();

                Form3 form3 = new Form3();
                form3.Show();

             }









        }

        private void dept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
