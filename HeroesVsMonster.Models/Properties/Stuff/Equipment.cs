using HeroesVsMonster.Models.Characters.Heroes;
using HeroesVsMonster.Models.Properties.Statistics;

namespace HeroesVsMonster.Models.Properties.Stuff
{
    public class Equipment
    {
        public Stats Stats { get; set; }
        public EquipmentType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Equipment(string name, string description)
        {
            Stats = new Stats();
            Name = name;
            Description = description;
        }

        public void Equip(Hero hero)
        {
            hero.Equipment[Type] = this;
        }
    }
}
