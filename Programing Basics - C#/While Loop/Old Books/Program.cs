using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int count = 0;
            string nextBook = Console.ReadLine();
            while (nextBook != "No More Books")
            {
                if (nextBook == book)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    return;
                }
                count++;
                nextBook = Console.ReadLine();
            }
           
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");          
        }
    }
}
