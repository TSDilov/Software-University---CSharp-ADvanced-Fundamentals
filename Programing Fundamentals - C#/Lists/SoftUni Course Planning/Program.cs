using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] command = input.Split(":",StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Add":
                        if (!lessons.Contains(command[1]))
                        {
                            lessons.Add(command[1]);
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "Insert":
                        if (!lessons.Contains(command[1]))
                        {
                            lessons.Insert(int.Parse(command[2]), command[1]);
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "Remove":
                        lessons.RemoveAll(l => l.Contains(command[1]));
                        break;
                    case "Swap":
                        if (lessons.Contains(command[1]) && lessons.Contains(command[2]))
                        {
                            int firstIndex = lessons.FindIndex(l => l == command[1]);
                            int secondIndex = lessons.FindIndex(l => l == command[2]);

                            string temp = string.Empty;
                            temp = lessons[firstIndex];
                            lessons[firstIndex] = lessons[secondIndex];
                            lessons[secondIndex] = temp;

                            if (firstIndex > 0 && firstIndex < lessons.Count - 1)
                            {
                                if (lessons[firstIndex + 1].Contains("Exercise"))
                                {
                                    lessons.Insert(secondIndex + 1, lessons[firstIndex + 1]);
                                    lessons.RemoveAt(firstIndex + 1);
                                }
                            }
                            if (secondIndex > 0 && secondIndex < lessons.Count - 1)
                            {
                                if (lessons[secondIndex + 1].Contains("Exercise"))
                                {
                                    lessons.Insert(firstIndex + 1, lessons[secondIndex + 1]);
                                    lessons.RemoveAt(secondIndex + 2);
                                }
                            }
                        }
                        break;
                    case "Exercise":
                        if (lessons.Contains(command[1]) && !lessons.Contains($"{command[1]}-Exercise"))
                        {
                            int lessondIndex = lessons.FindIndex(l => l == command[1]);
                            lessons.Insert(lessondIndex + 1, $"{lessons[lessondIndex]}-Exercise");
                        }
                        else if (!lessons.Contains(command[1]) && !lessons.Contains($"{command[1]}-Exercise"))
                        {
                            lessons.Add(command[1]);
                            lessons.Add($"{command[1]}-Exercise");
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
