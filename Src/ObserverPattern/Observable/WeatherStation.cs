using ObserverPattern.Observers;

namespace ObserverPattern.Observable
{
    internal class WeatherStation : IObservable
    {
        internal float Temperature { get; private set; }
        internal float Pressure { get; private set; }

        private List<IObserver> Observers = new();

        public void Add(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }
        }

        internal void UpdateWeatherData(float temp, float press)
        {
            Temperature = temp;
            Pressure = press;
            Notify();
        }
    }
}
