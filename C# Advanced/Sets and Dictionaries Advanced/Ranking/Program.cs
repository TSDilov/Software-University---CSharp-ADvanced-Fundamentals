using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestData = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> studentData = new Dictionary<string, Dictionary<string, int>>();
            string contestPass = Console.ReadLine();

            while (contestPass != "end of contests")
            {
                string[] passInfo = contestPass.Split(":");
                string contest = passInfo[0];
                string pass = passInfo[1];
                contestData.Add(contest, pass);
                contestPass = Console.ReadLine();
            }
            string[] submissionData = Console.ReadLine().Split("=>");

            while (submissionData[0] != "end of submissions")
            {
                
                string contest = submissionData[0];
                string pass = submissionData[1];
                string student = submissionData[2];
                int points = int.Parse(submissionData[3]);

                bool valid = Validation(contest, pass, contestData);
                if (valid)
                {
                    if (!studentData.ContainsKey(student))
                    {
                        studentData.Add(student, new Dictionary<string, int>());
                        studentData[student].Add(contest,points);
                    }
                    else
                    {
                        if (studentData[student].ContainsKey(contest))
                        {
                            if (studentData[student][contest] < points)
                            {
                                studentData[student][contest] = points;
                            }
                        }
                        else
                        {
                            studentData[student].Add(contest, points);
                        }
                    }
                }
                submissionData = Console.ReadLine().Split("=>");
            }
            string bestStudent = string.Empty;
            int highestPoints = 0;
            foreach (var student in studentData)
            {
                int sum = 0;
                foreach (var contest in student.Value)
                {
                    sum += contest.Value;
                }
                if (sum > highestPoints)
                {
                    bestStudent = student.Key;
                    highestPoints = sum;
                }
            }
            Console.WriteLine($"Best candidate is {bestStudent} with total {highestPoints} points.");
            studentData = studentData.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);
            Console.WriteLine("Ranking: ");
            foreach (var student in studentData)
            {
                Console.WriteLine(student.Key);
                foreach (var contest in student.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
        static bool Validation(string contest, string password, Dictionary<string, string> dict) 
        {
            if (dict.ContainsKey(contest))
            {
                if (dict[contest].Contains(password))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
