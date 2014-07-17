using StrategyPattern.Ducks.Behaviours.Flying;
using StrategyPattern.Ducks.Behaviours.Quacking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks.DuckSpecies
{
    public class Duckling : Duck
    {
        public Duckling()
        {
            this.FlyingBehaviour = new NotFlying();
            this.QuackingBehaviour = new Squeaking();
        }
    }
}
