using HeroesVsMonster.Models.Properties.Statistics;
using HeroesVsMonster.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.Models.Characters.Monsters
{
    public class Dragon : Monster
    {
        public Dragon() : base("  🐉")
        {
            Stats.Append(StatType.Hp, 10);
            Stats.Append(StatType.Mp, 10);
            Stats.Append(StatType.Inteligence, 10);
            Stats.Append(StatType.Defence, 10);
            FullRegen();
        }
        public override void Attack(Character target)
        {
            int dmg = (Inteligence - target.Resistance <= 0 ? 1 : Inteligence - target.Resistance) + Dice.Throws(DiceType.D4);
            Screen.PrintInfo($"Le dragon attaque et fait {dmg} de dégats");
            target.TakeDamage(dmg);
            base.Attack(target);
        }
    }
}
