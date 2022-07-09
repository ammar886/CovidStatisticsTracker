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
    public partial class underTreatForm : Form
    {
        public underTreatForm()
        {
            InitializeComponent();
        }
        string connectionstring = "Data Source =.\\SQLEXPRESS; Initial Catalog = covidStatsTracker; Integrated Security = True";
        private void insertUnderTreat_Click(object sender, EventArgs e)
        {
            if (dateInput.Text == "" || timeInput.Text == "" || underTreatNum.Value == null)
            {
                MessageBox.Show("Fields Can't be left blank!");
            }
            else
            {
                string dateRecorded = dateInput.Text;
                string timeRecorded = timeInput.Text;
                int underTreatCases = (int)underTreatNum.Value;
                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                string query = "INSERT INTO underTreatment (dateRecorded, timeRecorded, underTreatmentCases) VALUES ('" + dateRecorded + "', '" + timeRecorded + "', '" + underTreatCases + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Inserted Succesfully!");
            }
        }

        private void Del_UnderTreat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "TRUNCATE TABLE underTreatment";
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Deleted Succesfully!");

        }

        private void underTreatForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new adminHome().Show();
            this.Hide();
        }
    }
}
