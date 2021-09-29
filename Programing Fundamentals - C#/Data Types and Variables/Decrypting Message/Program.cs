using System;
using System.Text;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOFCharacters = int.Parse(Console.ReadLine());
            String message = string.Empty;
            for (int i = 0; i < numberOFCharacters; i++)
            {
                char character = char.Parse(Console.ReadLine());
                char newChar = (char)(character + key);
                message += newChar;
            }
            Console.WriteLine(message);
        }
    }
}
