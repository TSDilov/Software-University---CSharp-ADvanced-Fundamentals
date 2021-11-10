using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Queue<string> names = new Queue<string>();
            while (name != "End")
            {
                if (name == "Paid")
                {
                    foreach (var addName in names)
                    {
                        Console.WriteLine(addName);
                    }
                    names.Clear();
                    name = Console.ReadLine();
                    continue;
                }
                names.Enqueue(name);
                name = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
