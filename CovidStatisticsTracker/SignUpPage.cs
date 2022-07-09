using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CovidStatisticsTracker
{



    public partial class SignUpPage : Form
    {
       
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void adminID_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminPass_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign_Up_Btn_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source =.\\SQLEXPRESS; Initial Catalog = covidStatsTracker; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string adminID = adminID_txtBox.Text;
            string adminPass = adminPass_txtBox.Text;



            if (adminID_txtBox.Text == "" && adminPass_txtBox.Text == "" && confirmPassBox.Text == "")
            { 
            
                MessageBox.Show("Fields Cannot be left blank!");
            }
            else if(adminPass_txtBox.Text == confirmPassBox.Text)
            {
               
                string Query = "INSERT INTO adminRecord (adminID, adminPass) VALUES ('"+adminID+"', '"+adminPass+"')";
                SqlCommand cmd = new SqlCommand(Query,conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registration Succesfull!");
                new loginForm().Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Registration Failed! Passwords Do not match! Try Again");
                adminPass_txtBox.Text = "";
                confirmPassBox.Text = "";
            }
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            adminID_txtBox.Text = "";
            adminPass_txtBox.Text = "";
            confirmPassBox.Text = "";
            adminID_txtBox.Focus();
        }

        private void confirmPassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginDirect_Click(object sender, EventArgs e)
        {
            new loginForm().Show();
            this.Hide();
        }

        private void showPassCB_CheckedChanged(object sender, EventArgs e)
        {
            if(showPassCB.Checked == true)
            {
                adminPass_txtBox.PasswordChar = '\0';
                confirmPassBox.PasswordChar = '\0';
                

            }
            else
            {
                adminPass_txtBox.PasswordChar = '*';
                confirmPassBox.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
