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
            Console.WriteLine(board.Blacks.Length);
            int row = 8;
            while (row > 0)
            {
                int col = 1;
                while (col < 9)
                {
                    bool empty = true;
                    foreach (Piece p in board.Blacks)
                    {
                        if (p.Local.Col == col & p.Local.Row == row)
                        {
                            Console.Write('B');
                            empty = false;
                        }
                    }
                    foreach (Piece p in board.Whites)
                    {
                        if(p.Local.Col==col & p.Local.Row == row)
                        {
                            Console.Write('W');
                            empty = false;
                        }
                    }
                    if (empty)
                    {
                        Console.Write('X');
                    }
                    
                    col++;
                }
                Console.WriteLine();
                row--;
            }
        }
    }
}
