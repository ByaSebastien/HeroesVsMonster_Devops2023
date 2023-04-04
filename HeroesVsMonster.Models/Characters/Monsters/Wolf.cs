using HeroesVsMonster.Models.Properties.Statistics;
using HeroesVsMonster.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.Models.Characters.Monsters
{
    public class Wolf : Monster
    {
        public Wolf() : base("  🐺")
        {
            Stats.Append(StatType.Hp, 5);
            Stats.Append(StatType.Strenght, 5);
            Stats.Append(StatType.Speed, 5);
            FullRegen();
        }
        public override void Attack(Character target)
        {
            int dmg = (Strenght - target.Defence <= 0 ? 1 : Strenght - target.Defence) + Dice.Throws(DiceType.D4);
            Screen.PrintInfo($"Le loup attaque et fait {dmg} de dégats");
            target.TakeDamage(dmg);
            base.Attack(target);
        }
    }
}
