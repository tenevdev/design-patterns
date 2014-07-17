using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.WeatherStation
{
    public class Measurements
    {
        public Measurements(decimal temperature, decimal pressure, decimal humidity)
        {
            this.Temperature = temperature;
            this.Pressure = pressure;
            this.Humidity = humidity;
        }

        public decimal Temperature { get; set; }
        public decimal Pressure { get; set; }
        public decimal Humidity { get; set; }
    }
}
