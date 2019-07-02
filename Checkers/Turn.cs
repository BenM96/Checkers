using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    static class Turn
    {
        public static bool TakeTurn(Board board, char colour, Location from, Location too)
        {
            Occupant occupant = new Occupant(board);
            Piece mover = occupant.Piece(from);
            if(mover is null)
            {
                return false;
            }
            if (!(mover.Colour == colour))
            {
                return false;
            }

            return false;
        }
    }
}
