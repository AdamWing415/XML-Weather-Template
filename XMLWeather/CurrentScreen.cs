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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            double kmh = Convert.ToDouble(Form1.days[0].windSpeed) * 3.6;

            cityOutput.Text = Form1.days[0].location;
            currentOutput.Text = Math.Round(Convert.ToDecimal(Form1.days[0].currentTemp))  + "°C";
            minOutput.Text = Math.Round(Convert.ToDecimal(Form1.days[0].tempLow)) + "°";
            maxOutput.Text = Math.Round(Convert.ToDecimal(Form1.days[0].tempHigh)) + "°";
            humidValueLabel.Text = Form1.days[0].humidity + "%";
            windOutputLabel.Text = Math.Round(kmh) + " Km/h " + Form1.days[0].windDirection;
            updateLabel.Text = "Last Updated: \n" + Form1.days[0].updateTime;

            conditionLabel.Text = Form1.days[0].condition;
            this.BackgroundImage = Form1.days[0].backImage;
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

       
    }
}
