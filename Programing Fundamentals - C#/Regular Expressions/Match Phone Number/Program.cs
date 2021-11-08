using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatchCollection phones = Regex.Matches(input, @"\+[3][5][9](\-| )[2]\1[0-9]{3}\1[0-9]{4}\b");

            Console.Write(string.Join(", ",phones));
        }
    }
}
