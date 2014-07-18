using DecoratorPattern.CoffeeShop;
using DecoratorPattern.CoffeeShop.CoffeeTypes;
using DecoratorPattern.CoffeeShop.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new DarkRoast();
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);

            Console.WriteLine(beverage.Cost());
            Console.WriteLine(beverage.Description);

            Console.ReadLine();
        }
    }
}
