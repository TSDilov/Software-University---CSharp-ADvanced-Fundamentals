using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countOpenBrackets = 0;
            int countCloseBrackets = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    countOpenBrackets++;
                }
                else if (input == ")")
                {
                    countCloseBrackets++;
                    if (countOpenBrackets - countCloseBrackets !=0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }
            Console.WriteLine(countOpenBrackets == countCloseBrackets ? "BALANCED" : "UNBALANCED");
        }
    }
}
