using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XMLWeather
{

    public partial class SearchScreen : UserControl
    {
        string location;
        public SearchScreen()
        {
            InitializeComponent();
            //sets background image
            this.BackgroundImage = Form1.days[0].backImage;
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            //changes to the forcast screen on click
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //changes to the current screen on click
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void SearchBox_MouseClick(object sender, MouseEventArgs e)
        {
            //resets text on click so that the user can search
            if (SearchBox.Text == " Search Cities")
            {
                SearchBox.Text = " ";
            }
        }

        private void SearchPicBox_Click(object sender, EventArgs e)
        {
            //searches for the city that has been entered, if teh city is not found, defaults to stratford
            Form1.days.Clear();
            location = SearchBox.Text;

            Form1.ExtractForecast(location);
            Form1.ExtractCurrent(location);

            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void StratfordLabel_Click(object sender, EventArgs e)
        {
            //inputs data to gve Stratford's weather
            Form1.days.Clear();
            location = "stratford,CA";

            Form1.ExtractForecast(location);
            Form1.ExtractCurrent(location);

            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void WaterlooLabel_Click(object sender, EventArgs e)
        {
            //inputs data to gve Waterloo's weather
            Form1.days.Clear();
            location = "waterloo,CA";

            Form1.ExtractForecast(location);
            Form1.ExtractCurrent(location);

            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void LondonLabel_Click(object sender, EventArgs e)
        {
            //inputs data to gve London's weather
            Form1.days.Clear();
            location = "london,CA";

            Form1.ExtractForecast(location);
            Form1.ExtractCurrent(location);

            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void TorontoLabel_Click(object sender, EventArgs e)
        {
            //inputs data to gve toronto's weather
            Form1.days.Clear();
            location = "toronto,CA";

            Form1.ExtractForecast(location);
            Form1.ExtractCurrent(location);

            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void NiagaraLabel_Click(object sender, EventArgs e)
        {
            //inputs data to gve niagara's weather
            Form1.days.Clear();
            location = "Niagara,US";

            Form1.ExtractForecast(location);
            Form1.ExtractCurrent(location);

            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
