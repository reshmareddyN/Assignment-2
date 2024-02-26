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
            // Player 2's turn
            Console.WriteLine("Player 2's turn:");
            player2Score += MovePlayer(board, 'P', '2');
        }

        // Display final scores
        Console.WriteLine("Game over!");
        Console.WriteLine($"Player 1's score: {player1Score}");
        Console.WriteLine($"Player 2's score: {player2Score}");
        if (player1Score > player2Score)
            Console.WriteLine("Player 1 wins!");
        else if (player2Score > player1Score)
            Console.WriteLine("Player 2 wins!");
        else
            Console.WriteLine("It's a tie!");
    }
    static void InitializeBoard(char[,] board)
    {
        // Fill the board with gems and obstacles
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            int x = random.Next(6);
            int y = random.Next(6);

            // Place gem
            board[y, x] = 'G';

            // Place obstacle
            x = random.Next(6);
            y = random.Next(6);
            board[y, x] = 'O';
        }
    }

    static void DisplayBoard(char[,] board)
         static void DisplayBoard(char[,] board)
    {
        // Display the current state of the board
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write(board[i, j] == '\0' ? '-' : board[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    static int MovePlayer(char[,] board, char playerSymbol, char playerNumber)
    {
        int score = 0;
        Console.WriteLine("Enter your move (U/D/L/R):");
        char move = char.ToUpper(Console.ReadKey().KeyChar)







