using StrategyPattern.Characters.CharacterRoles;
using StrategyPattern.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Ducks;
using StrategyPattern.Ducks.DuckSpecies;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Character king = new King();
            king.fight();

            Character troll = new Troll();
            troll.fight();

            Duck mallard = new MallardDuck();
            mallard.performFly();

            Duck rubberDuck = new ModelDuck();
            rubberDuck.performFly();

            Console.ReadLine();
        }
    }
}
