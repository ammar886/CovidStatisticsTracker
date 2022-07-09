using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidStatisticsTracker
{
    public partial class graphChart : Form
    {
        public graphChart()
        {
            InitializeComponent();
        }

        private void graphChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'covidStatsTrackerDataSet.cityWiseCases' table. You can move, or remove it, as needed.
            this.cityWiseCasesTableAdapter.Fill(this.covidStatsTrackerDataSet.cityWiseCases);

        }
    }
}
