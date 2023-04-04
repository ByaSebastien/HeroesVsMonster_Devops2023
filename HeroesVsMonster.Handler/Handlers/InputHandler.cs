using HeroesVsMonster.Handler.Commands;
using HeroesVsMonster.Handler.Interfaces;
using HeroesVsMonster.Handler.Models;
using HeroesVsMonster.Models.Characters;
using HeroesVsMonster.Models.Characters.Heroes;
using HeroesVsMonster.Models.Characters.Monsters;
using HeroesVsMonster.Models.Maps;
using HeroesVsMonster.Ui;
using HeroesVsMonster.Utils;

namespace HeroesVsMonster.Handler.Handlers
{
    public class InputHandler : IHandler
    {
        private ICommand _moveNorth;
        private ICommand _moveWest;
        private ICommand _moveSouth;
        private ICommand _moveEast;

        public InputHandler(Map map, Hero hero, IUi ui)
        {
            _moveNorth = new MoveCommand(map, hero, Models.Direction.North, (Position position) => HandleFightEvent(ui, hero, map.GetMonster(position)));
            _moveSouth = new MoveCommand(map, hero, Models.Direction.South, (Position position) => HandleFightEvent(ui, hero, map.GetMonster(position)));
            _moveEast = new MoveCommand(map, hero, Models.Direction.East, (Position position) => HandleFightEvent(ui, hero, map.GetMonster(position)));
            _moveWest = new MoveCommand(map, hero, Models.Direction.West, (Position position) => HandleFightEvent(ui, hero, map.GetMonster(position)));
        }
        public bool HandleFightEvent(IUi ui, Hero hero, Character monster)
        {
            ui.StartFight(monster);
            return ReadFightAction(ui, hero, monster);
        }

        public void ReadAction()
        {
            ConsoleKeyInfo cki = Console.ReadKey(true);

            switch (cki.Key)
            {
                case ConsoleKey.UpArrow: _moveNorth.Execute(); break;
                case ConsoleKey.DownArrow: _moveSouth.Execute(); break;
                case ConsoleKey.LeftArrow: _moveWest.Execute(); break;
                case ConsoleKey.RightArrow: _moveEast.Execute(); break;
                case ConsoleKey.Escape: Environment.Exit(0); break;
                default:
                    break;
            }
        }

        public bool ReadFightAction(IUi ui, Hero hero, Character monster)
        {
            do
            {
                string attackChoice = ui.FightAction(hero, monster);
                if (monster.Speed > hero.Speed)
                {
                    monster.Attack(hero);
                    Screen.PrintInfoHero(4, $"{hero.CurrentHp} / {hero.Hp}");
                    Console.ReadKey();
                }
                switch (attackChoice)
                {
                    case "attaquer":
                        hero.Attack(monster);
                        Screen.PrintInfoMonster(1, monster.CurrentHp + " / " + monster.Hp);
                        break;
                    case "competence":
                        break;
                    case "se soigner":
                        hero.FullRegen();
                        Screen.PrintInfo($"{hero.Name} se soigne et récupère tout ces Hp.");
                        Screen.PrintInfoHero(4, $"{hero.CurrentHp} / {hero.Hp}");
                        break;
                }
                Console.ReadKey();
                if (monster.IsAlive && monster.Speed <= hero.Speed)
                {
                    monster.Attack(hero);
                    Screen.PrintInfoHero(4, $"{hero.CurrentHp}  / {hero.Hp}");
                    Console.ReadKey();
                }
                Screen.ClearInfo();
            } while (hero.IsAlive && monster.IsAlive);
            Screen.ClearInfoMonster();
            return hero.IsAlive;

        }
    }
}
