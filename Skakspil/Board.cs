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
        {new Empty(false), new Empty(false),  new Empty(false),  new Pawn(false), new Pawn(false), new Empty(false),  new Empty(false),  new Empty(false) },
        {new Empty(false), new Empty(false),  new Empty(false),  new Empty(false), new Empty(false), new Empty(false),  new Empty(false),  new Empty(false)},
        {new Empty(false), new Empty(false),  new Empty(false),  new Empty(false), new Empty(false), new Empty(false),  new Empty(false),  new Empty(false)},
        {new Empty(false), new Empty(false),  new Empty(false),  new Pawn(true), new Pawn(true), new Empty(false),  new Empty(false),  new Empty(false)},
        {new Pawn(true),   new Pawn(true),    new Pawn(true),    new Pawn(true),   new Pawn(true),   new Pawn(true),    new Pawn(true),    new Pawn(true)},
        {new Rook(true),   new Knight(true),  new Bishop(true),  new Queen(true),  new King(true),   new Bishop(true),  new Knight(true),  new Rook(true) }

        };

        public bool whiteTurn = true;

        public void MovePiece(Tuple<int, int> startPos, Tuple<int, int> endPos)
        {
            Pieces piece = this.board[startPos.Item1, startPos.Item2];

            Pieces maybeKing = this.board[endPos.Item1, endPos.Item2];
            if (maybeKing.king)
            {
                Game.matchNumber++;
            }
            else if (!piece.empty && piece.white == whiteTurn)
            {
                this.board[endPos.Item1, endPos.Item2] = piece;

                this.board[startPos.Item1, startPos.Item2] = new Empty(false);
                if (whiteTurn)
                {
                    whiteTurn = false;
                }
                else
                {
                    whiteTurn = true;
                }
            }
            else if(piece.empty)
            {
                Console.WriteLine("You must move a piece.\nTry again");
            }
            else if(piece.white != whiteTurn)
            {
                Console.WriteLine("You must move a piece according to whose turn it is.\nTry again");
            }
            else
            {
                Console.WriteLine("Error");
            }
            

            

        }
    }
}