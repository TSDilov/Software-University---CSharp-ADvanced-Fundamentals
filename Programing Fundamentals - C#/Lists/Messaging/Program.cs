using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();

            List<string> removedElements = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                string intStr = numbers[i].ToString();
                int index = 0;
                for (int j = 0; j < intStr.Length; j++)
                {
                    index += (int)char.GetNumericValue(intStr[j]);
                }

                if (index >= text.Length)
                {
                    while (index >= text.Length)
                    {
                        index = index - text.Length;
                    }
                }

                removedElements.Add(text[index].ToString());
                text = text.Remove(index, 1);
            }
            Console.WriteLine(string.Join("",removedElements));
        }
    }
}
