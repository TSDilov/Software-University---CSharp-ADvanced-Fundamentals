using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatchCollection names = Regex.Matches(input, @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            foreach (Match name in names)
            {
                Console.Write(name.Value + " ");
            }
        }
    }
}
