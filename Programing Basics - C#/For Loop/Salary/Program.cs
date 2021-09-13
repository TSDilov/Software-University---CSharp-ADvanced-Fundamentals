using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                string browse = Console.ReadLine();
                if (browse == "Facebook")
                {
                    salary -= 150;
                }
                if (browse == "Instagram")
                {
                    salary -= 100;
                }
                if (browse == "Reddit")
                {
                    salary -= 50;
                }
            }
            if (salary<=0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
