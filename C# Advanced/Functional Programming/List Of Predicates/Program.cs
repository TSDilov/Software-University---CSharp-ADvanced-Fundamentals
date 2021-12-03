using System;
using System.Collections.Generic;
using System.Linq;

namespace ListofPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] deviders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }
            int[] devisible = Array.FindAll(array, n =>
            {
                bool isDividable = false;
                for (int i = 0; i < deviders.Length; i++)
                {
                    if (n % deviders[i] == 0)
                    {
                        isDividable = true;
                    }
                    if (isDividable && n % deviders[i] != 0)
                    {
                        isDividable = false;
                        break;
                    }
                }
                return isDividable;
            });
            Console.WriteLine(string.Join(" ", devisible));
        }
    }
}
