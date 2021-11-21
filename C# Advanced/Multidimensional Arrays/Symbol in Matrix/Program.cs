using System;

namespace SymbolinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                string characters = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = characters[col];
                }
            }
            char lookingSymbol = char.Parse(Console.ReadLine());
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row,col] == lookingSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return; 
                    }
                }
            }
            Console.WriteLine($"{lookingSymbol} does not occur in the matrix");
        }
    }
}
