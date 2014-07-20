using FactoryPattern.PizzaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.SimpleFactory
{
    public class SimplePizzaFactory
    {
        public SimplePizzaFactory()
        {

        }

        public Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new CheesePizza();
                    break;
                case PizzaType.Pepperoni:
                    return new PepperoniPizza();
                    break;
                case PizzaType.Clam:
                    return new ClamPizza();
                    break;
                case PizzaType.Veggie:
                    return new VeggiePizza();
                    break;
                default:
                    return new CheesePizza();
                    break;
            }
        }
    }
}
