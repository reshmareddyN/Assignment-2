using System;

public class GemHunters
{
    static void Main(string[] args)
    {
        char[,] board = new char[6, 6];
        int player1Score = 0;
        int player2Score = 0;
        // Initialize the board
        InitializeBoard(board);

        // Main game loop
        for (int turn = 0; turn < 30; turn++)
        {
            DisplayBoard(board);
            // Player 1's turn
            Console.WriteLine("Player 1's turn:");
            player1Score += MovePlayer(board, 'P', '1');

            DisplayBoard(board);




