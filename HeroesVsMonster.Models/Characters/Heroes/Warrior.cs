using HeroesVsMonster.Models.Properties.Statistics;
using HeroesVsMonster.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.Models.Characters.Heroes
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base("‍👨‍🚒", name)
        {
            Stats.Append(StatType.Hp, 15);
            Stats.Append(StatType.Strenght, 5);
            Stats.Append(StatType.Defence, 10);
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
