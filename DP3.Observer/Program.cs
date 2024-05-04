using DP3.Observer;

class Program
{
    static void Main(string[] args)
    {
        // Tạo ra một WeatherStation (Subject)
        var weatherStation = new WeatherStation();

        // Tạo ra các Display (Observers)
        var display1 = new Display("Display 1");
        var display2 = new Display("Display 2");

        // Đăng ký các Display với WeatherStation
        weatherStation.RegisterObserver(display1);
        weatherStation.RegisterObserver(display2);

        // Cập nhật dữ liệu thời tiết trên WeatherStation, tự động thông báo cho các Display
        weatherStation.SetWeatherData("Sunny");

        // Kết quả:
        // Display 1 received weather update: Sunny
        // Display 2 received weather update: Sunny
    }
}
