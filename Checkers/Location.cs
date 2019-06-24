using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Location
    {
        private int[] local = new int[2];

        public Location(int col, int row)
        {
            this.local[0] = col;
            this.local[1] = row;
        }

        public int[] Local
        {
            get
            {
                return this.local;
            }
            set
            {
                this.local = value;
            }
        }
    }
}
