using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensorOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var fromTo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = new List<int>();
            for (int i = fromTo[0]; i <= fromTo[1]; i++)
            {
                numbers.Add(i);
            }
            Predicate<int> evenOrOdd = null;
            var filter = Console.ReadLine();
            switch (filter)
            {
                case "odd":
                    evenOrOdd = n => n % 2 != 0;
                    break;
                case "even":
                    evenOrOdd = n => n % 2 == 0;
                    break;
            }
            Console.WriteLine(string.Join(" ", numbers.FindAll(evenOrOdd)));

        }
    }
}
