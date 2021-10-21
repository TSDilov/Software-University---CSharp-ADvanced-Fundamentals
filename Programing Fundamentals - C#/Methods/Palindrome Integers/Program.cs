using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool isPalidrome = MethodForPalidrome(input);
                Console.WriteLine(isPalidrome);
                input = Console.ReadLine(); 
            }
        }

        static bool MethodForPalidrome(string input)
        {
            string reverseInput = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverseInput += input[i];
            }
            bool isPalidrome = true;
            if (input == reverseInput)
            {
                isPalidrome = true;
            }
            else
            {
                isPalidrome = false;
            }
            return isPalidrome;
        }
    }
}
