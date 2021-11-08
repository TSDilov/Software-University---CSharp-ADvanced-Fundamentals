using System;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine("Bought furniture:");
            decimal sum = 0;

            while (input != "Purchase")
            {
                Match match = Regex.Match(input,
                    @"^>>(?<furniture>[A-Za-z]+)<<(?<price>[0-9]+\.{0,1}[0-9]{0,})!(?<quantity>[0-9]+)");
                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string furniture = match.Groups["furniture"].Value;
                string price = match.Groups["price"].Value;
                string quantity = match.Groups["quantity"].Value;
                sum += decimal.Parse(price) * int.Parse(quantity);

                Console.WriteLine(furniture);

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {sum:F2}");
        }
    }
}
