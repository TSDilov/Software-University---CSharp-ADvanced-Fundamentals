using System;

namespace PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[8, 8];
            var whiteRow = 0;
            var whiteCol = 0;
            var blackRow = 0;
            var blackCol = 0;
            
            for (int row = 0; row < board.GetLength(0); row++)
            {
                var rows = Console.ReadLine();
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = rows[col];
                    if (rows[col] == 'w')
                    {
                        whiteRow = row;
                        whiteCol = col;
                    }
                    if (rows[col] == 'b')
                    {
                        blackRow = row;
                        blackCol = col;
                    }
                }
            }

            while (true)
            {
                if (blackRow == whiteRow - 1 && (blackCol == whiteCol + 1 || blackCol == whiteCol - 1))
                {
                    if (blackRow == 6)
                    {
                        Console.WriteLine($"Game over! White capture on {(char)(blackCol + 97)}2.");
                        break;
                    }
                    if (blackRow == 5)
                    {
                        Console.WriteLine($"Game over! White capture on {(char)(blackCol + 97)}3.");
                        break;
                    }
                    if (blackRow == 4)
                    {
                        Console.WriteLine($"Game over! White capture on {(char)(blackCol + 97)}4.");
                        break;
                    }
                    if (blackRow == 3)
                    {
                        Console.WriteLine($"Game over! White capture on {(char)(blackCol + 97)}{blackRow}5.");
                        break;
                    }
                    if (blackRow == 2)
                    {
                        Console.WriteLine($"Game over! White capture on {(char)(blackCol + 97)}6.");
                        break;
                    }
                    if (blackRow == 1)
                    {
                        Console.WriteLine($"Game over! White capture on {(char)(blackCol + 97)}7.");
                        break;
                    }
                    if (blackRow == 0)
                    {
                        Console.WriteLine($"Game over! White capture on {(char)(blackCol + 97)}8.");
                        break;
                    }
                }
                whiteRow -= 1;
                if (whiteRow == 0)
                {
                    Console.WriteLine($"Game over! White pawn is promoted to a queen at {(char)(whiteCol + 97)}8.");
                    break;
                }

                if (whiteRow == blackRow + 1 && (whiteCol == blackCol - 1 || whiteCol == blackCol + 1))
                {
                    if (whiteRow == 1)
                    {
                        Console.WriteLine($"Game over! Black capture on {(char)(whiteCol + 97)}7.");
                        break;
                    }
                    if (whiteRow == 2)
                    {
                        Console.WriteLine($"Game over! Black capture on {(char)(whiteCol + 97)}6.");
                        break;
                    }
                    if (whiteRow == 3)
                    {
                        Console.WriteLine($"Game over! Black capture on {(char)(whiteCol + 97)}5.");
                        break;
                    }
                    if (whiteRow == 4)
                    {
                        Console.WriteLine($"Game over! Black capture on {(char)(whiteCol + 97)}4.");
                        break;
                    }
                    if (whiteRow == 5)
                    {
                        Console.WriteLine($"Game over! Black capture on {(char)(whiteCol + 97)}3.");
                        break;
                    }
                    if (whiteRow == 6)
                    {
                        Console.WriteLine($"Game over! Black capture on {(char)(whiteCol + 97)}2.");
                        break;
                    }
                    if (whiteRow == 7)
                    {
                        Console.WriteLine($"Game over! Black capture on {(char)(whiteCol + 97)}1.");
                        break;
                    }
                }
                blackRow += 1;
                if (blackRow == board.GetLength(0))
                {
                    Console.WriteLine($"Game over! Black pawn is promoted to a queen at {(char)(blackCol + 97)}1.");
                    break;
                }
                
            }
        }
    }
}
