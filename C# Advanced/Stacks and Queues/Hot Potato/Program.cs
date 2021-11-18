using System;
using System.Collections.Generic;

namespace HotPatato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int mover = int.Parse(Console.ReadLine());
            Queue<string> childrens = new Queue<string>();
            foreach (var name in names)
            {
                childrens.Enqueue(name);
            }

            while (childrens.Count > 1)
            {
                for (int i = 0; i < mover - 1; i++)
                {
                    string ChildrenWithPatato = childrens.Dequeue();
                    childrens.Enqueue(ChildrenWithPatato);
                }
                string removed = childrens.Dequeue();
                Console.WriteLine("Removed " + removed);
            }
            Console.WriteLine($"Last is {childrens.Dequeue()}");
        }
    }
}
