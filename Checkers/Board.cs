using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Board
    {
        private Piece[] Blacks = new Piece[8];
        private Piece[] Whites = new Piece[8];

        public Board()
        {
            Blacks[0] = new Piece(1, 1, 'B');
        }

    }
}