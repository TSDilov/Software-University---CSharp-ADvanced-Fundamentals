using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            var command = Console.ReadLine();
            while (command != "END")
            {
                var currentPerson = command.Split();
                persons.Add(new Person(currentPerson[0], int.Parse(currentPerson[1]), currentPerson[2]));
                command = Console.ReadLine();
            }
            var indexForCompare = int.Parse(Console.ReadLine()) - 1;
            var equal = 0;
            var notEqual = 0;
            foreach (var person in persons)
            {
                if (persons[indexForCompare].CompareTo(person) == 0)
                {
                    equal++;
                }
                else
                {
                    notEqual++;
                }
            }
            if (equal <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equal} {notEqual} {persons.Count}");
            }
        }
    }
}
