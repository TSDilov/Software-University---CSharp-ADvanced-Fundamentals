using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            string following = "following";
            string followers = "followers";
            var theVLogger = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            while (command[0] != "Statistics")
            {
                string name = command[0];
                string currentCommand = command[1];
                string name2 = command[2];
                if (currentCommand == "joined" && !theVLogger.ContainsKey(name))
                {
                    theVLogger.Add(name, new Dictionary<string, HashSet<string>>());
                    theVLogger[name].Add(following, new HashSet<string>());
                    theVLogger[name].Add(followers, new HashSet<string>());
                }
                else if (currentCommand == "followed" && theVLogger.ContainsKey(name) &&
                    theVLogger.ContainsKey(name2) && name != name2 &&
                    !theVLogger[name2][followers].Contains(name))
                {
                    theVLogger[name][following].Add(name2);
                    theVLogger[name2][followers].Add(name);
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"The V-Logger has a total of {theVLogger.Count} vloggers in its logs.");
            var sortedVLogger = theVLogger.OrderByDescending(v => v.Value[followers].Count).
                ThenBy(v => v.Value[following].Count);
            int counter = 1;

            foreach (var vloger in sortedVLogger)
            {
                Console.WriteLine($"{counter}. {vloger.Key} : {vloger.Value[followers].Count} " +
                    $"followers, {vloger.Value[following].Count} following");

                if (counter == 1)
                {
                    foreach (var follower in vloger.Value[followers].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                counter++; ;
            }
        }
    }
}
