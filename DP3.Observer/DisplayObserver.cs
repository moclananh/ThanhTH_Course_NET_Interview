using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP3.Observer
{
    // Lớp cụ thể cho Observer
    public class Display : IWeatherObserver
    {
        private string _name;

        public Display(string name)
        {
            _name = name;
        }

        public void Update(string weatherData)
        {
            Console.WriteLine($"Display {_name} received weather update: {weatherData}");
        }
    }
}
