using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Piece
    {
        private Location location;
        private char colour;

        public Piece(int col, int row, char colour)
        {
            this.colour = colour;
            this.location = new Location(col, row);
        }
    }
}
