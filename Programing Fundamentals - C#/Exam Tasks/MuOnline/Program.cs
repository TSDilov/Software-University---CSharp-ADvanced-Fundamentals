using System;
using System.Collections.Generic;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            int health = 100;
            int bitcoins = 0;
            bool dead = false;
            foreach (var room in rooms)
            {
                string[] action = room.Split();

                if (action[0] != "potion" && action[0] != "chest")
                {
                    health -= int.Parse(action[1]);
                    string monster = action[0];
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        dead = true;
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {rooms.IndexOf(room) + 1}");
                        return;
                    }
                }
                else if (action[0] == "potion")
                {
                    int healthBefore = health;
                    health += int.Parse(action[1]);
                    int healAmount = int.Parse(action[1]);
                    if (health > 100)
                    {
                        health = 100;
                        healAmount = health - healthBefore;
                    }
                    Console.WriteLine($"You healed for {healAmount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (action[0] == "chest")
                {
                    bitcoins += int.Parse(action[1]);
                    Console.WriteLine($"You found {action[1]} bitcoins.");
                }
            }
            if (!dead)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
