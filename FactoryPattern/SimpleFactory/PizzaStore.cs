using FactoryPattern.PizzaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.SimpleFactory
{
    public class PizzaStore
    {
        public SimplePizzaFactory PizzaFactory { get; set; }

        public PizzaStore(SimplePizzaFactory factory) 
        {
            this.PizzaFactory = factory;
        }

        public Pizza OrderPizza(PizzaType type)
        {
            Pizza pizza = this.PizzaFactory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
