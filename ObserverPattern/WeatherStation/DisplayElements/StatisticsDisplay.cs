using ObserverPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.WeatherStation.DisplayElements
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private Measurements MinimalMeasurements { get; set; }
        private Measurements AverageMeasurements { get; set; }
        private Measurements MaximalMeasurements { get; set; }
        private int MeasurementsCount { get; set; }
        private WeatherData WeatherData { get; set; }

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.WeatherData = weatherData;
            this.WeatherData.SubscribeObserver(this);

            this.MaximalMeasurements = new Measurements(-1, -1, -1);
            this.MinimalMeasurements = new Measurements(decimal.MaxValue, decimal.MaxValue, decimal.MaxValue);
            this.AverageMeasurements = new Measurements(0, 0, 0);
            this.MeasurementsCount = 0;
        }
        
        public void Display()
        {
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");
            Console.WriteLine("Displaying weather statistics : ");
            Console.WriteLine("Temperature :  Min = {0} | Max = {1} | Avg = {2}", this.MinimalMeasurements.Temperature, this.MaximalMeasurements.Temperature, this.AverageMeasurements.Temperature);
            Console.WriteLine("Pressure :  Min = {0} | Max = {1} | Avg = {2}", this.MinimalMeasurements.Pressure, this.MaximalMeasurements.Pressure, this.AverageMeasurements.Pressure);
            Console.WriteLine("Hmidity :  Min = {0} | Max = {1} | Avg = {2}", this.MinimalMeasurements.Humidity, this.MaximalMeasurements.Humidity, this.AverageMeasurements.Humidity);
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");            
        }

        public void Update(Measurements measurementsData)
        {
            this.UpdateMinimalMeasurements(measurementsData);
            this.UpdateMaximalMeasurements(measurementsData);
            this.UpdateAverageMeasurements(measurementsData);
            this.MeasurementsCount++;
        }

        private void UpdateMinimalMeasurements(Measurements measurementsData)
        {
            if (this.MinimalMeasurements.Temperature > measurementsData.Temperature)
                this.MinimalMeasurements.Temperature = measurementsData.Temperature;
            if (this.MinimalMeasurements.Pressure > measurementsData.Pressure)
                this.MinimalMeasurements.Pressure = measurementsData.Pressure;
            if (this.MinimalMeasurements.Humidity > measurementsData.Humidity)
                this.MinimalMeasurements.Humidity = measurementsData.Humidity;
        }

        private void UpdateMaximalMeasurements(Measurements measurementsData)
        {
            if (this.MaximalMeasurements.Temperature < measurementsData.Temperature)
                this.MaximalMeasurements.Temperature = measurementsData.Temperature;
            if (this.MaximalMeasurements.Pressure < measurementsData.Pressure)
                this.MaximalMeasurements.Pressure = measurementsData.Pressure;
            if (this.MaximalMeasurements.Humidity < measurementsData.Humidity)
                this.MaximalMeasurements.Humidity = measurementsData.Humidity;
        }

        private void UpdateAverageMeasurements(Measurements measurementsData)
        {
            this.AverageMeasurements.Temperature = (this.AverageMeasurements.Temperature * this.MeasurementsCount + measurementsData.Temperature) / (this.MeasurementsCount + 1);
            this.AverageMeasurements.Pressure = (this.AverageMeasurements.Pressure * this.MeasurementsCount + measurementsData.Pressure) / (this.MeasurementsCount + 1);
            this.AverageMeasurements.Humidity = (this.AverageMeasurements.Humidity * this.MeasurementsCount + measurementsData.Humidity) / (this.MeasurementsCount + 1);
        }
    }
}
