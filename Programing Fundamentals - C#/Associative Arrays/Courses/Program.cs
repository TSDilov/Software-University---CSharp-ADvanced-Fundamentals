using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesStudents = new Dictionary<string, List<string>>();
            List<string> studentInfo = Console.ReadLine().Split(" : ").ToList();

            while (studentInfo[0] != "end")
            {
                string course = studentInfo[0];
                string student = studentInfo[1];
                if (!coursesStudents.ContainsKey(course))
                {
                    coursesStudents.Add(course, new List<string>());
                    coursesStudents[course].Add(student);
                    studentInfo = Console.ReadLine().Split(" : ").ToList();
                    continue;
                }
                coursesStudents[course].Add(student);
                studentInfo = Console.ReadLine().Split(" : ").ToList();
            }

            foreach (var course in coursesStudents.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                course.Value.Sort();
                Console.Write("-- ");
                Console.WriteLine(string.Join($"\n-- ", course.Value));
            }
        }
    }
}
