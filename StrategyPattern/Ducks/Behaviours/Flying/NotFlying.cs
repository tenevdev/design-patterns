using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks.Behaviours.Flying
{
    public class NotFlying : IFlying
    {
        public void Fly()
        {
            // Cannot fly
            Console.WriteLine("Cannot fly");
        }
    }
}
