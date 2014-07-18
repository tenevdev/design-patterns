using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.CoffeeShop.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
            this.Description = this.Beverage.Description + ", Mocha";
        }
        public override decimal Cost()
        {
            return .30m + this.Beverage.Cost();
        }
    }
}
