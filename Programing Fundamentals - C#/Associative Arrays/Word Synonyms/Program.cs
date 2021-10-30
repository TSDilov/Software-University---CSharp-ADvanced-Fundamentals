using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsWithSynonyms = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!wordsWithSynonyms.ContainsKey(word))
                {
                    wordsWithSynonyms.Add(word, new List<string>());
                }

                wordsWithSynonyms[word].Add(synonym);
            }
            foreach (var word in wordsWithSynonyms)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
            }
        }
    }
}
