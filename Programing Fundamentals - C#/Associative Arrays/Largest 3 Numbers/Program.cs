using System;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ",Console.ReadLine().Split().Select(int.Parse)
                .OrderByDescending(n => n).Take(3).ToArray()));
        }
    }
}
