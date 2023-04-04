using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.Models.Characters.Monsters
{
    public abstract class Monster : Character
    {
        public Monster(string sprite) : base(sprite) 
        {
            Stats.Generate(Utils.DiceType.D6, 5, 3);
        }
    }
}
