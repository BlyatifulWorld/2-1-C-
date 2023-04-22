using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckInTime_ValueChanged(object sender, EventArgs e)
        {
            CheckOutTime.Value = CheckInTime.Value;
            if (CheckInTime.Value < CheckOutTime.Value)
            {
                CheckInTime.Value = CheckOutTime.Value;
            }
        }

        private void CheckOutTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Total_Price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime CheckIn = CheckInTime.Value;
            DateTime CheckOut = CheckOutTime.Value;
            TimeSpan TotalDay = CheckOut - CheckIn;
            Date_Display.Text = TotalDay + "";

            double room_price = 0;
            if (Single.Checked) room_price = 500;
            if (Double.Checked) room_price = 700;
            if (Suite.Checked) room_price = 1100;

            double stay_time = (double)TotalDay.TotalHours + 0.0001;

            if (NonSub0.Checked == true)
            {
                double total_price = room_price * (stay_time / 24);
                Total_Price.Text = total_price + "";
            }
            if (Sub10.Checked == true)
            {
                double total_price = (room_price * (stay_time / 24)) * 0.9;
                Total_Price.Text = total_price + "";
            }
        }

        private void NonSub0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Sub10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Single_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Double_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Suite_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
