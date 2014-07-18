using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.CoffeeShop.CoffeeTypes
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            this.Description = "Decaf";
        }

        public override decimal Cost()
        {
            return 1.60m;
        }
    }
}
