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
    public partial class pakCasesForm : Form
    {
        public pakCasesForm()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source =.\\SQLEXPRESS; Initial Catalog = covidStatsTracker; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM pakistanCases";
            SqlCommand cmd = new SqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table  = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new userMainMenu().Show();
            this.Hide();
        }
    }
}
