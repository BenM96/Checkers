using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Location
    {
        private int col;
        private int row;

        public Location(int col, int row)
        {
            this.col = col;
            this.row = row;
        }

        public int Col {
            get
            {
                return this.col;
            }
            set
            {
                this.col = value;
            }
        }
        public int Row {
            get
            {
                return this.row;
            }
            set
            {
                this.row = value;
            }
        }
    }
}
