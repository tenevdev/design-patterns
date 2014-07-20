using FactoryPattern.PizzaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaType type)
        {
            Pizza pizza = this.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(PizzaType type);
    }
}
