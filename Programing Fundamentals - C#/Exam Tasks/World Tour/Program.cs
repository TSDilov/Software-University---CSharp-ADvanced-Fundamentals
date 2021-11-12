using System;

namespace WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] commands = command.Split(":");
                switch (commands[0])
                {
                    case "Add Stop":
                        int index = int.Parse(commands[1]);
                        string text = commands[2];
                        if (index >= 0 && index <= input.Length - 1)
                        {
                            input = input.Insert(index, text);
                        }
                            Console.WriteLine(input);                       
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);
                        if (startIndex >= 0 && startIndex <= input.Length - 1 && endIndex >= 0 && endIndex <= input.Length - 1)
                        {
                            input = input.Remove(startIndex, endIndex - startIndex + 1);
                        }
                        Console.WriteLine(input);
                        break;
                    case "Switch":
                        string oldText = commands[1];
                        string newText = commands[2];
                        if (input.Contains(oldText) && oldText != newText)
                        {
                            input = input.Replace(oldText, newText);
                        }
                        Console.WriteLine(input);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
