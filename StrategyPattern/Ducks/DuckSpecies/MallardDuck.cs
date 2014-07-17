using StrategyPattern.Ducks.Behaviours.Flying;
using StrategyPattern.Ducks.Behaviours.Quacking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks.DuckSpecies
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.FlyingBehaviour = new FlyingWithWings();
            this.QuackingBehaviour = new Quacking();
        }
    }
}
