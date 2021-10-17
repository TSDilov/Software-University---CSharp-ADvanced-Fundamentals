using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintingTriangle(n);
        }

        static void PrintingTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                Row(row);
            }
            for (int row = n - 1; row >= 1; row--)
            {
                Row(row);
            }
        }

        private static void Row(int row)
        {
            for (int j = 1; j <= row; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
