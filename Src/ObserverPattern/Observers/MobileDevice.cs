using ObserverPattern.Observable;

namespace ObserverPattern.Observers
{
    internal class MobileDevice : IObserver
    {
        public void Update(WeatherStation weatherStation)
        {
            Console.WriteLine("Data displayed on mobile:");
            Console.WriteLine("Temperature is: " + weatherStation.Temperature + " celsius");
            Console.WriteLine("Pressure is: " + weatherStation.Pressure + " ppm");
            Console.WriteLine();
        }
    }
}
