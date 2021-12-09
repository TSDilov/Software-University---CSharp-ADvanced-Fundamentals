using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> list = new List<Box<string>>();
            for (int i = 0; i < n; i++)
            {
                var input = new Box<string>(Console.ReadLine());
                list.Add(input);
            }
            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Swap(list, indexes[0], indexes[1]);
            Console.WriteLine(string.Join(Environment.NewLine, list));
        }
        static void Swap<T>(List<Box<T>> list, int index1, int index2)
        {
            Box<T> temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
