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

        public abstract bool ValidMove(Location too, Board board);

        public bool ValidMove(int col, int row, Board board)
        {
            return ValidMove(new Location(col, row), board);
        }

        public void move(int col, int row)
        {
            this.location = new Location(col, row); 
        }

        public void move(Location too)
        {
            this.location = too;
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
