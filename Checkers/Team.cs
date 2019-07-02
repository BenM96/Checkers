using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Team
    {
        private ArrayList pieces = new ArrayList();
        private char name;
        private int direction;

        public Piece Occupied(Location local)
        {
            foreach (Piece p in Pieces)
            {
                if (p.Local.Col == local.Col & p.Local.Row==local.Row)
                {
                    return p;
                }
            }
            return null;
        }


        public Team(char name)
        {
            int startingRow;
            this.name = name;
            if (name == 'B')
            {
                this.direction = 1;
                startingRow = 1;
            }
            else if (name == 'W')
            {
                this.direction = -1;
                startingRow = 6;
            }
            else
            {
                Console.WriteLine("Invalid team:" + name);
                startingRow = -10;
            }

            for( int col=1; col<9; col++)
            {
                int doublePiece = direction;
                //Console.WriteLine(col);
                if (col % 2==0)
                {
                    doublePiece = -1 * direction;
                }
                if (doublePiece == 1)
                {
                    pieces.Add(new Checker(col, startingRow, name, direction));
                    pieces.Add(new Checker(col, startingRow + 2, name, direction));
                }
                else
                {
                    pieces.Add(new Checker(col, startingRow + 1, name, direction));
                }
            }
            foreach (Piece p in pieces)
            {
                p.Index=pieces.IndexOf(p);
            }

        }

        public ArrayList Pieces
        {
            get
            {
                return this.pieces;
            }
            set
            {
                this.pieces = value;
            }
        }
    }
}
