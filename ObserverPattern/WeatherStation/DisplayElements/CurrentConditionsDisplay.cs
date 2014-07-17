using ObserverPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.WeatherStation.DisplayElements
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private Measurements MeasurementsData { get; set; }
        private WeatherData WeatherData { get; set; }

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.WeatherData = weatherData;
            this.WeatherData.SubscribeObserver(this);

            this.MeasurementsData = new Measurements(0, 0, 0);
        }

        public void Display()
        {
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");
            Console.WriteLine("Displaying current conditions : ");
            Console.WriteLine("Temperature : {0}", this.MeasurementsData.Temperature);
            Console.WriteLine("Pressure : {0}", this.MeasurementsData.Pressure);
            Console.WriteLine("Humidity : {0}", this.MeasurementsData.Humidity);
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");
        }

        public void Update(Measurements measurementsData)
        {
            this.MeasurementsData = measurementsData;
        }
    }
}
