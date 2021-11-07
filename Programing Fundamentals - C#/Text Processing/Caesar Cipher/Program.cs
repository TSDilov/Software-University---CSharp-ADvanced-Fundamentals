using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder crypted = new StringBuilder();
            crypted.Append(Console.ReadLine());
            StringBuilder unCrypted = new StringBuilder();

            foreach (var @char in crypted.ToString())
            {
                unCrypted.Append((char)(@char + 3));
            }
            Console.WriteLine(unCrypted);
        }
    }
}
