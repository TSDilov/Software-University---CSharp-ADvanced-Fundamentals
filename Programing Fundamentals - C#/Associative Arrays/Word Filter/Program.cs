using System;
using System.Collections.Generic;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            List<string> evenWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 == 0)
                {
                    evenWords.Add(words[i]);
                }
            }
            foreach (var word in evenWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
