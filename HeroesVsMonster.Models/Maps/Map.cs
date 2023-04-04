using HeroesVsMonster.Models.Characters;
using HeroesVsMonster.Models.Characters.Heroes;
using HeroesVsMonster.Models.Characters.Monsters;

namespace HeroesVsMonster.Models.Maps
{
    public class Map
    {
        public Hero _hero { get; }
        public Dictionary<Position, Character> Monsters { get; } = new Dictionary<Position, Character>();

        public Character GetMonster(Position position)
        {
            return Monsters[position];
        }
        public Cell this[Position pos] => _cells[pos.X, pos.Y];
        public Cell this[int x, int y] => _cells[x, y];

        public readonly Cell[,] _cells;
        public readonly int Width = 20;
        public readonly int Height = 8;

        public Map(Hero hero)
        {
            _cells = new Cell[Width, Height];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    _cells[i, j] = new Cell(i, j);
                }
            }
            _hero = hero;
            _hero.Position = new Position(9, 7);

            this[_hero.Position].ChangeContent(ContentType.Hero);

            Position position;
            for (int i = 0; i < 50; i++)
            {
                Character character = MonsterFactory.GenerateMonster();
                do
                {
                    position = new Position(new Random().Next(Width), new Random().Next(Height));
                } while (this[position].CurrentContent != ContentType.Empty);
                character.Position = position;
                character.DieEvent += hero.Loot;
                Monsters.Add(character.Position, character);
                this[character.Position].ChangeContent(ContentType.Monster);
            }
        }

        public bool IsOut(Position position)
        {
            (int x, int y) = position;
            if (x < 0 || x >= Width) return true;
            if (y < 0 || y >= Height) return true;
            return false;
        }

        public void RemoveMonster(Position position)
        {
            this[position].ChangeContent(ContentType.Empty);
            Monsters.Remove(position);
        }
    }
}
