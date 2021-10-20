using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            MethodNumberOFVowelsInWord(word);
        }

        static void MethodNumberOFVowelsInWord(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                if (letter == 'a'  || letter == 'e' ||  letter == 'i' 
                    || letter == 'o' ||  letter == 'u'  || letter == 'y')
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
