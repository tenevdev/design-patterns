using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks.Behaviours.Flying
{
    public class FlyingWithWings : IFlying
    {
        public void Fly()
        {
            // Fly normally
            Console.WriteLine("Flying");
        }
    }
}
