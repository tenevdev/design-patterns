using FactoryPattern.PizzaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override PizzaTypes.Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new NYStyleCheesePizza();
                case PizzaType.Pepperoni:
                    return new NYStylePepperoniPizza();
                case PizzaType.Clam:
                    return new NYStyleClamPizza();
                case PizzaType.Veggie:
                    return new NYStyleVeggiePizza();
                default:
                    return new NYStyleCheesePizza();
            }
        }
    }
}
