using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.CoffeeShop.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage)
        {
            this.Description = this.Beverage.Description + ", Soy";
        }

        public override decimal Cost()
        {
            return .60m + this.Beverage.Cost();
        }
    }
}
