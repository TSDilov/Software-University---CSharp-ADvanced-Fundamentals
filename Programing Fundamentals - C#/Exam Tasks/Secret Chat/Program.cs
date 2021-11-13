using System;
using System.Linq;
using System.Text;

namespace SecretChat_
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            string[] command = Console.ReadLine().Split(":|:", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Reveal")
            {
                switch (command[0])
                {
                    case "InsertSpace":
                        input.Insert(int.Parse(command[1]), " ");
                        Console.WriteLine(input);
                        break;
                    case "Reverse":
                        string substring = command[1];
                        int index = input.ToString().IndexOf(substring);
                        if (!input.ToString().Contains(substring))
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            input.Remove(index, substring.Length);
                            substring = string.Join("", substring.ToCharArray().Reverse());
                            input.Append(substring);
                            Console.WriteLine(input);
                        }
                        break;
                    case "ChangeAll":
                        substring = command[1];
                        string replacement = command[2];
                        while (input.ToString().Contains(substring))
                        {
                            input = input.Replace(substring,replacement);
                        }
                        Console.WriteLine(input);
                        break;
                }

                command = Console.ReadLine().Split(":|:", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
