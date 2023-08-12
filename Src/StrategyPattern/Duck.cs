using StrategyPattern.Fly;
using StrategyPattern.Quack;

namespace StrategyPattern
{
    public class Duck
    {
        private IFlyBehaviour flyBehaviour;

        private IQuackBehaviour quackBehaviour;

        public Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
        {
            this.flyBehaviour = flyBehaviour;
            this.quackBehaviour = quackBehaviour;
        }

        public void Fly() { 
            flyBehaviour.Fly();
        }

        public void Quack() { 
            quackBehaviour.Quack();
        }
    }
}
