using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contestData = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> participant = new Dictionary<string, int>();
            string[] data = Console.ReadLine().Split(" -> ");

            while (data[0] != "no more time")
            {
                string student = data[0];
                string contest = data[1];
                int points = int.Parse(data[2]);

                if (!contestData.ContainsKey(contest))
                {
                    contestData.Add(contest, new Dictionary<string, int>());
                    contestData[contest].Add(student, points);
                }
                else
                {
                    if (contestData[contest].ContainsKey(student))
                    {
                        if (contestData[contest][student] < points)
                        {
                            contestData[contest][student] = points;
                        }
                    }
                    else
                    {
                        contestData[contest].Add(student, points);
                    }
                }
                
                data = Console.ReadLine().Split(" -> ");
            }
            foreach (var contest in contestData)
            {
                foreach (var student in contest.Value)
                {
                    if (!participant.ContainsKey(student.Key))
                    {
                        participant.Add(student.Key, student.Value);
                    }
                    else
                    {
                        participant[student.Key] += student.Value;
                    }
                }
            }
            foreach (var contest in contestData)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int count = 1;
                foreach (var student in contest.Value.OrderByDescending(p => p .Value).ThenBy(s => s.Key))
                {
                    Console.WriteLine($"{count}. {student.Key} <::> {student.Value}");
                    count++;
                }
            }
            int count1 = 1;
            Console.WriteLine("Individual standings: ");
            foreach (var student in participant.OrderByDescending(p => p.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{count1}. {student.Key} -> {student.Value}");
                count1++;
            }
        }
    }
}
