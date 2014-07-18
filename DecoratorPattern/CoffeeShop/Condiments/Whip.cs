using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.CoffeeShop.Condiments
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage)
        {
            this.Description = this.Beverage.Description + ", Whip";
        }

        public override decimal Cost()
        {
            return .25m + this.Beverage.Cost();
        }
    }
}
