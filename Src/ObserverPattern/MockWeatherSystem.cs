using ObserverPattern.Observable;
using ObserverPattern.Observers;

namespace ObserverPattern
{
    public class MockWeatherSystem
    {
        public MockWeatherSystem()
        {
            WeatherStation weatherStation = new WeatherStation();
            MakeConnections(weatherStation);
            UpdateWeatherDataPeriodically(weatherStation);
        }

        private void MakeConnections(WeatherStation weatherStation)
        {
            MobileDevice mobileDevice = new();
            weatherStation.Add(mobileDevice);

            WeatherWebsite weatherWebsite = new();
            weatherStation.Add(weatherWebsite);
        }

        private void UpdateWeatherDataPeriodically(WeatherStation weatherStation)
        {
            Random random = new Random();
            while (true)
            {
                Console.WriteLine("Updating weather data at : " + DateTime.Now.ToString());
                weatherStation.UpdateWeatherData(NextFloat(random), NextFloat(random));
                Console.WriteLine();
                Thread.Sleep(2500);
            }
        }

        private static float NextFloat(Random random)
        {
            double mantissa = (random.NextDouble() * 2.0) - 1.0;
            // choose -149 instead of -126 to also generate subnormal floats (*)
            double exponent = Math.Pow(2.0, random.Next(-126, 128));
            return (float)(mantissa * exponent);
        }
    }
}
