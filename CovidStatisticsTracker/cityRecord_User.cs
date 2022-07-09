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
    public partial class cityRecord_User : Form
    {
        public cityRecord_User()
        {
            InitializeComponent();
        }
        string connectionstring = "Data Source =.\\SQLEXPRESS; Initial Catalog = covidStatsTracker; Integrated Security = True";
        private void showBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "SELECT * FROM cityWiseCases";
            SqlCommand cmd = new SqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new userMainMenu().Show();
            this.Hide();
        }

        private void cityRecord_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'covidStatsTrackerDataSet.cityWiseCases' table. You can move, or remove it, as needed.
           

        }
    }
}
