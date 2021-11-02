using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> examResulrs = new Dictionary<string, int>();
            Dictionary<string, int> languageSubmissions = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split("-").ToArray();

            while (input[0] != "exam finished")
            {
                string studend = input[0];
                string language = input[1];
                if (language == "banned")
                {
                    examResulrs.Remove(studend);
                    input = Console.ReadLine().Split("-").ToArray();
                    continue;
                }
                int points = int.Parse(input[2]);
                if (!examResulrs.ContainsKey(studend))
                {
                    examResulrs.Add(studend, points);
                }
                else
                {
                    if (examResulrs[studend] < points)
                    {
                        examResulrs[studend] = points;
                    }
                }

                if (!languageSubmissions.ContainsKey(language))
                {
                    languageSubmissions.Add(language, 1);
                }
                else
                {
                    languageSubmissions[language]++;
                }
                input = Console.ReadLine().Split("-").ToArray();
            }
            Console.WriteLine("Results:");
            foreach (var student in examResulrs.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var language in languageSubmissions.OrderByDescending(l => l.Value).ThenBy(l => l.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
