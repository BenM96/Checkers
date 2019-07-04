using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            PrintBoard.Print(board);

            Turn.TakeTurn(board, 'B', new Location(1,3), new Location(2, 4));
            PrintBoard.Print(board);

            
        }
    }
}
