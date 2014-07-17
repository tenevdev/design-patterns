using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks.Behaviours.Quacking
{
    public class Mute : IDuckSound
    {
        public void makeSound()
        {
            // Cannot make sound
            Console.WriteLine("(Silence)");
        }
    }
}
