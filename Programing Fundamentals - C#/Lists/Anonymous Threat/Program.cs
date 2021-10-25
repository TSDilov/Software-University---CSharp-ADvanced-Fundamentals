using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (command != "3:1")
            {               
                string[] commands = command.Split();
                int startIndex = int.Parse(commands[1]);
                
                if (commands[0] == "merge")
                {
                    string mergedString = string.Empty;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (startIndex >= data.Count)
                    {
                        startIndex = data.Count - 1;
                    }

                    for (int i = startIndex; i <= int.Parse(commands[2]); i++)
                    {
                        if (startIndex < 0 || startIndex >= data.Count)
                        {
                            continue;
                        }

                        mergedString += data[startIndex];
                        data.RemoveAt(startIndex);
                    }
                    
                    data.Insert(startIndex, mergedString);
                }
                else if (commands[0] == "divide")
                {

                    string element = data[int.Parse(commands[1])];
                    data.RemoveAt(int.Parse(commands[1]));
                    int parts = element.Length / int.Parse(commands[2]);
                    List<string> dividedElements = new List<string>();

                    for (int i = 0; i < int.Parse(commands[2]) - 1; i++)
                    {
                        string currentElement = element.Substring(parts * i, parts);
                        dividedElements.Add(currentElement);
                    }

                        string lastElement = element.Substring(parts * (int.Parse(commands[2]) - 1));
                        dividedElements.Add(lastElement);

                    data.InsertRange(int.Parse(commands[1]), dividedElements);
                }
                
                command = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join(" ", data));
        }
    }
}
