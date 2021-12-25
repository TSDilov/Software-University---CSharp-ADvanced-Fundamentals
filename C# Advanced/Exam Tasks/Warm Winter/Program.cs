using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            var hats = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var scarfs = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var sets = new List<int>();

            while (hats.Count != 0 && scarfs.Count != 0)
            {
                var currentHat = hats.Peek();
                var currentScarf = scarfs.Peek();
                if (currentHat > currentScarf)
                {
                    var currentSet = currentHat + currentScarf;
                    sets.Add(currentSet);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (currentHat < currentScarf)
                {
                    hats.Pop();
                }
                else
                {
                    scarfs.Dequeue();
                    currentHat += 1;
                    hats.Pop();
                    hats.Push(currentHat);
                }
            }
            int maxSet = int.MinValue;
            for (int i = 0; i < sets.Count; i++)
            {
                if (sets[i] > maxSet)
                {
                    maxSet = sets[i];
                }
            }
            Console.WriteLine($"The most expensive set is: {maxSet}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
