using System;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([:*])\1([A-Z][a-z]{2,})\1{2}";
            MatchCollection matchOfDigits = Regex.Matches(input, "[0-9]");
            int coolThreshold = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    coolThreshold *= input[i] - 48;
                }
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            MatchCollection emojis = Regex.Matches(input, pattern);
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
            foreach (Match emoji in emojis)
            {
                int coolness = 0;
                string currentEmoji = emoji.Groups[2].Value;
                for (int i = 0; i < currentEmoji.Length; i++)
                {
                    coolness += currentEmoji[i];
                }
                if (coolness >= coolThreshold)
                {
                    Console.WriteLine(emoji);
                }
            }
        }
    }
}
