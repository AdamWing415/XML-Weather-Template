using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        //adds all values held by a day 
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow,
            windSpeed, windDirection, precipitation, humidity;
        public Int64 updateTime;
        public Image image, backImage, forcastBackImage;
        public Day()
        {
            //sets all values to null by default
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = humidity = "";
            image = null;
            backImage = null;
            forcastBackImage = null;
            //updateTime = 0;
        }
    }
}
