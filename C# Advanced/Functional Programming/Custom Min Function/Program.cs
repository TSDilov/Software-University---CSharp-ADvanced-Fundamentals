using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int[], int> smallest = i =>
            {
                int smallest = int.MaxValue;
                for (int j = 0; j < i.Length; j++)
                {
                    if (i[j] < smallest)
                    {
                        smallest = i[j];
                    }
                }
                return smallest;
            };
            Console.WriteLine(smallest(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray()));
        }
        
    }
}
