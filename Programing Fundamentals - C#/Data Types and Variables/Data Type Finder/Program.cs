using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool notType = true;
            while (notType)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    notType = false;
                    break;
                }
                bool isInt = int.TryParse(input, out int integer);
                bool isFloat = float.TryParse(input, out float floating);
                bool isChar = char.TryParse(input, out char character);
                bool isBool = bool.TryParse(input, out bool boolean);
                string type = string.Empty;

                if (isInt)
                {
                    type = "integer";
                }
                else if (isFloat)
                {
                    type = "floating point";
                }
                else if (isChar)
                {
                    type = "character";
                }
                else if (isBool)
                {
                    type = "boolean";
                }
                else
                {
                    type = "string";
                }
                Console.WriteLine($"{input} is {type} type");
            }
        }
    }
}
