using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsAverageGrade = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsAverageGrade.ContainsKey(name))
                {
                    studentsAverageGrade.Add(name, new List<double>());
                    studentsAverageGrade[name].Add(grade);
                    continue;
                }
                studentsAverageGrade[name].Add(grade);
            }
            studentsAverageGrade = studentsAverageGrade.Where(s => s.Value.Average() >= 4.5).ToDictionary(s => s.Key, s => s.Value);
            foreach (var student in studentsAverageGrade.OrderByDescending(s => s.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
            }
        }
    }
}
