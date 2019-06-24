using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Piece
    {
        private int id;
        private Location location;
        private char colour;

        public Piece(int col, int row, char colour)
        {
            this.colour = colour;
            this.location = new Location(col, row);
        }

        public int ID
        {
            get
            {
                return this.id;

            }
        }
        public Location Local {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
                }
        public char Colour
        {
            get
            {
                return this.colour;
            }
        }
    }
}
