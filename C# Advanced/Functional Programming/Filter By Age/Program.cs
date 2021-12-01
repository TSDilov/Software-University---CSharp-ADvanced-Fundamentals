using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterbyAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> agesOfNames = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] nameAge = Console.ReadLine().Split(", ");
                agesOfNames.Add(nameAge[0], int.Parse(nameAge[1]));
            }
            Func<int, int, bool> cond = null;
            string condition = Console.ReadLine();
            if (condition == "older")
            {
                cond = (a, b) => a >= b;
            }
            else 
            {
                cond = (a, b) => a < b;
            }
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            if (format == "name")
            {
                foreach (var person in agesOfNames.Where(p => cond(p.Value, age)))
                {
                    Console.WriteLine(person.Key);
                }
            }
            else if (format == "age")
            {
                foreach (var person in agesOfNames.Where(p => cond(p.Value, age)))
                {
                    Console.WriteLine(person.Value);
                }
            }
            else if (format == "name age")
            {
                foreach (var person in agesOfNames.Where(p => cond(p.Value, age)))
                {
                    Console.WriteLine($"{person.Key} - {person.Value}");
                }
            }
            
        }
    }
}
