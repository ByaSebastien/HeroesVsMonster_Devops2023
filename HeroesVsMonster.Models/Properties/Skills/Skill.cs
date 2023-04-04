using HeroesVsMonster.Models.Characters;
using HeroesVsMonster.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.Models.Properties.Skills
{
    public class Skill
    {
        public Skill(string name,decimal damage,int precision)
        {
            Name = name;
            Damage = damage;
            Precision = precision;
        }
        public string Name { get;}
        public decimal Damage { get;}
        public int Precision { get;}
        public bool Activate(Character character,Character target)
        {
            if(Dice.Throws(DiceType.D10) > Precision)
                return false;
            target.TakeDamage((int)(character.Strenght * Damage));
            return true;
        }
    }
}
