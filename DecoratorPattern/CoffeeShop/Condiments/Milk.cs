using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.CoffeeShop.Condiments
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
            this.Description = beverage.Description + ", Milk";
        }
        public override decimal Cost()
        {
            return .50m + this.Beverage.Cost();
        }
    }
}
