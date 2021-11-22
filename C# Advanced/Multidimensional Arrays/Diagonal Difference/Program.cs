using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int sumFirstDiadonal = 0;
            int sumSecondDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sumFirstDiadonal += matrix[row, row];
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sumSecondDiagonal += matrix[row, size - row - 1];
            }
            Console.WriteLine($"{Math.Abs(sumFirstDiadonal - sumSecondDiagonal)}");
        }
    }
}
