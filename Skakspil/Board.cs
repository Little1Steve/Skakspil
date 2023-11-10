using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skakspil
{
    internal class Board
    {
        public Pieces[,]? board;
        King blackKing = new King()[4][0];
        King whiteKing = new King()[4][7];

        Queen blackQueen = new Queen()[3][0];
        Queen whiteQueen = new Queen()[3][7];

        Bishop blackBishop1 = new Bishop()[2][0];
        Bishop blackBishop2 = new Bishop()[5][0];
        Bishop whiteBishop1 = new Bishop()[2][7];
        Bishop whiteBishop2 = new Bishop()[5][7];

        Knight blackKnight1 = new Knight()[][];
        Knight blackKnight2 = new Knight()[][];
        Knight whiteKnight1 = new Knight()[][];
        Knight whiteKnight2 = new Knight()[][];

        Rook blackRook1 = new Rook()[][];
        Rook blackRook2 = new Rook()[][];
        Rook whiteRook1 = new Rook()[][];
        Rook whiteRook2 = new Rook()[][];
    }
}