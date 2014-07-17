using StrategyPattern.Characters.Behaviours.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Characters
{
    public abstract class Character
    {
        public IWeapon Weapon { get; set; }

        public Character() { }

        public void fight()
        {
            this.Weapon.use();
        }
    }
}
