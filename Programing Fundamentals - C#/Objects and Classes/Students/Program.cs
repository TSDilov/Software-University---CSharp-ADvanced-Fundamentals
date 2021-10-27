using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Students> students = new List<Students>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                List<string> student = input.Split().ToList();
                Students oneStudent = new Students();
                oneStudent.FirstName = student[0];
                oneStudent.LastName = student[1];
                oneStudent.Age = int.Parse(student[2]);
                oneStudent.Hometown = student[3];
                if (students.Any(s => s.FirstName == student[0] && s.LastName == student[1]))
                {
                    int index = students.FindIndex(s => s.FirstName == student[0] && s.LastName == student[1]);
                    students[index].Age = int.Parse(student[2]);
                    students[index].Hometown = student[3];
                }
                else
                {
                    students.Add(oneStudent);
                }               
            }
            string filterTown = Console.ReadLine();
            foreach (var student in students.Where(s => s.Hometown == filterTown))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
    class Students 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

    }
}
