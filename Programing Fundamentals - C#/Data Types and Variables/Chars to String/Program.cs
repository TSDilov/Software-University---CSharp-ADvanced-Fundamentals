using System;

namespace CharstoString
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            string firstString = first.ToString();
            string secondString = second.ToString();
            string thirdString = third.ToString();

            Console.WriteLine($"{firstString}{secondString}{thirdString}");

        }
    }
}
