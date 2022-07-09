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
    public partial class WorldWideCasesForm : Form
    {
        public WorldWideCasesForm()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source =.\\SQLEXPRESS; Initial Catalog = covidStatsTracker; Integrated Security = True";

        private void insertCasesWW_Click(object sender, EventArgs e)
        {
            if(insertCasesNumWW.Value ==  null || dateInput.Text == "" || timeInput.Text == "")
            {
                MessageBox.Show("Fields can't be left blank!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                int casesRecorded = (int)insertCasesNumWW.Value;
                string dateRecorded = dateInput.Text;
                string timeRecorded = timeInput.Text;
                string query = "INSERT INTO worldwideCases (dateRecorded, timeRecorded, casesRecorded) VALUES ('" + dateRecorded + "', '" + timeRecorded + "', '" + casesRecorded + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cases Inserted Succesfully!");
                conn.Close();
                insertCasesNumWW.Value = 0;
                dateInput.Text = "";
                timeInput.Text = "";
                
            }
        }

        private void DelBtnWW_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "TRUNCATE TABLE worldwideCases";
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
    }
}
