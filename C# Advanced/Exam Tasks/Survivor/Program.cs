using System;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            string[][] beach = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                var chars = Console.ReadLine().Split();
                beach[row] = chars;
            }

            var collectTokens = 0;
            var opponentTokens = 0;
            var command = Console.ReadLine();

            while (command != "Gong")
            {
                var currentCommand = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                if (currentCommand[0] == "Find")
                {
                    var myRow = int.Parse(currentCommand[1]);
                    var myCol = int.Parse(currentCommand[2]);
                    if (myRow < rows && myCol < beach[myRow].Length)
                    {
                        if (beach[myRow][myCol] == "T")
                        {
                            collectTokens++;
                            beach[myRow][myCol] = "-";
                        }
                    }
                }
                else if (currentCommand[0] == "Opponent")
                {
                    var opponentRow = int.Parse(currentCommand[1]);
                    var opponentCol = int.Parse(currentCommand[2]);
                    var direction = currentCommand[3];
                    if (opponentRow < rows && opponentCol < beach[opponentRow].Length)
                    {
                        if (beach[opponentRow][opponentCol] == "T")
                        {
                            opponentTokens++;
                            beach[opponentRow][opponentCol] = "-";
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            if (direction == "up")
                            {
                                if (opponentRow - 1 >= 0)
                                {
                                    opponentRow = opponentRow - 1;
                                    if (beach[opponentRow][opponentCol] == "T")
                                    {
                                        opponentTokens++;
                                        beach[opponentRow][opponentCol] = "-";
                                    }
                                }
                            }
                            else if (direction == "down")
                            {
                                if (opponentRow + 1 < rows)
                                {
                                    opponentRow = opponentRow + 1;
                                    if (beach[opponentRow][opponentCol] == "T")
                                    {
                                        opponentTokens++;
                                        beach[opponentRow][opponentCol] = "-";
                                    }
                                }
                            }
                            else if (direction == "left")
                            {
                                if (opponentCol - 1 >= 0)
                                {
                                    opponentCol = opponentCol - 1;
                                    if (beach[opponentRow][opponentCol] == "T")
                                    {
                                        opponentTokens++;
                                        beach[opponentRow][opponentCol] = "-";
                                    }
                                }
                            }
                            else if (direction == "right")
                            {
                                if (opponentCol + 1 < beach[opponentRow].Length)
                                {
                                    opponentCol = opponentCol + 1;
                                    if (beach[opponentRow][opponentCol] == "T")
                                    {
                                        opponentTokens++;
                                        beach[opponentRow][opponentCol] = "-";
                                    }
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", beach[i]));
            }
            Console.WriteLine($"Collected tokens: {collectTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");
        }
    }
}
