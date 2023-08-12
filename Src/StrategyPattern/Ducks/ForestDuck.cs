using StrategyPattern.Fly;
using StrategyPattern.Quack;

namespace StrategyPattern.Ducks
{
    public class ForestDuck : Duck
    {
        public ForestDuck() : base(new SimpleFlying(), new SimpleQuack())
        {
            Console.WriteLine("I'm forest duck");
        }
    }
}
