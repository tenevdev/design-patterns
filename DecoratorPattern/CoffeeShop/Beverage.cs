using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.CoffeeShop
{
    public abstract class Beverage
    {
        public string Description { get; set; }

        public abstract decimal Cost();
    }
}
