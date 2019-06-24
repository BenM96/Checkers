using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Board
    {
        private Piece[] blacks = new Piece[12];
        private Piece[] whites = new Piece[12];

        public Board()
        {
            int col = 1;
            int bRow;
            int wRow;
            while (col < 9)
            {
                if (col % 2 == 0)
                {
                    bRow = 2;
                    wRow = 8;
                }
                else
                {
                    bRow = 1;
                    wRow = 7;
                }
                blacks[col-1] = new Piece(col, bRow, 'b');
                whites[col-1] = new Piece(col, wRow, 'w');
                col++;
            }
            col = 1;
            while (col < 9)
            {
                Console.Write(col);
                blacks[8+(col/2)] = new Piece(col, 3, 'b');
                whites[8 + (col / 2)] = new Piece(col + 1, 6, 'w');
                col += 2;
            }
        }

        public Piece[] Whites
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
        public Piece[] Blacks
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