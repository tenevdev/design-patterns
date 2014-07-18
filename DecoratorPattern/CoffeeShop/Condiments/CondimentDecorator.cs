using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.CoffeeShop.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage Beverage { get; set; }

        public CondimentDecorator(Beverage beverage)
        {
            this.Beverage = beverage;
        }
    }
}
