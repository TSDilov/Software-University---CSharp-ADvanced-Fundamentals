using System;
using System.Collections.Generic;

namespace CountCharsinaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> counts = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && !counts.ContainsKey(text[i]))
                {
                    counts.Add(text[i], 1);
                    continue;
                }
                if (text[i] != ' ')
                {
                    counts[text[i]]++;
                }
            }

            foreach (var ch in counts)
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}
