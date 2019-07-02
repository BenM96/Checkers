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
            board.move(LocationConverter.Local(1, 3), LocationConverter.Local(1, 4));
            PrintBoard.Print(board);

            
        }
    }
}
