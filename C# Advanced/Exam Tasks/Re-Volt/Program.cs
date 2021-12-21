using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int numberOfCommands = int.Parse(Console.ReadLine());
            char[,] field = new char[size, size];
            int playerRow = 0;
            int playerCol = 0;
            for (int row = 0; row < field.GetLength(0); row++)
            {
                var rows = Console.ReadLine();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = rows[col];
                    if (rows[col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
            while (numberOfCommands > 0)
            {
                var command = Console.ReadLine();
                if (command == "up")
                {
                    if (playerRow == 0)
                    {
                        field[playerRow, playerCol] = '-';
                        playerRow = field.GetLength(0) - 1;
                        if (field[playerRow, playerCol] == 'B')
                        {
                            playerRow = playerRow - 1;
                        }
                        if (field[playerRow, playerCol] == 'T')
                        {
                            playerRow = 0;
                            field[playerRow, playerCol] = 'f';
                        }
                        if (field[playerRow, playerCol] != 'F' && numberOfCommands == 1)
                        {
                            field[playerRow, playerCol] = 'f';
                        }
                    }
                    else
                    {
                        field[playerRow, playerCol] = '-';
                        playerRow = playerRow - 1;
                        if (field[playerRow, playerCol] == 'B')
                        {
                            if (playerRow == 0)
                            {
                                playerRow = field.GetLength(0) - 1;                                
                            }
                            else
                            {
                                playerRow = playerRow - 1;
                            }
                        }
                        if (field[playerRow, playerCol] == 'T')
                        {
                            playerRow = playerRow + 1;
                            field[playerRow, playerCol] = 'f';
                        }
                        if (field[playerRow, playerCol] != 'F' && numberOfCommands == 1)
                        {
                            field[playerRow, playerCol] = 'f';
                        }
                    }
                }
                else if (command == "down")
                {
                    if (playerRow == field.GetLength(0) - 1)
                    {
                        field[playerRow, playerCol] = '-';
                        playerRow = 0;
                        if (field[playerRow, playerCol] == 'B')
                        {
                            playerRow = playerRow + 1;
                        }
                        if (field[playerRow, playerCol] == 'T')
                        {
                            playerRow = field.GetLength(0) - 1;
                            field[playerRow, playerCol] = 'f';
                        }
                        if (field[playerRow, playerCol] != 'F' && numberOfCommands == 1)
                        {
                            field[playerRow, playerCol] = 'f';
                        }
                    }
                    else
                    {
                        field[playerRow, playerCol] = '-';
                        playerRow = playerRow + 1;
                        if (field[playerRow, playerCol] == 'B')
                        {
                            if (playerRow == field.GetLength(0) - 1)
                            {
                                playerRow = 0;
                            }
                            else
                            {
                                playerRow = playerRow + 1;
                            }
                        }
                        if (field[playerRow, playerCol] == 'T')
                        {
                            playerRow = playerRow - 1;
                            field[playerRow, playerCol] = 'f';
                        }
                        if (field[playerRow, playerCol] != 'F' && numberOfCommands == 1)
                        {
                            field[playerRow, playerCol] = 'f';
                        }
                    }
                }
                else if (command == "left")
                {
                    if (playerCol == 0)
                    {
                        field[playerRow, playerCol] = '-';
                        playerCol = field.GetLength(1) - 1;
                        if (field[playerRow, playerCol] == 'B')
                        {
                            playerCol = playerCol - 1;
                        }
                        if (field[playerRow, playerCol] == 'T')
                        {
                            playerCol = 0;
                            field[playerRow, playerCol] = 'f';
                        }
                        if (field[playerRow, playerCol] != 'F' && numberOfCommands == 1)
                        {
                            field[playerRow, playerCol] = 'f';
                        }
                    }
                    else
                    {
                        field[playerRow, playerCol] = '-';
                        playerCol = playerCol - 1;
                        if (field[playerRow, playerCol] == 'B')
                        {
                            if (playerCol == 0)
                            {
                                playerCol = field.GetLength(1) - 1;
                            }
                            else
                            {
                                playerCol = playerCol - 1;
                            }
                        }
                        if (field[playerRow, playerCol] == 'T')
                        {
                            playerCol = playerCol + 1;
                            field[playerRow, playerCol] = 'f';
                        }
                        if (field[playerRow, playerCol] != 'F' && numberOfCommands == 1)
                        {
                            field[playerRow, playerCol] = 'f';
                        }
                    }
                }
                else if (command == "right")
                {
                    if (playerCol == field.GetLength(1) - 1)
                    {
                        field[playerRow, playerCol] = '-';
                        playerCol = 0;
                        if (field[playerRow, playerCol] == 'B')
                        {
                            playerCol = playerCol + 1;
                        }
                        if (field[playerRow, playerCol] == 'T')
                        {
                            playerRow = field.GetLength(1) - 1;
                            field[playerRow, playerCol] = 'f';
                        }
                        if (field[playerRow, playerCol] != 'F' && numberOfCommands == 1)
                        {
                            field[playerRow, playerCol] = 'f';
                        }
                    }
                    else
                    {
                        field[playerRow, playerCol] = '-';
                        playerCol = playerCol + 1;
                        if (field[playerRow, playerCol] == 'B')
                        {
                            if (playerCol == field.GetLength(1) - 1)
                            {
                                playerCol = 0;
                            }
                            else
                            {
                                playerCol = playerCol + 1;
                            }
                        }
                        if (field[playerRow, playerCol] == 'T')
                        {
                            playerCol = playerCol - 1;
                            field[playerRow, playerCol] = 'f';
                        }
                        if (field[playerRow, playerCol] != 'F' && numberOfCommands == 1)
                        {
                            field[playerRow, playerCol] = 'f';
                        }
                    }
                }
                if (field[playerRow, playerCol] == 'F')
                {
                    field[playerRow, playerCol] = 'f';
                    Console.WriteLine("Player won!");
                    for (int row = 0; row < field.GetLength(0); row++)
                    {
                        for (int col = 0; col < field.GetLength(1); col++)
                        {
                            Console.Write(field[row, col]);
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                numberOfCommands--;
            }
            if (numberOfCommands == 0)
            {
                Console.WriteLine("Player lost!");
                for (int row = 0; row < field.GetLength(0); row++)
                {
                    for (int col = 0; col < field.GetLength(1); col++)
                    {
                        Console.Write(field[row, col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
