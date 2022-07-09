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
    public partial class userMainMenu : Form
    {
        public userMainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void pakCasesLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new pakCasesForm().Show();
            this.Hide();
        }

        private void worldCasesLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new worldCasesUser().Show();
            this.Hide();
        }

        private void casualtieLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new casualtiesForm_User().Show();
            this.Hide();
        }

        private void recLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new recoveries_form_User().Show();
            this.Hide();
        }

        private void underTreatLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new underTreatment_User().Show();
            this.Hide();
        }

        private void cityLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new cityRecord_User().Show();
            this.Hide();
        }

        private void vaccLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new vaccinationRecord_User().Show();
            this.Hide();
        }

        private void riskLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new riskForm_User().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new HomePage().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new graphChart().Show();
            this.Hide();
        }
    }
}
