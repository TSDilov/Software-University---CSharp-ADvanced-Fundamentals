using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split();
            var sites = Console.ReadLine().Split();
            foreach (var number in phoneNumbers)
            {
                TestNumber(number);
            }
            foreach (var site in sites)
            {
                TestURL(site);
            }
        }

        private static void TestURL(string site)
        {
            var url = new Smartphone(site);
            Console.WriteLine(url.Browse(site));
        }

        private static void TestNumber(string number)
        {
            if (number.Length == 7)
            {
                var phone = new StationaryPhone(number);
                Console.WriteLine(phone.Call(number));
            }
            else if (number.Length == 10)
            {
                var phone = new Smartphone(number);
                Console.WriteLine(phone.Call(number));
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
