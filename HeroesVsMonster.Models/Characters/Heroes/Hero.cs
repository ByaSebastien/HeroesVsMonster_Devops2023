using HeroesVsMonster.Models.Properties.Inventory;
using HeroesVsMonster.Models.Properties.Skills;
using HeroesVsMonster.Models.Properties.Statistics;
using HeroesVsMonster.Models.Properties.Stuff;
using HeroesVsMonster.Utils;

namespace HeroesVsMonster.Models.Characters.Heroes
{
    public abstract class Hero : Character
    {
        public string Name { get; set; }
        public Items Inventory { get; set; }
        public Equipments Equipment { get; set; }
        public Skill[] Skills { get; set; }
        public Hero(string sprite, string name) : base(sprite)
        {
            Inventory = new Items();
            Equipment = new Equipments();
            Skills = new Skill[4];
            Name = name;
            Stats.Generate(Utils.DiceType.D10, 5, 3);
            //TODO
            //DieEvent += 
        }
        public void Loot(Character target)
        {
        }
        public override int GetStatValue(StatType stat)
        {
            return Stats[stat] + Equipment.GetStatValue(stat);
        }
    }
}
