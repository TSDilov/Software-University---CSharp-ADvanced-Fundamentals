using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();
                string format = command[0];
                string user = command[1];

                switch (format)
                {
                    case "register":
                        string licenseNumber = command[2];
                        if (!registeredUsers.ContainsKey(user))
                        {
                            registeredUsers.Add(user, licenseNumber);
                            Console.WriteLine($"{user} registered {licenseNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licenseNumber}");
                        }
                        break;
                    case "unregister":
                        if (registeredUsers.ContainsKey(user))
                        {
                            registeredUsers.Remove(user);
                            Console.WriteLine($"{user} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }
                        break;
                }
            }
            foreach (var us in registeredUsers)
            {
                Console.WriteLine($"{us.Key} => {us.Value}");
            }
        }
    }
}
