using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP3.Observer
{
    // Giao diện cho Subject
    public interface IWeatherSubject
    {
        void RegisterObserver(IWeatherObserver observer);
        void RemoveObserver(IWeatherObserver observer);
        void NotifyObservers();
    }

    // Giao diện cho Observer
    public interface IWeatherObserver
    {
        void Update(string weatherData);
    }

}
