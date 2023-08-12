﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Quack
{
    internal class SimpleQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("I quack normally");
        }
    }
}
