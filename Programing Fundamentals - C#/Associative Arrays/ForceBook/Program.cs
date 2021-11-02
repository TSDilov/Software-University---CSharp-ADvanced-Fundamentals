using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceUsers = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "Lumpawaroo")
            {
                if (input.Contains('|'))
                {
                    string[] data = input.Split(" | ",StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = data[0];
                    string user = data[1];
                    if (!forceUsers.ContainsKey(forceSide))
                    {
                        forceUsers.Add(forceSide, new List<string>());
                    }
                    if (!forceUsers[forceSide].Contains(user) && !forceUsers.Values.Any(s => s.Contains(user)))
                    {
                        forceUsers[forceSide].Add(user);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] data = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string user = data[0];
                    string forceSide = data[1];
                    if (!forceUsers.Values.Any(u => u.Contains(user)))
                    {
                        if (!forceUsers.ContainsKey(forceSide))
                        {
                            forceUsers.Add(forceSide, new List<string>());
                        }
                        forceUsers[forceSide].Add(user);
                        Console.WriteLine($"{user} joins the {forceSide} side!");
                    }
                    else
                    {
                        foreach (var userr in forceUsers)
                        {
                            if (userr.Value.Contains(user))
                            {
                                userr.Value.Remove(user);
                            }
                        }
                        if (!forceUsers.ContainsKey(forceSide))
                        {
                            forceUsers.Add(forceSide, new List<string>());
                        }
                        forceUsers[forceSide].Add(user);
                        Console.WriteLine($"{user} joins the {forceSide} side!");
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var side in forceUsers.OrderByDescending(u => u.Value.Count).ThenBy(s => s.Key)
                .ToDictionary(s => s.Key, us => us.Value))
            {
                side.Value.Sort();
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    Console.Write("! ");
                    Console.WriteLine(string.Join($"\n! ", side.Value));
                }
            }
        }
    }
}
