using System;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] guestStatus = Console.ReadLine().Split();
                if (guestStatus[2] == "not")
                {
                    if (guestList.Contains(guestStatus[0]))
                    {
                        guestList.Remove(guestStatus[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{guestStatus[0]} is not in the list!");
                    }
                }
                else
                {
                    if (guestList.Contains(guestStatus[0]))
                    {
                        Console.WriteLine($"{guestStatus[0]} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(guestStatus[0]);
                    }
                }
            }
            foreach (var guest in guestList)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
