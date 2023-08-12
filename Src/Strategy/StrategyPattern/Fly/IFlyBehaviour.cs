namespace StrategyPattern.Fly
{
    internal interface IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }
    }
}