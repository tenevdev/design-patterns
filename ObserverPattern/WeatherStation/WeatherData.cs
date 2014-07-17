using ObserverPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.WeatherStation
{
    public class WeatherData : IObservable
    {
        public WeatherData()
        {
            this.Observers = new List<IObserver>();
            this.MeasurementsData = new Measurements(0, 0, 0);
        }

        public void SubscribeObserver(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void UnsubscribeObserver(IObserver observer)
        {
            this.Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in this.Observers)
            {
                observer.Update(this.MeasurementsData);
            }
        }

        public IList<IObserver> Observers { get; set; }

        private Measurements measurementsData = new Measurements(0, 0, 0);
        public Measurements MeasurementsData 
        {
            get 
            {
                return this.measurementsData;
            }
            set
            {
                this.measurementsData = value;
                this.MeasurementsChanged();
            }
        }

        public void MeasurementsChanged()
        {
            this.NotifyObservers();
        }
    }
}
