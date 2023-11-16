using System;
using System.Collections.Generic;
using System.Linq;
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

    }
    internal class King : Pieces
    {
        public King(bool white) : base(white)
        {
            
        }
    }
    internal class Queen : Pieces
    {
        public Queen(bool white) : base(white)
        {
            
        }
    }
    internal class Bishop : Pieces
    {
        public Bishop(bool white) : base(white)
        {

        }
    }
    internal class Knight : Pieces
    {
        public Knight(bool white) : base(white)
        {

        }
    }
    internal class Rook : Pieces
    {
        public Rook(bool white) : base(white)
        {
        }
    }
    internal class Pawn : Pieces
    {
        public Pawn(bool white) : base(white)
        {
        }
    }
}
