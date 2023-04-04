using HeroesVsMonster.Models.Characters;
using HeroesVsMonster.Models.Characters.Heroes;
using HeroesVsMonster.Models.Characters.Monsters;
using HeroesVsMonster.Models.Maps;
using HeroesVsMonster.Ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.Handler.Interfaces
{
    public interface IHandler
    {
        void ReadAction();
        bool ReadFightAction(IUi ui,Hero hero,Character monster);
    }
}
