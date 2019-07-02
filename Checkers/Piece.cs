using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    abstract class Piece
    {
        private Location location;
        private char colour;
        private int direction;
        private int index;

        public abstract bool ValidMove(int col, int row);

        public void move(int col, int row)
        {
            location = new Location(col, row); 
        }

        public int Index
        {
            get { return this.index; }
            set { this.index = value; }
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
            set
            {
                this.colour = value;
            }
        }
        public int Direction
        {
            get
            {
                return this.direction;
            }
            set
            {
                this.direction = value;
            }
        }
    }
}
