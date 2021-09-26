using System;

namespace LowerorUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char alphabet = char.Parse(Console.ReadLine());
            if (alphabet >= 65 && alphabet <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }

        }
    }
}
