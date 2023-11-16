using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Skakspil
{
    internal class Pieces
    {
        public List<Moves> legalMoves;
        public bool white = false;

        public Pieces(bool white)
        {
            this.white = white;
        }

        public int index1;
        public int index2;

        public string name;
    }
    internal class King : Pieces
    {
        
        public King(bool white) : base(white)
        {
            if (white)
            {
                name = "k";
            }
            else
            {
                name = "K";
            }
        }
    }
    internal class Queen : Pieces
    {
        public Queen(bool white) : base(white)
        {
            if (white)
            {
                name = "q";
            }
            else
            {
                name = "Q";
            }
        }
    }
    internal class Bishop : Pieces
    {
        public Bishop(bool white) : base(white)
        {
            if (white)
            {
                name = "b";
            }
            else
            {
                name = "B";
            }
        }
    }
    internal class Knight : Pieces
    {
        public Knight(bool white) : base(white)
        {
            if (white)
            {
                name = "n";
            }
            else
            {
                name = "N";
            }
        }
    }
    internal class Rook : Pieces
    {
        public Rook(bool white) : base(white)
        {
            if (white)
            {
                name = "r";
            }
            else
            {
                name = "R";
            }
        }
    }
    internal class Pawn : Pieces
    {
        public Pawn(bool white) : base(white)
        {
            if (white)
            {
                name = "p";
            }
            else
            {
                name = "P";
            }
        }
    }
    internal class Empty : Pieces
    {
        public Empty(bool white) : base(white)
        {

        }
    }
}
