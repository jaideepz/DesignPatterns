using ObserverPattern.Observable;

namespace ObserverPattern.Observers
{
    internal class WeatherWebsite : IObserver
    {
        public void Update(WeatherStation weatherStation)
        {
            Console.WriteLine("Data displayed on website:");
            Console.WriteLine("Temperature is: " + weatherStation.Temperature + " celsius");
            Console.WriteLine("Pressure is: " + weatherStation.Pressure + " ppm");
            Console.WriteLine();
        }
    }
}
