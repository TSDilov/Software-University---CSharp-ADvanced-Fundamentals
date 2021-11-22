using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] numbers = new int[size[0], size[1]];
            for (int row = 0; row < size[0]; row++)
            {
                int[] numbersForAdd = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < size[1]; col++)
                {
                    numbers[row, col] = numbersForAdd[col];
                }
            }
            long maxSum = long.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;
            for (int row = 0; row < numbers.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < numbers.GetLength(1) - 1; col++)
                {
                    int sum = numbers[row, col] + numbers[row, col + 1] +
                        numbers[row + 1, col] + numbers[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            for (int row = maxSumRow; row < maxSumRow + 2; row++)
            {
                for (int col = maxSumCol; col < maxSumCol + 2; col++)
                {
                    Console.Write(numbers[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
