using System;
using System.Text;

namespace TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] currentCommand = command.Split("|",StringSplitOptions.RemoveEmptyEntries);

                switch (currentCommand[0])
                {
                    case "Move":
                        string movedString = message.ToString().Substring(0, int.Parse(currentCommand[1]));
                        message.Remove(0, int.Parse(currentCommand[1]));
                        message.Append(movedString);
                        break;
                    case "Insert":
                        int index = int.Parse(currentCommand[1]);
                        string value = currentCommand[2];
                        message.Insert(index, value);
                        break;
                    case "ChangeAll":
                        while (message.ToString().Contains(currentCommand[1]))
                        {
                            message.Replace(currentCommand[1],currentCommand[2]);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
