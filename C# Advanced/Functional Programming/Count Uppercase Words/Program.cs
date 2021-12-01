using System;
using System.Collections.Generic;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            text = text.Where(w => char.IsUpper(w[0])).ToList();
            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
