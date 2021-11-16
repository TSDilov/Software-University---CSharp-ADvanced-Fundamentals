using System;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] currentCommand = command.Split(">>>",StringSplitOptions.RemoveEmptyEntries);
                switch (currentCommand[0])
                {
                    case "Contains":
                        string substring =currentCommand[1];
                        if (activationKey.Contains(substring))
                        {
                            Console.WriteLine($"{activationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        string flip = currentCommand[1];
                        int startIndex = int.Parse(currentCommand[2]);
                        int endIndex = int.Parse(currentCommand[3]);
                        substring = activationKey.Substring(startIndex, endIndex - startIndex);
                        string newSubstring = string.Empty;
                        if (flip == "Upper")
                        {
                            newSubstring = substring.ToUpper();
                        }
                        else
                        {
                            newSubstring = substring.ToLower();
                        }
                        activationKey = activationKey.Replace(substring, newSubstring);
                        Console.WriteLine(activationKey);
                        break;
                    case "Slice":
                        startIndex = int.Parse(currentCommand[1]);
                        endIndex = int.Parse(currentCommand[2]);
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(activationKey);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
