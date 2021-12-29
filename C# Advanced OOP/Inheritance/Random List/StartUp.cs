using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new RandomList();
            list.Add("aaa");
            list.Add("bbb");
            list.Add("ccc");
            Console.WriteLine(list.RandomString());
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
