using HeroesVsMonster.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.Models.Characters.Monsters
{
    public class MonsterFactory
    {
        public static Character GenerateMonster()
        {
            int rng = Dice.Throws(DiceType.D6);
            switch(rng)
            {
                case 1:
                case 2:
                    return new Wolf();
                case 3:
                case 4:
                    return new Troll();
                case 5:
                case 6:
                    return new Dragon();
            }
            throw new Exception();
        }
    }
}
