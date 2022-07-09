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
    public partial class recoveriesForm : Form
    {
        public recoveriesForm()
        {
            InitializeComponent();
        }

        private void recoveriesForm_Load(object sender, EventArgs e)
        {

        }
        string connectionstring = "Data Source =.\\SQLEXPRESS; Initial Catalog = covidStatsTracker; Integrated Security = True";
        private void insertRecoveries_Click(object sender, EventArgs e)
        {
            string dateRecorded = dateInput.Text;
            string timeRecorded = timeInput.Text;
            int recoveriesRecorded = (int)recoveriesNum.Value;
            if(recoveriesNum.Value == null || dateInput.Text == "" || timeInput.Text == "")
            {
                MessageBox.Show("Fields can't be left blank!"); 
            }
            else
            {
                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                string query = "INSERT INTO recoveries (dateRecorded, timeRecorded, recoveriesRecorded) VALUES ('" +dateRecorded+ "', '" +timeRecorded+ "', '"+recoveriesRecorded+"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Succesfully!");
                conn.Close();
                dateInput.Text = "";
                timeInput.Text = "";
                recoveriesNum.Value = 0;
            }
        }

        private void DelRecoveries_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "TRUNCATE TABLE recoveries";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Succesfully!");
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new adminHome().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
