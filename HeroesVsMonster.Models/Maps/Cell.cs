using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.Models.Maps
{
    public class Cell
    {
        public Position Position { get; set; }
        public ContentType CurrentContent { get; private set; }
        public ContentType OldContent { get; private set; }

        public Cell(Position position)
        {
            Position = position;
            CurrentContent = ContentType.Empty;
            OldContent = ContentType.Empty;
        }
        public Cell(int x, int y) : this(new Position(x, y)) { }

        //public (int x, int y) GetPosition()
        //{
        //    (int x, int y) = Position;
        //    return (x, y);
        //}

        public void ChangeContent(ContentType newContent)
        {
            OldContent = CurrentContent;
            CurrentContent = newContent;
        }

        public void RevertContent()
        {
            OldContent = CurrentContent;
            CurrentContent = ContentType.Empty;
        }
    }
}
