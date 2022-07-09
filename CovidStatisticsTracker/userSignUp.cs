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
    public partial class userSignUp : Form
    {
        public userSignUp()
        {
            InitializeComponent();
        }
        string connectionstring = "Data Source =.\\SQLEXPRESS; Initial Catalog = covidStatsTracker; Integrated Security = True";
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (userNameInput.Text == "")
            {
                MessageBox.Show("Fields can't be left blanK!");
            }
            else
            {

                Random rnd = new Random();

                int userGuestID = rnd.Next(1, 100);

                string userName = userNameInput.Text;

                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                string query = "INSERT INTO userRecord (GuestID, GuestName) VALUES ('" + userGuestID + "', '" + userName + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sign Up Succesfull!");

                new userMainMenu().Show();
                this.Hide();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userNameInput.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new userMainMenu().Show();
            this.Hide();
        }
    }
}
