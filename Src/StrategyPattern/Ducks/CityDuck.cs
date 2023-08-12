using StrategyPattern.Fly;
using StrategyPattern.Quack;

namespace StrategyPattern.Ducks
{
    public class CityDuck : Duck
    {
        public CityDuck() : base(new RocketFlying(), new SimpleQuack())
        {
            Console.WriteLine("I'm city duck");
        }
    }
}
