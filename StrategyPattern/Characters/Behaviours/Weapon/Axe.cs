using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Characters.Behaviours.Weapon
{
    public class Axe : IWeapon
    {
        public void use()
        {
            // Chop, chop...
            Console.WriteLine("A troll chops with an axe.");
        }
    }
}
