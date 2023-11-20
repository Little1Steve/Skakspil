using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skakspil
{
    internal class Board
    {

        public Pieces[,] board = { 

        {new Rook(false),  new Knight(false), new Bishop(false), new Queen(false), new King(false),  new Bishop(false), new Knight(false), new Rook(false) },
        {new Pawn(false),  new Pawn(false),   new Pawn(false),   new Pawn(false),  new Pawn(false),  new Pawn(false),   new Pawn(false),   new Pawn(false) },
        {new Empty(false), new Empty(false),  new Empty(false),  new Empty(false), new Empty(false), new Empty(false),  new Empty(false),  new Empty(false) },
        {new Empty(false), new Empty(false),  new Empty(false),  new Empty(false), new Empty(false), new Empty(false),  new Empty(false),  new Empty(false)},
        {new Empty(false), new Empty(false),  new Empty(false),  new Empty(false), new Empty(false), new Empty(false),  new Empty(false),  new Empty(false)},
        {new Empty(false), new Empty(false),  new Empty(false),  new Empty(false), new Empty(false), new Empty(false),  new Empty(false),  new Empty(false)},
        {new Pawn(true),   new Pawn(true),    new Pawn(true),    new Pawn(true),   new Pawn(true),   new Pawn(true),    new Pawn(true),    new Pawn(true)},
        {new Rook(true),   new Knight(true),  new Bishop(true),  new Queen(true),  new King(true),   new Bishop(true),  new Knight(true),  new Rook(true) }

        };

        public void MovePiece(Tuple<int, int> startPos, Tuple<int, int> endPos)
        {
            Pieces piece = this.board[startPos.Item1+2, startPos.Item2];

            this.board[endPos.Item1+2, endPos.Item2] = piece;

            this.board[startPos.Item1+2, startPos.Item2] = new Empty(false);

        }
    }
}