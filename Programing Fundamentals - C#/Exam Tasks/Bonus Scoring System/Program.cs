using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());            
            double maxBonus = 0;
            int lecturesOfStudentWithMaxAttendances = 0;

            for (int i = 0; i < countOfStudents; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                double totalBonus = (double)attendances / countOfLectures * (5 + initialBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    lecturesOfStudentWithMaxAttendances = attendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {lecturesOfStudentWithMaxAttendances} lectures.");

        }
    }
}
