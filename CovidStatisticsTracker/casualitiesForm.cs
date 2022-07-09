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
    public partial class casualitiesForm : Form
    {
        public casualitiesForm()
        {
            InitializeComponent();
        }
        string connectionstring = "Data Source =.\\SQLEXPRESS; Initial Catalog = covidStatsTracker; Integrated Security = True";
        private void insertCasualities_Click(object sender, EventArgs e)
        {
            int casualtiesRecorded = (int)insertCasualitiesNum.Value;
            string dateRecorded = dateInput.Text;
            string timeRecorded = timeInput.Text;
            if (insertCasualitiesNum.Value == null || dateInput.Text == "" || timeInput.Text == "")
            {
                MessageBox.Show("Fields can't be left blank!");
                insertCasualitiesNum.Value = 0;
                dateInput.Text = "";
                timeInput.Text = "";
            }
            else
            {
                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                string query = "INSERT INTO casualties (dateRecorded, timeRecorded, casualtiesRecorded) VALUES ('"+dateRecorded+"', '"+timeRecorded+"','"+casualtiesRecorded+"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Casualties Recorded Succesfully!");
                conn.Close();
                insertCasualitiesNum.Value = 0;
                dateInput.Text = "";
                timeInput.Text = "";


            }
        }

        private void DelBtnCas_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "TRUNCATE TABLE casualties";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Succesfully1");
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new adminHome().Show();
            this.Hide();
        }

        private void insertCasualitiesNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void timeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}