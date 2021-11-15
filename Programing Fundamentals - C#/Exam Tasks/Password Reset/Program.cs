using System;
using System.Text;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] commands = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "TakeOdd":
                        StringBuilder oddIndexes = new StringBuilder();
                        for (int i = 1; i < input.Length; i+=2)
                        {
                            oddIndexes.Append(input[i]);
                        }
                        input = oddIndexes.ToString();
                        Console.WriteLine(input);
                        break;
                    case "Cut":
                        int index = int.Parse(commands[1]);
                        int length = int.Parse(commands[2]);
                        input = input.Remove(index, length);
                        Console.WriteLine(input);
                        break;
                    case "Substitute":
                        string substring = commands[1];
                        string substitute = commands[2];
                        if (!input.Contains(substring))
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        else
                        {
                            input = input.Replace(substring, substitute);
                            Console.WriteLine(input);
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {input}");
        }
    }
}
