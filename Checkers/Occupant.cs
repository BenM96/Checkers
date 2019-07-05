using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Occupant
    {
        private Team whites;
        private Team blacks;

        public Piece Piece(Location local)
        {
            if (!(blacks.Occupied(local) is null))
            {
                return blacks.Occupied(local);
            }
            if (!(whites.Occupied(local) is null))
            {
                return whites.Occupied(local);
            }
            return null;
        }

        public Piece Piece(int col, int row)
        {
            Location local = new Location(col, row);
            return Piece(local);
        }

        public char Team(Location local)
        {
            Piece occupant = Piece(local);
            if (occupant is null)
            {
                return 'X';
            }
            return occupant.Colour;
        }

        public char Team(int col, int row)
        {
            Location local = new Location(col, row);
            return Team(local);
        }

        public void update(Board board)
        {
            this.whites = board.Whites;
            this.blacks = board.Blacks;
        }
        public Occupant(Board board)
        {
            this.whites = board.Whites;
            this.blacks = board.Blacks;
        }

        public Occupant(Team whites, Team blacks)
        {
            this.whites = whites;
            this.blacks = blacks;
        }
        
    }
}
