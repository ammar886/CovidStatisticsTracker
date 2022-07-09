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
    public partial class loginForm : Form 
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source =.\\SQLEXPRESS; Initial Catalog = covidStatsTracker; Integrated Security = True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string adminID = adminIDlogin_txtBox.Text;
            string password = adminPassLogin_txtBox.Text;

            string query = "select * from adminRecord where adminID = '" + adminIDlogin_txtBox.Text.Trim() + "'  and adminPass='" + adminPassLogin_txtBox.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                new adminHome().Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adminIDlogin_txtBox.Clear();
                adminPassLogin_txtBox.Clear();

                adminIDlogin_txtBox.Focus();
            }

            /*if(adminIDlogin_txtBox.Text == "" || adminPassLogin_txtBox.Text == " "||confirmPassBox.Text == "")
               {
                   MessageBox.Show("Fileds cannot be left blank!");

               }
            else if(adminIDlogin_txtBox.Text == "COVPAK001" && adminPassLogin_txtBox.Text == "123456" && confirmPassBox.Text == adminPassLogin_txtBox.Text)
               {
                   MessageBox.Show("Login Succesfull!");
                   new adminHome().Show();
                   this.Hide();
               }
               else
               {
                   MessageBox.Show("Wrong Credentials! Sign Up failed! Try again");
               }
            */
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            adminIDlogin_txtBox.Text = "";
            adminPassLogin_txtBox.Text = "";
            confirmPassBox.Text = "";
            adminIDlogin_txtBox.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SignUpBtbF_Click(object sender, EventArgs e)
        {
            new SignUpPage().Show();
            this.Hide();
        }

        private void showPassLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassLogin.Checked)
            {
                adminPassLogin_txtBox.PasswordChar = '*';
                confirmPassBox.PasswordChar = '*';
            }
            else
            {
                adminPassLogin_txtBox.PasswordChar = '\0';
                confirmPassBox.PasswordChar = '\0';
            }
        }
    }
}
