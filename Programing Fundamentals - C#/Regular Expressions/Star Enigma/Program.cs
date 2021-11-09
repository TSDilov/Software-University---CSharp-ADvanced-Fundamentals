using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyPattern = "[STARstar]";
            string pattern = @"\@([A-Z][a-z]+)[^\@\-!:>]*:([0-9]+)[^\@\-!:>]*!(A|D)![^\@\-!:>]*->([0-9]+)";
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {               
                StringBuilder message = new StringBuilder();
                string input = Console.ReadLine();
                int count = Regex.Matches(input, keyPattern).Count;
                foreach (var item in input)
                {
                    message.Append((char)(item - count));
                }

                Match match = Regex.Match(message.ToString(), pattern);
                if (!match.Success)
                {
                    continue;
                }

                string name = match.Groups[1].Value;
                int population = int.Parse(match.Groups[2].Value);
                string attackType = match.Groups[3].Value;
                int soldiers = int.Parse(match.Groups[4].Value);

              
                if (attackType == "A")
                {
                    attackedPlanets.Add(name);
                }
                else if (attackType == "D")
                {
                    destroyedPlanets.Add(name);
                }
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
