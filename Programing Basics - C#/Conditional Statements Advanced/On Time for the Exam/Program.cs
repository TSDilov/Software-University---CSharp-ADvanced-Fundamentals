using System;

namespace OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int houtArrive = int.Parse(Console.ReadLine());
            int minArrive = int.Parse(Console.ReadLine());

            minExam += hourExam * 60;
            minArrive += houtArrive * 60;
            string time = "";
            int difference = minExam - minArrive;
            if (difference<0)
            {
                time = "Late";
            }
            else if (difference <=30)
            {
                time = "On time";
            }
            else
            {
                time = "Early";
            }
            Console.WriteLine(time);

            if (difference <= -60)
            {
                int hh = difference * (-1) / 60;
                int mm = difference * (-1) - hh * 60;
                if (mm < 10)
                {
                    Console.WriteLine($"{hh}:0{mm} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{hh}:{mm} hours after the start");
                }
            }
            else if (difference < 0)
            {
                int mm = difference * (-1);
                Console.WriteLine($"{mm} minutes after the start");
            }
            else if (difference > 0 && difference <= 30)
            {
                int mm = difference;
                Console.WriteLine($"{mm} minutes before the start");
            }
            else if (difference > 30 && difference < 60)
            {
                int mm = difference;
                Console.WriteLine($"{mm} minutes before the start");
            }
            else if (difference >= 60)
            {
                int hh = difference / 60;
                int mm = difference - hh * 60;
                if (mm<10)
                {
                    Console.WriteLine($"{hh}:0{mm} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{hh}:{mm} hours before the start");
                }
            }                
        }
    }
}
