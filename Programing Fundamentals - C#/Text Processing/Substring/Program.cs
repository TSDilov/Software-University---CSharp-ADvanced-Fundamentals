using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordForRemove = Console.ReadLine();
            string text = Console.ReadLine();
            int indexOfWord = text.IndexOf(wordForRemove);

            while (indexOfWord >= 0)
            {
                text = text.Remove(indexOfWord, wordForRemove.Length);
                indexOfWord = text.IndexOf(wordForRemove);
            }
            Console.WriteLine(text);
        }
    }
}
