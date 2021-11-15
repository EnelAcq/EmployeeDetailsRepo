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
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
           
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
             
            
           if(uname.Text.Length==0)
            {
                MessageBox.Show("Please enter username to login", "No Username Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           else if(pword.Text.Length==0)
            {
                MessageBox.Show("Please enter password to login", "No Password Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else
            {
                Form2 f2 = new Form2();
                String Firstname;
                String Lastname ;
                String username = uname.Text;
                String password = pword.Text;
                if ((username=="admin") && (password=="password@123"))
                {
                    this.Hide();
                    f2.Show();
                }
                else
                {
                   
                    string conString;
                    SqlConnection connection;
                    conString = @"Data Source=DESKTOP-8FEISE4;Initial Catalog=VsProject;user=sa;password=password@123";
                    connection = new SqlConnection(conString);
                    connection.Open();

                    SqlCommand check_credentials = new SqlCommand("select count(*) from [LoginDetails] where([UserName]=@username) and ([Password]=@password)", connection);
                    check_credentials.Parameters.AddWithValue("@username", username);
                    check_credentials.Parameters.AddWithValue("@password", password);
                    int UserExist = (int)check_credentials.ExecuteScalar();
                     if(UserExist > 0)
                    {
                        
                         
                                                
                        this.Hide();
                        

                        MessageBox.Show("Welcome "+username+"!","Registered Employee",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    { 
                        MessageBox.Show("Invalid Login Credentials", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    connection.Close();
                }
                
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uname.Text = "";
            pword.Text = "";
        }

        
        
    }
}
