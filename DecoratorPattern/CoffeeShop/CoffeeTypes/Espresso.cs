using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.CoffeeShop.CoffeeTypes
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this.Description = "Espresso";
        }

        public override decimal Cost()
        {
            return 1.90m;
        }
    }
}
