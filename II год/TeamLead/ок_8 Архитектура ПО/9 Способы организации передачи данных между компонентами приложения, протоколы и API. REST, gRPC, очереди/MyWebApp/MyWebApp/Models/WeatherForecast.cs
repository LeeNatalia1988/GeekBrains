﻿namespace MyWebApp.Models
{
    public class WeatherForecast
    {

        public DateTime Date { get; set; }
        public int TemperatureC {  get; set; }

        public int TemperatureF
        {
            get
            {
                return 32 + (int)(TemperatureC / 0.5556);
            }
        }
    }
}
