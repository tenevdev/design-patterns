﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks.Behaviours.Quacking
{
    public class Quacking : IDuckSound
    {
        public void makeSound()
        {
            // Quack
            Console.WriteLine("Quack");
        }
    }
}
