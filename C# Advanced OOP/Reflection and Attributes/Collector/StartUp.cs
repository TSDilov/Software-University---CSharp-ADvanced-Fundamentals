using System;
using System.Reflection;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var spy = new Spy();
            var result = spy.CollectTypesOfMethods("Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}
