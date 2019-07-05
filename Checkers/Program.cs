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
            bool whiteTurn = false;
            Occupant O = new Occupant(board);
            PrintBoard.Print(board);

            Turn.TakeTurn(board, 'W', new Location(2,6), new Location(1, 5));
            Turn.TakeTurn(board, 'W', new Location(1, 5), new Location(2, 4));
            
            PrintBoard.Print(board);

            
        }
    }
}
