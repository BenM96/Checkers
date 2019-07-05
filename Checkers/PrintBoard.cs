using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    static class PrintBoard
    {
        public static void Print(Board board)
        {
            Console.WriteLine();
            Occupant O= new Occupant(board);
            for(int row = 8; row > 0; row--)
            {
                Console.Write("|");
                for(int col =1; col<9; col++)
                {
                    if (O.Team(col, row) == 'X')
                    {
                        Console.Write(" |");
                    }
                    else
                    {
                        Console.Write(O.Team(col, row)+"|");

                    }
                }
                Console.WriteLine("\n - - - - - - - -");
            }
            Console.WriteLine();
        }
    }
}
