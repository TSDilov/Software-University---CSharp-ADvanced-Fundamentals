using System;

namespace GreaterofTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int firstInt = int.Parse(Console.ReadLine());
                int secondInt = int.Parse(Console.ReadLine());
                Console.WriteLine(MethodGetMax(firstInt, secondInt));
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                Console.WriteLine((char)MethodGetMax(firstChar, secondChar));
            }
            else if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                Console.WriteLine(MethodGetMax(firstString, secondString));
            }
        }

        static string MethodGetMax(string firstString, string secondString)
        {
            int result = firstString.CompareTo(secondString);

            int firstStringSum = MethodGetSumFromString(firstString);
            int secondStringSum = MethodGetSumFromString(secondString);

            if (result > 0 )
            {
                return firstString;
            }
            return secondString;

        }

        private static int MethodGetSumFromString(string valueString)
        {
            int stringSum = 0;
            for (int i = 0; i < valueString.Length; i++)
            {
                stringSum += valueString[i];
            }

            return stringSum;
        }

        static int MethodGetMax(int firstInt, int secondInt)
        {
            if (firstInt > secondInt)
            {
                return firstInt;
            }
            return secondInt;
        }
    }
}
