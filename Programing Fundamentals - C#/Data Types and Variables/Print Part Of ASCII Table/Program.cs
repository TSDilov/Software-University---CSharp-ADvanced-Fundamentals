using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int finalIndex = int.Parse(Console.ReadLine());
            for (int i = startIndex; i <= finalIndex; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
