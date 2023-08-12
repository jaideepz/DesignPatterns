using StrategyPattern.Fly;

namespace StrategyPattern
{
    public class Duck : IFlyBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quacking");
        }

        public void Display()
        {
            Console.WriteLine("Displaying");
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
