using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsForReplace = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in wordsForReplace)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
