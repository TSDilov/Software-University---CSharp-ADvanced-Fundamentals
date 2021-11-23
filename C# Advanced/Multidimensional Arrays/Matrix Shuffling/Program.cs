using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[size[0], size[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "swap":
                        if (command.Length != 5)
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        int rowIndex = int.Parse(command[1]);
                        int colIndex = int.Parse(command[2]);
                        int rowIndex2 = int.Parse(command[3]);
                        int colIndex2 = int.Parse(command[4]);
                        if (IndexValidation(rowIndex, size[0]) && IndexValidation(colIndex, size[1]) && 
                            IndexValidation(rowIndex2, size[0]) && IndexValidation(colIndex2, size[1]))
                        {
                            string temp = matrix[rowIndex, colIndex];
                            matrix[rowIndex, colIndex] = matrix[rowIndex2, colIndex2];
                            matrix[rowIndex2, colIndex2] = temp;
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    Console.Write(matrix[row, col] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
        private static bool IndexValidation(int index, int matrixSize) 
        {
            if (index >= 0 && index < matrixSize)
            {
                return true;
            }

            return false;
        }
    }
}
