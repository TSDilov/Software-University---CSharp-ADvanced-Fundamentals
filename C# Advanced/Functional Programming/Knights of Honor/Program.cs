using System;
using System.Linq;

namespace KnightsofHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = str => Console.WriteLine("Sir " + str);
            Console.ReadLine().Split().ToList().ForEach(print);
        }
    }
}
