using HeroesVsMonster.Handler.Interfaces;
using HeroesVsMonster.Handler.Models;
using HeroesVsMonster.Models.Characters;
using HeroesVsMonster.Models.Maps;

namespace HeroesVsMonster.Handler.Commands
{
    public class MoveCommand : ICommand
    {
        private readonly Map _map;
        private readonly Character _character;
        private readonly Direction _direction;
        private event Predicate<Position> _fightEvent;
        public MoveCommand(Map map, Character character, Direction direction, Predicate<Position> fightEvent)
        {
            _map = map;
            _character = character;
            _direction = direction;
            _fightEvent = fightEvent;
        }
        public bool CanMove(Position position)
        {
            (int x, int y) = position;
            if (x < 0 || x >= _map.Width || y < 0 || y >= _map.Height) return false;
            return _map[position].CurrentContent == ContentType.Empty;
        }
        public void Execute(Position position)
        {
            if (!CanMove(position))
            {
                if(_map.IsOut(position)) return;
                if (_map[position].CurrentContent == ContentType.Monster)
                {
                    if (_fightEvent.Invoke(position))
                    {
                        _map.RemoveMonster(position);
                    }
                }
            }
            _map[_character.Position].RevertContent();
            _character.Position = position;
            _map[position].ChangeContent(ContentType.Hero);
        }

        public void Execute()
        {
            (int x, int y) = _character.Position;
            switch (_direction)
            {
                case Direction.North:
                    Execute(new Position(x, y - 1));
                    break;
                case Direction.South:
                    Execute(new Position(x, y + 1));
                    break;
                case Direction.East:
                    Execute(new Position(x + 1, y));
                    break;
                case Direction.West:
                    Execute(new Position(x - 1, y));
                    break;
                default:
                    break;
            }
        }
    }
}
