using StrategyPattern.Characters.Behaviours.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Characters.CharacterRoles
{
    public class Troll : Character
    {
        public Troll()
        {
            this.Weapon = new Axe();
        }
    }
}
