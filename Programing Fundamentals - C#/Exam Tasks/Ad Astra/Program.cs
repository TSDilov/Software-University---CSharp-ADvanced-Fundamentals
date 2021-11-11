using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([|#])([A-Za-z\s]+)\1([0-9]{2}\/[0-9]{2}\/[0-9]{2})\1([0-9]{1,5})\1";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            List<int> foodCal = new List<int>();
            string item = string.Empty;
            string bestBefore = string.Empty;
            string nutrition = string.Empty;
            foreach (Match foodMatch in matches)
            {              
                nutrition = foodMatch.Groups[4].Value;
                foodCal.Add(int.Parse(nutrition));
            }
            int allCal = 0;
            for (int i = 0; i < foodCal.Count; i++)
            {
                allCal += foodCal[i];
            }
            int days = allCal / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match foodMatch in matches)
            {
                item = foodMatch.Groups[2].Value;
                bestBefore = foodMatch.Groups[3].Value;
                nutrition = foodMatch.Groups[4].Value;
                Console.WriteLine($"Item: {item}, Best before: {bestBefore}, Nutrition: {nutrition}");
            }
        }
    }
}
