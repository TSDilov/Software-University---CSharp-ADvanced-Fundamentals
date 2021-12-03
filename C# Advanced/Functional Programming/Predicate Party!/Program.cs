using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split().ToList();
            

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "Party!")
            {
                Predicate<string> predicate = GetPredicate(commands[1], commands[2]);
                if (commands[0] == "Remove")
                {
                    people.RemoveAll(predicate);
                }

                else if (commands[0] == "Double")
                {
                    List<string> doubleNames = people.FindAll(predicate);

                    if (doubleNames.Any())
                    {
                        int index = people.FindIndex(predicate);
                        people.InsertRange(index, doubleNames);
                    }

                }
                
                commands = Console.ReadLine().Split();
            }
            if (people.Any())
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string criteria, string paramForCriteria)
        {
            if (criteria == "StartsWith")
            {
                return x => x.StartsWith(paramForCriteria);
            }
            if (criteria == "EndsWith")
            {
                return x => x.EndsWith(paramForCriteria);
            }
            return x => x.Length == int.Parse(paramForCriteria);
        }
    }
}
