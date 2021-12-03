using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split().ToList();
            Predicate<string> function = word => word.Length <= n;
            names = names.FindAll(function);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
