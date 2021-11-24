using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] arrays = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                arrays[i] = new double[numbers.Length];
                for (int j = 0; j < numbers.Length; j++)
                {
                    arrays[i][j] = numbers[j];
                }
            }
            for (int i = 0; i < arrays.Length - 1; i++)
            {
                if (arrays[i].Length == arrays[i + 1].Length)
                {
                    for (int j = 0; j < arrays[i].Length; j++)
                    {
                        arrays[i][j] *= 2;
                        arrays[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < arrays[i].Length; j++)
                    {
                        arrays[i][j] /= 2;
                    }
                    for (int j = 0; j < arrays[i + 1].Length; j++)
                    {
                        arrays[i + 1][j] /= 2;
                    }
                }
            }
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        int row = int.Parse(command[1]);
                        int col = int.Parse(command[2]);
                        double value = int.Parse(command[3]);
                        if (row >= 0 && row <= arrays.Length - 1)
                        {
                            if (col >= 0 && col <= arrays[row].Length -1)
                            {
                                arrays[row][col] += value;
                            }
                        }
                        break;
                    case "Subtract":
                        row = int.Parse(command[1]);
                        col = int.Parse(command[2]);
                        value = int.Parse(command[3]);
                        if (row >= 0 && row <= arrays.Length - 1)
                        {
                            if (col >= 0 && col <= arrays[row].Length - 1)
                            {
                                arrays[row][col] -= value;
                            }
                        }
                        break;
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine(string.Join(" ", arrays[i]));
            }
        }
    }
}
