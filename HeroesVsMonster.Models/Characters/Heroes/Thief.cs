using HeroesVsMonster.Models.Properties.Statistics;
using HeroesVsMonster.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.Models.Characters.Heroes
{
    public class Thief : Hero
    {
        public Thief(string name) : base("  🥷", name)
        {
            Stats.Append(StatType.Hp, 10);
            Stats.Append(StatType.Strenght, 10);
            Stats.Append(StatType.Speed, 5);
            //TODO BASE SKILL
            FullRegen();
        }
        public override void Attack(Character target)
        {
            int dmg = (Strenght - target.Defence <= 0 ? 1 : Strenght - target.Defence) + Dice.Throws(DiceType.D4);
            Screen.PrintInfo($"{Name} attaque et fait {dmg} de dégats");
            target.TakeDamage(dmg);
            base.Attack(target);
        }
    }
}
