using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow, 
            windSpeed, windDirection, precipitation, humidity, updateTime;
        public Image image, backImage, forcastBackImage;
        public Day()
        { 
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation  = humidity = updateTime = "";
            image = null;
            backImage = null;
            forcastBackImage = null;
        }
    }
}
