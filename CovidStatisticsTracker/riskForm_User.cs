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
    public partial class riskForm_User : Form
    {
        public riskForm_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score = 0;
            if(q1Box.Text == "Difficulty in Breathing" || q1Box.Text == "SevereChestPain")
            {
                score = score + 5;
            }
            
            if(q2Box.Text == "Yes")
            {
                score = score + 5;
            }
            if (q3Box.Text == "Yes")
            {
                score = score + 5;
            }
            if (q4Box.Text == "Yes")
            {
                score = score + 5;
            }
            if (q5Box.Text == "Yes")
            {
                score = score + 5;
            }
            if (score > 15)
            {
                MessageBox.Show("You're at risk! Visit nearest covid station");
            }
            else
            {
                MessageBox.Show("You're not at direct covid risk! Wear a mask & stay safe!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new userMainMenu().Show();
            this.Hide();
        }
    }
}
