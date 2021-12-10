using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodInteger
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> integers = new List<Box<int>>();
            for (int i = 0; i < n; i++)
            {
                Box<int> input = new Box<int>(int.Parse(Console.ReadLine()));
                integers.Add(input);
            }
            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Swap(integers, indexes[0], indexes[1]);
            Console.WriteLine(string.Join(Environment.NewLine, integers));
        }
        static void Swap<T>(List<Box<T>> integers, int index1, int index2)
        {
            Box<T> temp = integers[index1];
            integers[index1] = integers[index2];
            integers[index2] = temp;
        }
    }
}
