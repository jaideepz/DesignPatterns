using ObserverPattern.Observable;

namespace ObserverPattern.Observers
{
    internal interface IObserver
    {
        void Update(WeatherStation weatherStation);
    }
}
