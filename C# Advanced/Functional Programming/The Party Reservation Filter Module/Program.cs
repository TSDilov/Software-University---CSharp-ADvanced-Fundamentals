using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            var filters = new Dictionary<string, Predicate<string>>();
            string input;

            while ((input = Console.ReadLine()) != "Print")
            {
                string[] addRemoveFilter = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string addRemove = addRemoveFilter[0];
                string condition = addRemoveFilter[1];
                string value = addRemoveFilter[2];
                switch (addRemove)
                {
                    case "Add filter":
                        Predicate<string> predicate = GetPredicate(condition, value);
                        filters.Add(value, predicate);
                        break;
                    case "Remove filter":
                        predicate = GetPredicate(condition, value);
                        filters.Remove(value);
                        break;
                }

            }
            foreach (var filter in filters)
            {
                names.RemoveAll(filter.Value);
            }
            Console.WriteLine(string.Join(" ", names));

        }
        static Predicate<string> GetPredicate(string commandType, string arg) 
        {
            switch (commandType)
            {
                case "Starts with":
                    return name => name.StartsWith(arg);
                case "Ends with":
                    return name => name.EndsWith(arg);
                case "Contains":
                    return name => name.Contains(arg);
                case "Length":
                    return name => name.Length == int.Parse(arg);
                default:
                    throw new ArgumentException("Invalid command type: " + commandType);
            }
        }
        
    }
}
