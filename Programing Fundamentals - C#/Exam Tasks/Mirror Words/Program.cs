using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(@|#)([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1";
            List<string> mirrorWords = new List<string>();
            MatchCollection matches = Regex.Matches(input,pattern);
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            foreach (Match match in matches)
            {
                string firstWord = match.Groups[2].Value;
                string secondWord = match.Groups[3].Value;
                secondWord = string.Join("", secondWord.ToCharArray().Reverse());
                if (firstWord == secondWord)
                {
                    firstWord += " <=> " + string.Join("", secondWord.ToCharArray().Reverse());
                    mirrorWords.Add(firstWord);
                }               
            }
            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ",mirrorWords));
            }
        }
    }
}
