using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Occupant
    {
        private Board board;

        public Piece Piece(Location local)
        {
            if (!(board.Blacks.Occupied(local) is null))
            {
                return board.Blacks.Occupied(local);
            }
            if (!(board.Whites.Occupied(local) is null))
            {
                return board.Whites.Occupied(local);
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

        public Occupant(Board board)
        {
            this.board = board;
        }
        public Board Board
        {
            get { return this.board; }
            set { this.board = value; }
        }
    }
}
