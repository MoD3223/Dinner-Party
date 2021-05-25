using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinner_Party
{
    public partial class Form1 : Form
    {
        public int Guests;
        public bool Fantasy;
        public bool Healthy;
        public double FinalPrice;
        public int GuestPrice;
        public int FantasyON;
        public double FantasyOFF;
        public int HealthyON;
        public double HealthyOFF;
        public bool Discount = false;
        public Form1()
        {
            InitializeComponent();
            labelFinalAmount.Text = FinalPrice + "zł";
        }

        private void guestNumeric_ValueChanged(object sender, EventArgs e)
        {
            Guests = (int)guestNumeric.Value;
            GuestPrice = Guests * 25;
            DisplayPartyCost();
        }

        private void checkBoxFantasy_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPartyCost();
        }

        private void checkBoxHealthy_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPartyCost();
        }

        public void DisplayPartyCost()
        {
            if (checkBoxFantasy.Checked)
            {
                Fantasy = true;
                FantasyON = Guests * 15 + 50;
                FantasyOFF = 0;
            }
            else
            {
                Fantasy = false;
                FantasyOFF = Guests * 7.5 + 30;
                FantasyON = 0;
            }

            if (checkBoxHealthy.Checked)
            {
                Healthy = true;
                HealthyON = Guests * 5;
                Discount = true;
            }
            else
            {
                Healthy = false;
                HealthyOFF = Guests * 20;
                HealthyON = 0;
                Discount = false;
            }
            FinalPrice = GuestPrice + FantasyON + FantasyOFF + HealthyON + HealthyOFF;

            if (Discount == true)
            {
                FinalPrice = FinalPrice * 0.95;
            }
            labelFinalAmount.Text = FinalPrice + "zł";
        }
    }
}
