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
            Occupant O = new Occupant(board);
            Piece mover = O.Piece(from);
            if(mover is null)
            {
                Console.WriteLine("there is nothing there");
                return false;
            }
            if (!(mover.Colour == colour))
            {
                Console.WriteLine("That is not your piece there");
                return false;
            }
            if (mover.ValidMove(too, board))
            {
                mover.move(too);
                Console.WriteLine("valid move");
                return true;
            }
            else
            {
                Console.WriteLine("invalid move bozo");
                return false;
            }
        }
    }
}
