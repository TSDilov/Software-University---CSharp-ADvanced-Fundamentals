using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var spy = new Spy();
            var result = spy.StealFieldInfo("Stealer.StartUp", "username", "password");
            Console.WriteLine(result);
        }
    }
}
