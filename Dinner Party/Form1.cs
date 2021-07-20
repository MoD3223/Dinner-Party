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
        Birthday_Party birthday_Party;

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
            birthday_Party = new Birthday_Party((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);
            labelFinalAmount.Text = FinalPrice + "zł";
        }

        private void guestNumeric_ValueChanged(object sender, EventArgs e)
        {
            Guests = (int)guestNumeric.Value;
            GuestPrice = Guests * 25;
            if (Guests > 12)
            {
                GuestPrice += 100;
            }
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

        //Birthday Party

        public void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthday_Party.CakeWritingTooLong;
            decimal cost = birthday_Party.Cost;
            LabelBirthdayCost.Text = cost.ToString("c");
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthday_Party.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthday_Party.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthday_Party.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
