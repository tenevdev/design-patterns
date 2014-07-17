using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Base
{
    public interface IObservable
    {
        void SubscribeObserver(IObserver observer);
        void UnsubscribeObserver(IObserver observer);
        void NotifyObservers();

    }
}
