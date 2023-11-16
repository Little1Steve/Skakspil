﻿using Skakspil;

Game game = new Game();
game.Play();

Console.WriteLine("Welcome to the chess game");
Console.WriteLine("Feel free to make white's first move");
Console.WriteLine("" +
    "╔═══╦═══╦═══╦═══╦═══╦═══╦═══╦═══╗\n" +
    "║ R ║ N ║ B ║ Q ║ K ║ B ║ N ║ R ║ 8\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    "║ P ║ P ║ P ║ P ║ P ║ P ║ P ║ P ║ 7\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    "║   ║   ║   ║   ║   ║   ║   ║   ║ 6\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    "║   ║   ║   ║   ║   ║   ║   ║   ║ 5\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    "║   ║   ║   ║   ║   ║   ║   ║   ║ 4\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    "║   ║   ║   ║   ║   ║   ║   ║   ║ 3\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    "║ p ║ p ║ p ║ p ║ p ║ p ║ p ║ p ║ 2\n" +
    "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
    "║ r ║ n ║ b ║ q ║ k ║ b ║ n ║ r ║ 1\n" +
    "╚═══╩═══╩═══╩═══╩═══╩═══╩═══╩═══╝\n" +
    "  a   b   c   d   e   f   g   h");

Console.WriteLine(Array.LastIndexOf(game.board.board, game.King));