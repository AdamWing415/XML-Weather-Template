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
using System.Linq.Expressions;

namespace XMLWeather
{
    /// <summary>
    /// Adam Wingert
    /// Weather App
    /// 19/10/2020
    /// 
    /// NOTE:
    /// ALL backgrounds are made by ME!
    /// icons are not
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        // create list to hold day objects
        public static List<Day> days = new List<Day>();
        string location;
        public Form1()
        {
            //sets default location to stratford and runs both functions to retrieve data from open weather
            InitializeComponent();
            location = "stratford, CA";
            ExtractForecast(location);
            ExtractCurrent(location);

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast(string city)
        {
            try
            {
                //creates a reader to get info from the xml
                XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=" + city + "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

                while (reader.Read())
                {
                    //create a day object
                    Day newDay = new Day();

                    //fill day object with required data
                    reader.ReadToFollowing("time");
                    newDay.date = reader.GetAttribute("day");

                    //gets the weather condition and sets all icons and data accordingly
                    reader.ReadToFollowing("symbol");
                    int conditionType = Convert.ToInt16(reader.GetAttribute("number"));

                    if (conditionType == 800)
                    {
                        newDay.condition = "Clear";
                        newDay.image = Resources.weather_sun;
                        newDay.forcastBackImage = Resources.clear_blur_;
                    }
                    else if (conditionType < 300)
                    {
                        newDay.condition = "Thunder";

                        newDay.image = Resources.weather_thunder;
                        newDay.forcastBackImage = Resources.Lightning_blur_;
                    }
                    else if (conditionType < 600 && conditionType >= 300)
                    {
                        newDay.condition = "Rain";
                        newDay.image = Resources.weather_rain;
                        newDay.forcastBackImage = Resources.rain_blur_;
                    }
                    else if (conditionType < 700 && conditionType >= 600)
                    {
                        newDay.condition = "Snow";
                        newDay.image = Resources.weather_snow;
                        newDay.forcastBackImage = Resources.snow_blur_;
                    }
                    else if (conditionType < 800 && conditionType >= 700)
                    {
                        newDay.condition = "Fog";
                        newDay.image = Resources.weather_fog;
                        newDay.forcastBackImage = Resources.foggy_blur_;
                    }
                    else if (conditionType > 800)
                    {
                        newDay.condition = "Clouds";
                        newDay.image = Resources.weather_clouds;
                        newDay.forcastBackImage = Resources.cloudy_blur_;
                    }
                    reader.ReadToFollowing("temperature");
                    newDay.tempLow = reader.GetAttribute("min");
                    newDay.tempHigh = reader.GetAttribute("max");

                    // if day object not null add to the days list
                    if (newDay.date != null)
                    {
                        days.Add(newDay);
                    }
                }
            }
            catch
            {
                //resets to stratford if the city isn't found
                string location = "stratford, CA";
                ExtractForecast(location);
            }

        }

        public static void ExtractCurrent(string city)
        {
            try
            {
                // current info is not included in forecast file so we need to use this file to get it
                XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=" + city + "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

                //find the city and current temperature and add to appropriate item in days list
                reader.ReadToFollowing("city");
                days[0].location = reader.GetAttribute("name");

                reader.ReadToFollowing("temperature");
                days[0].currentTemp = reader.GetAttribute("value");

                //gets the humidity value for today
                reader.ReadToFollowing("humidity");
                days[0].humidity = reader.GetAttribute("value");

                //gets the wind speed and direction values for today
                reader.ReadToFollowing("speed");
                days[0].windSpeed = reader.GetAttribute("value");


                reader.ReadToFollowing("direction");
                days[0].windDirection = reader.GetAttribute("code");

                //gets the conditions values for today and sets the background and other relevant info
                reader.ReadToFollowing("weather");
                int conditionType = Convert.ToInt16(reader.GetAttribute("number"));

                if (conditionType == 800)
                {
                    days[0].condition = "Clear";
                    days[0].backImage = Resources.clear;
                }
                else if (conditionType < 300)
                {
                    days[0].condition = "Thunder";
                    days[0].backImage = Resources.Lightning;
                }
                else if (conditionType < 600 && conditionType >= 300)
                {
                    days[0].condition = "Rain";
                    days[0].backImage = Resources.rain;
                }
                else if (conditionType < 700 && conditionType >= 600)
                {
                    days[0].condition = "Snow";
                    days[0].backImage = Resources.snow;
                }
                else if (conditionType < 800 && conditionType >= 700)
                {
                    days[0].condition = "Fog";
                    days[0].backImage = Resources.foggy;
                }
                else if (conditionType > 800)
                {
                    days[0].condition = "Clouds";
                    days[0].backImage = Resources.cloudy;
                }

                //gets the last updated time
                reader.ReadToFollowing("lastupdate");
                days[0].updateTime = reader.GetAttribute("value").Replace("T", "   ") + " UTC";

            }
            catch
            {
                //resets to stratford if the city isn't found

                string location = "stratford, CA";
                ExtractCurrent(location);
            }
        }

    }
}
