using System;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = size[0];
            var cols = size[1];
            var garden = new int[rows, cols];
            for (int i = 0; i < garden.GetLength(0); i++)
            {
                for (int j = 0; j < garden.GetLength(1); j++)
                {
                    garden[i, j] = 0;
                }
            }

            var command = Console.ReadLine();
            while (command != "Bloom Bloom Plow")
            {
                var commandWithCordinates = command.Split();
                var rowFromCommand = int.Parse(commandWithCordinates[0]);
                var colFromCommand = int.Parse(commandWithCordinates[1]);
                if (rowFromCommand < 0 || rowFromCommand >= garden.GetLength(0) || colFromCommand < 0 || colFromCommand >= garden.GetLength(1))
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                else
                {
                    for (int row = 0; row < garden.GetLength(0); row++)
                    {
                        garden[row, colFromCommand] += 1;
                    }

                    for (int col = 0; col < garden.GetLength(1); col++)
                    {
                        garden[rowFromCommand, col] += 1;
                    }

                    garden[rowFromCommand, colFromCommand] -= 1;
                }                
                command = Console.ReadLine();
            }

            for (int i = 0; i < garden.GetLength(0); i++)
            {
                for (int j = 0; j < garden.GetLength(1); j++)
                {
                    Console.Write($"{garden[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
