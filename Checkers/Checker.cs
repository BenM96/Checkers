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

        public override bool ValidMove(Location too, Board board)
        {
            if (validDiaganalMove(too, board))
            {
                return true;
            }
            return false;
        }
        

        private bool validDiaganalMove(Location too, Board board)
        {
            bool occupied;
            bool inReach;
            Occupant O = new Occupant(board);
            if (O.Team(too) == 'X')
            {
                occupied = false;
            }
            else
            {
                occupied = true;
                return false;
            }
            if (this.Local.Add(1, 1 * this.Direction).Equals(too) )
            {
                inReach = true;
            }
            else if (this.Local.Add(-1, 1 * Direction) == too)
            {
                inReach = true;
            }
            else
            {
                inReach = false;
            }
            if(inReach & !occupied)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
