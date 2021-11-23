using System;
using System.Linq;

namespace SquaresinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string[,] chars = new string[size[0], size[1]];
            int countOfEqualSubMatrixes = 0;
            for (int row = 0; row < size[0]; row++)
            {
                string[] charsForAdd = Console.ReadLine().Split();
                for (int col = 0; col < size[1]; col++)
                {
                    chars[row, col] = charsForAdd[col];
                }
            }
            for (int row = 0; row < chars.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < chars.GetLength(1) - 1; col++)
                {
                    if (chars[row, col] == chars[row, col + 1] && chars[row, col] == chars[row + 1, col] &&
                        chars[row, col] == chars[row + 1, col + 1])
                    {
                        countOfEqualSubMatrixes++;
                    }
                }
            }
            Console.WriteLine(countOfEqualSubMatrixes);
        }
    }
}
