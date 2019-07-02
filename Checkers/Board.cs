using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Board
    {
        private Team blacks;
        private Team whites;




        public Board()
        {
            this.blacks = new Team('B');
            this.whites = new Team('W');
        }

        

        public Team Whites
        {
            get
            {
                return this.whites;
            }
            set
            {
                this.whites = value;
            }
        }
        public Team Blacks
        {
            get
            {
                return this.blacks;
            }
            set
            {
                this.blacks = value;
            }
        }

    }
}