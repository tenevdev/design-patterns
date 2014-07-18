using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.CoffeeShop.CoffeeTypes
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.Description = "Dark roast";
        }

        public override decimal Cost()
        {
            return 2.50m;
        }
    }
}
