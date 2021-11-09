using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racers = new Dictionary<string, int>();
            
            string letterPattern = "[A-Za-z]";
            string digitPattern = "[0-9]";

            string[] racersName = Console.ReadLine().Split(", ");

            foreach (var racer in racersName)
            {
                racers.Add(racer, 0);
            }
            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string currentName = string.Empty;
                int currentSum = 0;
                MatchCollection letters = Regex.Matches(input, letterPattern);

                foreach (Match letter in letters)
                {
                    currentName += letter.Value;
                }
                if (!racers.ContainsKey(currentName))
                {
                    input = Console.ReadLine();
                    continue;
                }
                MatchCollection digits = Regex.Matches(input, digitPattern);

                foreach (Match digit in digits)
                {
                    currentSum += int.Parse(digit.Value);
                }

                racers[currentName] += currentSum;
                input = Console.ReadLine();
            }
            racers = racers.OrderByDescending(r => r.Value).ToDictionary(k => k.Key, v => v.Value);
            Console.WriteLine($"1st place: {racers.ElementAt(0).Key}");
            Console.WriteLine($"2nd place: {racers.ElementAt(1).Key}");
            Console.WriteLine($"3rd place: {racers.ElementAt(2).Key}");
        }
    }
}
