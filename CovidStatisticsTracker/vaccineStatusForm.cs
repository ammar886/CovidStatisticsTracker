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
    public partial class vaccineStatusForm : Form
    {
        public vaccineStatusForm()
        {
            InitializeComponent();
        }
        string connectionstring = "Data Source =.\\SQLEXPRESS; Initial Catalog = covidStatsTracker; Integrated Security = True";
        private void insertCityCases_Click(object sender, EventArgs e)
        {
            if (id_input.Text == "" || name_Input.Text == "" || age_Input.Text == "" || vaccine_Input.Text == "")
            {
                MessageBox.Show("Fields can't be left blank!");
            }
            else
            {
                string ID = id_input.Text;
                string name = name_Input.Text;
                string dose = dose_list.Text;
                string age = age_Input.Text;
                string vaccine = vaccine_Input.Text;

                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                string query = "INSERT INTO vaccinationRecord(ID,Name,Dose,Age,vaccineName) VALUES ('" + ID + "','" + name + "','" + dose + "','" + age + "','" + vaccine + "') ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Inserted Succesfully!");
            }
        }

        private void DeleteCityCases_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "TRUNCATE TABLE vaccinationRecord";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Succesfully!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new adminHome().Show();
            this.Hide();
        }
    }
}
