using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skakspil
{
    internal class Game
    {
        public void Play()
        {
            SetupBoard();
        }
        void SetupBoard()
        {
            Board board = new Board();
            board.board[0, 0] = new Rook(false);
            board.board[1, 0] = new Knight(true);
        }
    }
}
