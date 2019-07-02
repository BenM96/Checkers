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
            Occupant O= new Occupant(board);
            for(int row = 8; row > 0; row--)
            {
                for(int col =1; col<9; col++)
                {
                    Console.Write(O.Team(col, row));
                }
                Console.WriteLine();
            }
        }
    }
}
