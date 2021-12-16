using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>(Array.ConvertAll(Console.ReadLine().Split(), char.Parse));
            Stack<char> consontants = new Stack<char>(Array.ConvertAll(Console.ReadLine().Split(), char.Parse));
            int wordsCount = 0;
            List<string> words = new List<string>() { "pear", "flour", "pork", "olive" };
            List<string> secondListOf = new List<string>() { "pear", "flour", "pork", "olive" };
            while (consontants.Count > 0)
            {
                char currentVowel = vowels.Peek();
                char currentConsontant = consontants.Peek();
                for (int i = 0; i < 4; i++)
                {
                    if (consontants.Count <= 0)
                    {
                        break;
                    }

                    if (words[i].Contains(currentVowel))
                    {
                        words[i] = words[i].Replace(currentVowel, ' ');
                    }

                    if (words[i].Contains(currentConsontant))
                    {
                        words[i] = words[i].Replace(currentConsontant, ' ');
                    }


                }
                vowels.Dequeue();
                vowels.Enqueue(currentVowel);
                consontants.Pop();
            }
            foreach (var word in words)
            {
                if (word.ToString().Trim() == "")
                {
                    wordsCount++;
                }
            }

            Console.WriteLine($"Words found: {wordsCount}");
            for (int i = 0; i < 4; i++)
            {
                if (words[i].Trim() == "")
                {
                    Console.WriteLine(secondListOf[i]);
                }
            }

        }
    }
}
