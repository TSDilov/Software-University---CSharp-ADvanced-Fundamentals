using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> characters = new SortedDictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (!characters.ContainsKey(text[i]))
                {
                    characters.Add(text[i],0);
                }
                characters[text[i]]++;
            }
            foreach (var @char in characters)
            {
                Console.WriteLine($"{@char.Key}: {@char.Value} time/s");
            }
        }
    }
}
