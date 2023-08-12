using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Fly
{
    internal class RocketFlying : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I fly with engines");
        }
    }
}
