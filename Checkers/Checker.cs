using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Checker: Piece
    {

        public Checker(int col, int row, char colour, int direction)
        {
            Local = new Location(col, row);
            Colour = colour;
            Direction = direction;
        }
        public override bool ValidMove(int col, int row)
        {
            return false;
        }
    }
}
