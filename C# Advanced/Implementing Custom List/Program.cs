using System;

namespace ImplementingList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Print();
            list.RemoveAt(1);
            list.Print();
            list.Swap(0, 1);
            list.Print();
            list.Swap(0, 1);
            list.Print();
            list.Insert(1, 2);
            list.Print();
            list.Add(5);
            list.Insert(3, 4);
            list.Print();
            Console.WriteLine(list.Contains(3));
            Console.WriteLine(list.Find(5));
            Console.WriteLine(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            
        }
    }
}
