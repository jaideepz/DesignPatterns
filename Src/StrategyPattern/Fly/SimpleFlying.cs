using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Fly
{
    internal class SimpleFlying : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I fly normally");
        }
    }
}