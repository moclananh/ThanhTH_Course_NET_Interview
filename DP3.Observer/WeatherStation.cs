using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP3.Observer
{
    // Lớp cụ thể cho Subject
    public class WeatherStation : IWeatherSubject
    {
        private List<IWeatherObserver> _observers = new List<IWeatherObserver>();
        private string _weatherData;

        public void RegisterObserver(IWeatherObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IWeatherObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_weatherData);
            }
        }

        public void SetWeatherData(string weatherData)
        {
            _weatherData = weatherData;
            NotifyObservers();
        }
    }
}
