using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.CoffeeShop.CoffeeTypes
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.Description = "House blend";
        }

        public override decimal Cost()
        {
            return 2.20m;
        }
    }
}
