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
        public void Play()
        {
            SetupBoard();
        }
        void SetupBoard()
        {
            board.board[0, 0] = new Rook(false);
            board.board[1, 0] = new Knight(false);
            board.board[2, 0] = new King(false);
        }
        void GetInput()
        {
            Console.WriteLine("Hi and welcome to this game of chess");
            Console.WriteLine("");
            Console.WriteLine("" +
    "╔═══╦═══╦═══╦═══╦═══╦═══╦═══╦═══╗\n" +
    $"║ {Display(0, 0)} ║ {Display(1, 0)} ║ {Display(2, 0)} ║ {Display(3, 0)} ║ {Display(4, 0)} ║ {Display(5, 0)} ║ {Display(6, 0)} ║ {Display(7, 0)} ║ 8\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    $"║ {Display(0, 1)} ║ {Display(1, 1)} ║ {Display(2, 1)} ║ {Display(3, 1)} ║ {Display(4, 1)} ║ {Display(5, 1)} ║ {Display(6, 1)} ║ {Display(7, 1)} ║ 7\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    $"║ {Display(0, 2)} ║ {Display(1, 2)} ║ {Display(2, 2)} ║ {Display(3, 2)} ║ {Display(4, 2)} ║ {Display(5, 2)} ║ {Display(6, 2)} ║ {Display(7, 2)} ║ 6\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    $"║ {Display(0, 3)} ║ {Display(1, 3)} ║ {Display(2, 3)} ║ {Display(3, 3)} ║ {Display(4, 3)} ║ {Display(5, 3)} ║ {Display(6, 3)} ║ {Display(7, 3)} ║ 5\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    $"║ {Display(0, 4)} ║ {Display(1, 4)} ║ {Display(2, 4)} ║ {Display(3, 4)} ║ {Display(4, 4)} ║ {Display(5, 4)} ║ {Display(6, 4)} ║ {Display(7, 4)} ║ 4\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    $"║ {Display(0, 5)} ║ {Display(1, 5)} ║ {Display(2, 5)} ║ {Display(3, 5)} ║ {Display(4, 5)} ║ {Display(5, 5)} ║ {Display(6, 5)} ║ {Display(7, 5)} ║ 3\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    $"║ {Display(0, 6)} ║ {Display(1, 6)} ║ {Display(2, 6)} ║ {Display(3, 6)} ║ {Display(4, 6)} ║ {Display(5, 6)} ║ {Display(6, 6)} ║ {Display(7, 6)} ║ 2\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    $"║ {Display(0, 7)} ║ {Display(1, 7)} ║ {Display(2, 7)} ║ {Display(3, 7)} ║ {Display(4, 7)} ║ {Display(5, 7)} ║ {Display(6, 7)} ║ {Display(7, 7)} ║ 1\n" +
    "╚═══╩═══╩═══╩═══╩═══╩═══╩═══╩═══╝\n" +
    "  a   b   c   d   e   f   g   h");
        }
        public string Display(int x, int y)
        {
            Pieces piece = board.board[x, y];
            if(piece == null)
            {
                return " ";
            }
            else
            {
                return piece.name;
            }
        }
    }
}
