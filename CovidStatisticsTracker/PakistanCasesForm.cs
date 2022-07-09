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
    public partial class PakistanCasesForm : Form
    {
        public PakistanCasesForm()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source =.\\SQLEXPRESS; Initial Catalog = covidStatsTracker; Integrated Security = True";
        private void insertCases_Click(object sender, EventArgs e)
        {
           
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            int caseInsert = (int)insertCasesNum.Value;
            string dateRecorded = dateInput.Text;
            string timeRecorded = timeInput.Text;
            string Query = "INSERT INTO pakistanCases (dateRecorded, timeRecorded, casesRecorded) VALUES ('" + dateRecorded + "', '" + timeRecorded + "','" + caseInsert+ "')";

            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Cases Inserted Succesfully!");
            insertCasesNum.Value = 0;
            dateInput.Text = "";
            timeInput.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void DelBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection(connectionString);
            conn2.Open();
            string Query2 = "TRUNCATE TABLE pakistanCases";
            SqlCommand cmd2 = new SqlCommand(Query2,conn2);
            cmd2.ExecuteNonQuery();
            
            MessageBox.Show("Data Deleted Succefully!");
            

        }

        private void insertCasesNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new adminHome().Show();
            this.Hide();
        }
    }
}
