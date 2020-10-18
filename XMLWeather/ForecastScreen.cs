using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            min1.Text = Math.Round(Convert.ToDecimal(Form1.days[1].tempLow)) + "°";
            max1.Text = Math.Round(Convert.ToDecimal(Form1.days[1].tempHigh)) + "°";
            picBox1.Image = Form1.days[1].image;
            conditionLabel.Text = Form1.days[1].condition;
            this.BackgroundImage = Form1.days[1].forcastBackImage;

            date2.Text = Form1.days[2].date;
            min2.Text = Math.Round(Convert.ToDecimal(Form1.days[2].tempLow)) + "°";
            max2.Text = Math.Round(Convert.ToDecimal(Form1.days[2].tempHigh)) + "°";
            picBox2.Image = Form1.days[2].image;

            date3.Text = Form1.days[3].date;
            min3.Text = Math.Round(Convert.ToDecimal(Form1.days[3].tempLow)) + "°";
            max3.Text = Math.Round(Convert.ToDecimal(Form1.days[3].tempHigh)) + "°";
            picBox3.Image = Form1.days[3].image;

            date4.Text = Form1.days[4].date;
            min4.Text = Math.Round(Convert.ToDecimal(Form1.days[4].tempLow)) + "°";
            max4.Text = Math.Round(Convert.ToDecimal(Form1.days[4].tempHigh)) + "°";
            picBox4.Image = Form1.days[4].image;

            date5.Text = Form1.days[5].date;
            min5.Text = Math.Round(Convert.ToDecimal(Form1.days[5].tempLow)) + "°";
            max5.Text = Math.Round(Convert.ToDecimal(Form1.days[5].tempHigh)) + "°";
            picBox5.Image = Form1.days[5].image;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen ss = new SearchScreen();
            f.Controls.Add(ss);
        }
    }
}
