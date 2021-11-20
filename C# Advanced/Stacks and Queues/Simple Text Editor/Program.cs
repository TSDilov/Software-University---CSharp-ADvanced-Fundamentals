using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> stringInterporations = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] operation = Console.ReadLine().Split();
                string command = operation[0];
                if (command == "1")
                {
                    stringInterporations.Push(text.ToString());
                    string someString = operation[1];
                    text.Append(someString);
                }
                else if (command == "2")
                {
                    stringInterporations.Push(text.ToString());
                    int countOfElementsToRemove = int.Parse(operation[1]);
                    text.Remove(text.Length - countOfElementsToRemove, countOfElementsToRemove);
                }
                else if (command == "3")
                {
                    int index = int.Parse(operation[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command == "4")
                {
                    text.Clear();
                    text.Append(stringInterporations.Pop());
                }
            }
        }
    }
}
