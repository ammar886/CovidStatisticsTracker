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
    public partial class cityCasesForm : Form
    {
        public cityCasesForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string connectionstring = "Data Source =.\\SQLEXPRESS; Initial Catalog = covidStatsTracker; Integrated Security = True";

        private void insertCityCases_Click(object sender, EventArgs e)
        {
            if (insertcasesCityNum.Value == null || dateInput.Text == "" || timeInput.Text == "")
            {
                MessageBox.Show("Fields can't be left blank!");
                insertcasesCityNum.Value = 0;
                dateInput.Text = "";
                timeInput.Text = "";

            }

            else
            {
                int casesRecorded = (int)insertcasesCityNum.Value;
                string dateRecorded = dateInput.Text;
                string timeRecorded = timeInput.Text;
                string citySelected = citiesList.Text;
                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                string query = "UPDATE cityWiseCases SET dateRecorded = '" + dateRecorded + "', timeRecorded = '" + timeRecorded + "', casesRecorded = '" + casesRecorded + "' WHERE cityName = '" + citySelected + "'";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Updated Succesfully!");


            }
        }

        private void DeleteCityCases_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "TRUNCATE TABLE cityWiseCases";
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

        private void cityCasesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
