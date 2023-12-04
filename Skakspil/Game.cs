using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Skakspil
{
    internal class Game
    {
        public Board board = new Board();
        public void Play()
        {
            GetInput();
        }

        void GetInput()
        {
            Console.WriteLine("Hi and welcome to this game of chess");
            Console.WriteLine("");
            while (true)
            {
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

                

                while (true)
                {
                    Console.WriteLine("\n" + "What piece would you like to move, and where to?");
                    string input = Console.ReadLine();

                    string input1 = input.Substring(0, 1);
                    int input2 = Convert.ToInt32(input.Substring(1, 1));
                    string input3 = input.Substring(2, 1);
                    int input4 = Convert.ToInt32(input.Substring(3, 1));

                    if (input1 == "a" || input1 == "b" || input1 == "c" || input1 == "d" || input1 == "e" || input1 == "f" || input1 == "g" || input1 == "h") {
                    } else {
                        Console.WriteLine("Invalid input");
                        break;
                    }

                    if (input2 == 1 || input2 == 2 || input2 == 3 || input2 == 4 || input2 == 5 || input2 == 6 || input2 == 7 || input2 == 8) {
                    } else {
                        Console.WriteLine("Invalid input");
                        break;
                    }

                    if (input3 == "a" || input3 == "b" || input3 == "c" || input3 == "d" || input3 == "e" || input3 == "f" || input3 == "g" || input3 == "h") {
                    } else {
                        Console.WriteLine("Invalid input");
                        break;
                    }

                    if (input4 == 1 || input4 == 2 || input4 == 3 || input4 == 4 || input4 == 5 || input4 == 6 || input4 == 7 || input4 == 8) {
                    } else {
                        Console.WriteLine("Invalid input");
                        break;
                    }

                    Tuple<int, int> startPos = new(
                        IndexFinderV2(Int32.Parse(input.Substring(1, 1))),
                        IndexFinder(input.Substring(0, 1)) 
                        );

                    Tuple<int, int> endPos = new(
                        IndexFinderV2(Int32.Parse(input.Substring(3, 1))),
                        IndexFinder(input.Substring(2, 1))
                        );

                    board.MovePiece(startPos, endPos);
                    Console.WriteLine($"{board.board[endPos.Item2, endPos.Item1].name}");
                    break;
                }
            }
            
        }
        public string Display(int x, int y)
        {

            Pieces piece = board.board[y, x];

            return piece.name;
            
        }
        int IndexFinder(string input)
        {

            switch (input)
            {
                case "a":
                    return 0;
                case "b":
                    return 1;
                case "c":
                    return 2;
                case "d":
                    return 3;
                case "e":
                    return 4;
                case "f":
                    return 5;
                case "g":
                    return 6;
                case "h":
                    return 7;
                default:
                    return -1;
            }
            
        }

        int IndexFinderV2(int input)
        {
            switch (input)
            {
                case 1:
                    return 7;
                case 2:
                    return 6;
                case 3:
                    return 5;
                case 4:
                    return 4;
                case 5:
                    return 3;
                case 6:
                    return 2;
                case 7:
                    return 1;
                case 8:
                    return 0;
            }
            return -1;
        }
    }
}
