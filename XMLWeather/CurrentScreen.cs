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
            cityOutput.Text = Form1.days[0].location;
            currentOutput.Text = Math.Round(Convert.ToDecimal(Form1.days[0].currentTemp))  + "°C";
            minOutput.Text = Math.Round(Convert.ToDecimal(Form1.days[0].tempLow)) + "°";
            maxOutput.Text = Math.Round(Convert.ToDecimal(Form1.days[0].tempHigh)) + "°";
           
            picBox1.Image = Form1.days[0].image;
            conditionLabel.Text = Form1.days[0].condition;
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
