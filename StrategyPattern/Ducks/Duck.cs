using StrategyPattern.Ducks.Behaviours.Flying;
using StrategyPattern.Ducks.Behaviours.Quacking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{       
    public abstract class Duck
    {
        public IFlying FlyingBehaviour { get; set; }
        public IDuckSound QuackingBehaviour { get; set; }

        public Duck(){ }

        public void PerformFly()
        {
            this.FlyingBehaviour.Fly();
        }

        public void PerformSound()
        {
            this.QuackingBehaviour.MakeSound();
        }
    }
}
