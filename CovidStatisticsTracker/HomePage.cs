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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void AdminSignUpBtn_Click(object sender, EventArgs e)
        {
            new SignUpPage().Show();
            this.Hide();
        }

        private void userSignUpBtn_Click(object sender, EventArgs e)
        {
            new userSignUp().Show();
        }
    }
}
