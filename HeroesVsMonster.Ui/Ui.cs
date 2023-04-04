using HeroesVsMonster.Models.Characters;
using HeroesVsMonster.Models.Characters.Heroes;
using HeroesVsMonster.Models.Characters.Monsters;
using HeroesVsMonster.Models.Maps;
using HeroesVsMonster.Utils;

namespace HeroesVsMonster.Ui
{
    public class Ui : IUi
    {
        private Map? _map;
        public void DisplayMap()
        {
            Screen.PrintGame(0, Pictures.Map);
            if (_map != null)
            {
                Screen.PrintCharacter(_map._hero.Position.X, _map._hero.Position.Y, _map._hero.Sprite);
                foreach (KeyValuePair<Position, Character> kvp in _map.Monsters)
                {
                    Screen.PrintCharacter(kvp.Key.X, kvp.Key.Y, kvp.Value.Sprite);
                }
            }
        }

        public void StartFight(Character monster)
        {
            switch (monster)
            {
                case Wolf:
                    Screen.PrintInfoMonster(0, "Loup");
                    Screen.PrintInfo("Un loup sauvage apparait");
                    Screen.PrintGame(0, Pictures.Wolf);
                    break;
                case Troll:
                    Screen.PrintInfoMonster(0, "Troll");
                    Screen.PrintInfo("Un troll sauvage apparait");
                    Screen.PrintGame(0, Pictures.Troll);
                    break;
                case Dragon:
                    Screen.PrintInfoMonster(0, "Dragon");
                    Screen.PrintInfo("Un dragon sauvage apparait");
                    Screen.PrintGame(0, Pictures.Dragon);
                    break;
            }
            Screen.PrintInfoMonster(1,$"{monster.CurrentHp} / {monster.Hp}",$"{monster.CurrentMp} / {monster.Mp}");
        }
        public string FightAction(Hero hero, Character monster)
        {
            string attackChoice = Screen.PrintActions("Attaquer", "Competence", "Se Soigner").ToLower();
            Screen.ClearInfo();
            Screen.ClearAction();
            return attackChoice;
        }

        public Hero SelectHeroMenu()
        {
            string herochoice = Screen.PrintGameVerticalMenu(22, "Guerrier", "Voleur", "Mage").ToLower();
            Screen.PrintSlowInfo("Nom de votre personnage : ");
            string nom = Console.ReadLine()?.Trim() ?? "";
            Screen.ClearInfo();
            switch (herochoice)
            {
                case "guerrier": return new Warrior(nom);
                case "voleur": return new Thief(nom);
                case "mage": return new Mage(nom);
                default: throw new KeyNotFoundException();
            }
        }

        public void SetMap(Map map)
        {
            _map = map;
        }

        public void PrintEquipment(Hero hero)
        {
            Screen.PrintEquipment(0,
                                  hero.Equipment[Models.Properties.Stuff.EquipmentType.Weapon]?.Name ?? "Aucun",
                                  hero.Equipment[Models.Properties.Stuff.EquipmentType.Helmet]?.Name ?? "Aucun",
                                  hero.Equipment[Models.Properties.Stuff.EquipmentType.Armor]?.Name ?? "Aucun",
                                  hero.Equipment[Models.Properties.Stuff.EquipmentType.Gloves]?.Name ?? "Aucun",
                                  hero.Equipment[Models.Properties.Stuff.EquipmentType.Boots]?.Name ?? "Aucun"
                                  );
        }
    }
}
