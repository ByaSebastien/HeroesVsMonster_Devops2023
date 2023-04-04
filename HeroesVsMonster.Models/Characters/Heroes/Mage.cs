using HeroesVsMonster.Models.Properties.Statistics;
using HeroesVsMonster.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.Models.Characters.Heroes
{
    public class Mage : Hero
    {
        public Mage(string name) : base(" 🧙‍♂️",name)
        {
            Stats.Append(StatType.Mp, 15);
            Stats.Append(StatType.Inteligence, 10);
            Stats.Append(StatType.Resistance, 5);
            //TODO BASE SKILL
            FullRegen();
        }
        public override void Attack(Character target)
        {
            int dmg = (Inteligence - target.Resistance <= 0 ? 1 : Inteligence - target.Resistance) + Dice.Throws(DiceType.D4);
            Screen.PrintInfo($"{Name} attaque et fait {dmg} de dégats");
            target.TakeDamage(dmg);
            base.Attack(target);
        }
    }
}
