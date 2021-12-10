using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }
            string itemTocompare = Console.ReadLine();
            Console.WriteLine(box.FilterCount(itemTocompare));
        }
        
    }
}
