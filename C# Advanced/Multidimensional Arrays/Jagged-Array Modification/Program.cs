using System;
using System.Linq;

namespace Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arrays = new int[n][];
            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                arrays[i] = new int[numbers.Length];
                for (int j = 0; j < numbers.Length; j++)
                {
                    arrays[i][j] = numbers[j];
                }
            }
            while (true)
            {
                var command = Console.ReadLine().Split();
                if (command[0] == "END")
                {
                    break;
                }
                var row = int.Parse(command[1]);
                var col = int.Parse(command[2]);
                var value = int.Parse(command[3]);
                if (row < 0 || row >= arrays.Length || col < 0 || col >= arrays[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (command[0] == "Add")
                {
                    arrays[row][col] += value;
                }
                else if (command[0] == "Subtract")
                {
                    arrays[row][col] -= value;
                }
            }
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine(string.Join(" ", arrays[i]));
            }
        }
    }
}
