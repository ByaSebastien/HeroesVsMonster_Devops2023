using HeroesVsMonster;
using HeroesVsMonster.Models.Characters;
using HeroesVsMonster.Models.Characters.Heroes;
using HeroesVsMonster.Models.Characters.Monsters;
using HeroesVsMonster.Models.Maps;
using HeroesVsMonster.Ui;
using HeroesVsMonster.Utils;
using HeroesVsMonster.Utils.Compenents;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.CursorVisible = false;
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;

IUi ui = new Ui();
Game game = new Game(ui);
game.Start();
Console.ReadKey();