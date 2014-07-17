using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Characters.Behaviours.Weapon
{
    public class Knife : IWeapon
    {
        public void Use()
        {
            // Cut with a knife
            Console.WriteLine("A king cuts with a knife.");
        }
    }
}
