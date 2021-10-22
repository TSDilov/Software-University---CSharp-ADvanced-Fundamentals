using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string final = string.Empty;

            switch (input)
            {
                case "int":
                    int intInput = int.Parse(Console.ReadLine());
                    final = InputOperation(intInput);
                    break;
                case "real":
                    double doubleIput = double.Parse(Console.ReadLine());
                    final = $"{InputOperation(doubleIput):F2}";
                    break;
                case "string":
                    string stringInput = Console.ReadLine();
                    final = InputOperation(stringInput);
                    break;
            }

            Console.WriteLine(final);
        }
        static string InputOperation(int input) 
        {
            return (input * 2).ToString();
        }
        static double InputOperation(double input) 
        {
            return input * 1.5;
        }
        static string InputOperation(string input) 
        {
            return $"${input}$";
        }
    }
}
