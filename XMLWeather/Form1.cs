using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using XMLWeather.Properties;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // create list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //create a day object
                Day newDay = new Day();

                //fill day object with required data
                reader.ReadToFollowing("time");
                newDay.date = reader.GetAttribute("day");

               
                reader.ReadToFollowing("symbol");
                int conditionType = Convert.ToInt16(reader.GetAttribute("number"));

                if (conditionType == 800)
                {
                    newDay.condition = "Clear";
                    newDay.image = Resources.weather_sun;
                    //add background images
                }
                else if (conditionType < 300)
                {
                    newDay.condition = "Thunderstorms";
                    newDay.image = Resources.weather_thunder;
                    //add background images
                }
                else if (conditionType < 600 && conditionType >= 300)
                {
                    newDay.condition = "Rain";
                    newDay.image = Resources.weather_rain;
                    //add background images
                }
                else if (conditionType < 700 && conditionType >= 600)
                {
                    newDay.condition = "Snow";
                    newDay.image = Resources.weather_snow;
                    //add background images
                }
                else if (conditionType < 800 && conditionType >= 700)
                {
                    newDay.condition = "Atmospheric Conditions";
                    newDay.image = Resources.weather_fog;
                    //add background images
                }
                else if (conditionType > 800)
                {
                    newDay.condition = "Cloudy";
                    newDay.image = Resources.weather_clouds;
                    //add background images
                }
                reader.ReadToFollowing("temperature");
                newDay.tempLow = reader.GetAttribute("min");
                newDay.tempHigh = reader.GetAttribute("max");

                //TODO: if day object not null add to the days list
                //if (newDay != null)
                //{
                days.Add(newDay);
                //}
            }
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

           
        }


    }
}
