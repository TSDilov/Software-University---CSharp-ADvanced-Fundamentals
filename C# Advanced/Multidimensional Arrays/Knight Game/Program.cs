using System;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] knightsOnBoard = new char[n, n];

            for (int row = 0; row < knightsOnBoard.GetLength(0); row++)
            {
                string lineForAddingOnBoard = Console.ReadLine();
                for (int col = 0; col < knightsOnBoard.GetLength(1); col++)
                {
                    knightsOnBoard[row, col] = lineForAddingOnBoard[col];
                }
            }
            int removedKnights = 0;
            while (true)
            {
                int maxAttacks = 0;
                int knightRow = 0;
                int knightCol = 0;
                for (int row = 0; row < knightsOnBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < knightsOnBoard.GetLength(0); col++)
                    {
                        int currentAtack = 0;
                        if (knightsOnBoard[row, col] != 'K')
                        {
                            continue;
                        }
                        if (IsInside(knightsOnBoard, row - 2, col + 1) && knightsOnBoard[row - 2, col + 1] == 'K')
                        {
                            currentAtack++;
                        }
                        if (IsInside(knightsOnBoard, row - 1, col + 2) && knightsOnBoard[row - 1, col + 2] == 'K')
                        {
                            currentAtack++;
                        }
                        if (IsInside(knightsOnBoard, row + 1, col + 2) && knightsOnBoard[row + 1, col + 2] == 'K')
                        {
                            currentAtack++;
                        }
                        if (IsInside(knightsOnBoard, row + 2, col + 1) && knightsOnBoard[row + 2, col + 1] == 'K')
                        {
                            currentAtack++;
                        }
                        if (IsInside(knightsOnBoard, row + 2, col - 1) && knightsOnBoard[row + 2, col - 1] == 'K')
                        {
                            currentAtack++;
                        }
                        if (IsInside(knightsOnBoard, row + 1, col - 2) && knightsOnBoard[row + 1, col - 2] == 'K')
                        {
                            currentAtack++;
                        }
                        if (IsInside(knightsOnBoard, row - 1, col - 2) && knightsOnBoard[row - 1, col - 2] == 'K')
                        {
                            currentAtack++;
                        }
                        if (IsInside(knightsOnBoard, row - 2, col - 1) && knightsOnBoard[row - 2, col - 1] == 'K')
                        {
                            currentAtack++;
                        }
                        if (currentAtack > maxAttacks)
                        {
                            maxAttacks = currentAtack;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }

                if (maxAttacks == 0)
                {
                    Console.WriteLine(removedKnights);
                    break;
                }
                else
                {
                    knightsOnBoard[knightRow, knightCol] = '0';
                    removedKnights++;
                }
            }   
        }
        private static bool IsInside(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) &&
                col >= 0 && col < board.GetLength(1);
        }
    }
}
