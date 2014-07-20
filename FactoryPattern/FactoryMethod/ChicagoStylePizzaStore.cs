using FactoryPattern.PizzaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new ChicagoStyleCheesePizza();
                case PizzaType.Pepperoni:
                    return new ChicagoStylePepperoniPizza();
                case PizzaType.Clam:
                    return new ChicagoStyleClamPizza();
                case PizzaType.Veggie:
                    return new ChicagoStyleVeggiePizza();
                default:
                    return new ChicagoStyleCheesePizza();
            }
        }
    }
}
