using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skakspil
{
    internal class Game
    {
        public Board board = new Board();
        public King King;
        public void Play()
        {
            SetupBoard();
        }
        void SetupBoard()
        {
            board.board[0, 0] = new Rook(false);
            board.board[1, 0] = new Knight(true);
            board.board[2, 0] = King;
        }
    }
}
