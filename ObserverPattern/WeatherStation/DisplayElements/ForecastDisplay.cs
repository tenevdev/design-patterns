using ObserverPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.WeatherStation.DisplayElements
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private Measurements MeasurementsData { get; set; }
        private Measurements LastMeasurementsData { get; set; }
        private WeatherData WeatherData { get; set; }

        public ForecastDisplay(WeatherData weatherData)
        {
            this.WeatherData = weatherData;
            this.WeatherData.SubscribeObserver(this);

            this.LastMeasurementsData = new Measurements(0, 0, 0);
            this.MeasurementsData = new Measurements(0, 0, 0);
        }
        
        public void Display()
        {
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");
            Console.WriteLine("Displaying weather forecast : ");
            if (this.LastMeasurementsData.Pressure > this.MeasurementsData.Pressure)
                Console.WriteLine("The weather is going to improve");
            else if (this.LastMeasurementsData.Pressure == this.MeasurementsData.Pressure)
                Console.WriteLine("More of the same");
            else
                Console.WriteLine("Watch out for rainy weather");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");
        }

        public void Update(Measurements measurementsData)
        {
            this.LastMeasurementsData = this.MeasurementsData;
            this.MeasurementsData = measurementsData;
            this.Display();
        }
    }
}
