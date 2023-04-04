using HeroesVsMonster.Models.Characters;
using HeroesVsMonster.Models.Characters.Heroes;
using HeroesVsMonster.Models.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.Ui
{
    public interface IUi
    {
        void DisplayMap();
        void SetMap(Map map);
        Hero SelectHeroMenu();
        void StartFight(Character monster);
        string FightAction(Hero hero,Character monster);
        void PrintEquipment(Hero hero);
    }
}
