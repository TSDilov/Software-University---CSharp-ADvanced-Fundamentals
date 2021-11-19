using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityForDay = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int biggestOrder = orders.Max();
            int count = orders.Count;
            for (int i = 0; i < count; i++)
            {               
                if (quantityForDay >= orders.Peek())
                {
                    quantityForDay -= orders.Dequeue();
                    continue;
                }
                break;
            }
            Console.WriteLine(biggestOrder);
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
            }
        }
    }
}
