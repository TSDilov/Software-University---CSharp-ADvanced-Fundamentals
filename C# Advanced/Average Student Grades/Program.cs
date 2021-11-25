using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] studentGrade = Console.ReadLine().Split();
                string name = studentGrade[0];
                decimal grade = decimal.Parse(studentGrade[1]);
                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<decimal>());
                }
                studentGrades[name].Add(grade);
            }
            foreach (var student in studentGrades)
            {
                Console.WriteLine($"{student.Key} -> " +
                    $"{string.Join(" ", student.Value.Select(g => $"{g:F2}"))} (avg: {student.Value.Average():F2})");
            }
        }
    }
}
