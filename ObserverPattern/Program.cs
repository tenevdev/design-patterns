using ObserverPattern.WeatherStation;
using ObserverPattern.WeatherStation.DisplayElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

            currentDisplay.Display();
            forecastDisplay.Display();
            statisticsDisplay.Display();

            weatherData.MeasurementsData = new Measurements(32, 1012, 55);

            currentDisplay.Display();
            forecastDisplay.Display();
            statisticsDisplay.Display();

            weatherData.MeasurementsData = new Measurements(21, 1012, 55);
            weatherData.MeasurementsData = new Measurements(18, 1013, 56);
            weatherData.MeasurementsData = new Measurements(19, 1015, 57);
            weatherData.MeasurementsData = new Measurements(27, 1012, 57);

            currentDisplay.Display();
            forecastDisplay.Display();
            statisticsDisplay.Display();

            Console.ReadLine();
        }
    }
}
