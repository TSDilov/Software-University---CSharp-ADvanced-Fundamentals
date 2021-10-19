using System;

namespace ImplementingLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stack = new DoublyLinkedList<int>();
                stack.RemoveFirst();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var listOfStrings = new DoublyLinkedList<string>();
            listOfStrings.AddFirst("Ceco");
            Console.WriteLine(string.Join("-", listOfStrings.ToArray()));
            listOfStrings.AddFirst("Georgi");
            Console.WriteLine(string.Join("-", listOfStrings.ToArray()));
            listOfStrings.AddLast("Ivan");
            Console.WriteLine(string.Join("-", listOfStrings.ToArray()));

            var list = new DoublyLinkedList<int>();
            list.AddFirst(3);
            Console.WriteLine(string.Join("-", list.ToArray()));

            list.AddFirst(2);
            Console.WriteLine(string.Join("-", list.ToArray()));

            list.AddFirst(1);
            Console.WriteLine(string.Join("-", list.ToArray()));

            list.AddLast(4);
            Console.WriteLine(string.Join("-", list.ToArray()));

            list.AddFirst(0);
            Console.WriteLine(string.Join("-", list.ToArray()));

            list.AddLast(100);
            Console.WriteLine(string.Join("-", list.ToArray()));

            list.RemoveFirst();
            Console.WriteLine(string.Join("-", list.ToArray()));

            list.RemoveLast();
            Console.WriteLine(string.Join("-", list.ToArray()));

            list.AddLast(5);
            Console.WriteLine(string.Join("-", list.ToArray()));
            list.DeleteByValue(1);
            Console.WriteLine(string.Join("-", list.ToArray()));

            list.ForEach(x => Console.WriteLine("--" + x));
        }
    }
}
