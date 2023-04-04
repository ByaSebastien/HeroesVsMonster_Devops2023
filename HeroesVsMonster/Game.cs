using HeroesVsMonster.Handler.Handlers;
using HeroesVsMonster.Handler.Interfaces;
using HeroesVsMonster.Models.Characters.Heroes;
using HeroesVsMonster.Models.Maps;
using HeroesVsMonster.Ui;
using HeroesVsMonster.Utils;
using HeroesVsMonster.Utils.Compenents;

namespace HeroesVsMonster
{
    public class Game
    {
        private readonly IHandler _iHandler;
        private readonly Hero _hero;
        private readonly IUi _ui;

        public Map Map { get; private set; }

        public Game(IUi ui)
        {
            TitleScreen.Display();
            GameScreen.Display();
            Screen.PrintSlowGame(3, Story.Intro);
            Console.ReadKey();
            Screen.PrintGame(0, Pictures.Logo);
            _ui = ui;
            _hero = _ui.SelectHeroMenu();
            Map = new Map(_hero);
            _iHandler = new InputHandler(Map, _hero, _ui);
            _ui.SetMap(Map);
            Screen.PrintInfoHero(0, _hero.Name, "Humain", _hero.GetType().Name, "1", $"{_hero.CurrentHp} / {_hero.Hp}", $"{_hero.CurrentMp} / {_hero.Mp}", "0");
            _ui.PrintEquipment(_hero);
        }

        public void Start()
        {
            while (_hero.IsAlive)
            {
                PlayTurn();
            }
        }

        private void PlayTurn()
        {
            _ui.DisplayMap();
            _iHandler.ReadAction();
        }
    }
}
