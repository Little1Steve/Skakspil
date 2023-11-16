using Skakspil;

Game game = new Game();
game.Play();

Console.WriteLine("" +
    "╔═══╦═══╦═══╦═══╦═══╦═══╦═══╦═══╗\n" +
    $"║ {game.Display(0,0)} ║ {game.Display(1, 0)} ║ {game.Display(2, 0)} ║ {game.Display(3, 0)} ║ {game.Display(4, 0)} ║ {game.Display(5, 0)} ║ {game.Display(6, 0)} ║ {game.Display(7, 0)} ║ 8\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    $"║ {game.Display(0,1)} ║ {game.Display(1, 1)} ║ {game.Display(2, 1)} ║ {game.Display(3, 1)} ║ {game.Display(4, 1)} ║ {game.Display(5, 1)} ║ {game.Display(6, 1)} ║ {game.Display(7, 1)} ║ 7\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    $"║ {game.Display(0,2)} ║ {game.Display(1, 2)} ║ {game.Display(2, 2)} ║ {game.Display(3, 2)} ║ {game.Display(4, 2)} ║ {game.Display(5, 2)} ║ {game.Display(6, 2)} ║ {game.Display(7, 2)} ║ 6\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    $"║ {game.Display(0,3)} ║ {game.Display(1, 3)} ║ {game.Display(2, 3)} ║ {game.Display(3, 3)} ║ {game.Display(4, 3)} ║ {game.Display(5, 3)} ║ {game.Display(6, 3)} ║ {game.Display(7, 3)} ║ 5\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    $"║ {game.Display(0,4)} ║ {game.Display(1, 4)} ║ {game.Display(2, 4)} ║ {game.Display(3, 4)} ║ {game.Display(4, 4)} ║ {game.Display(5, 4)} ║ {game.Display(6, 4)} ║ {game.Display(7, 4)} ║ 4\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    $"║ {game.Display(0,5)} ║ {game.Display(1, 5)} ║ {game.Display(2, 5)} ║ {game.Display(3, 5)} ║ {game.Display(4, 5)} ║ {game.Display(5, 5)} ║ {game.Display(6, 5)} ║ {game.Display(7, 5)} ║ 3\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    $"║ {game.Display(0,6)} ║ {game.Display(1, 6)} ║ {game.Display(2, 6)} ║ {game.Display(3, 6)} ║ {game.Display(4, 6)} ║ {game.Display(5, 6)} ║ {game.Display(6, 6)} ║ {game.Display(7, 6)} ║ 2\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    $"║ {game.Display(0,7)} ║ {game.Display(1, 7)} ║ {game.Display(2, 7)} ║ {game.Display(3, 7)} ║ {game.Display(4, 7)} ║ {game.Display(5, 7)} ║ {game.Display(6, 7)} ║ {game.Display(7, 7)} ║ 1\n" +
    "╚═══╩═══╩═══╩═══╩═══╩═══╩═══╩═══╝\n" +
    "  a   b   c   d   e   f   g   h");