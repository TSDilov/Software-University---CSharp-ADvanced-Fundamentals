using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeatsNum = int.Parse(Console.ReadLine());
            string result = MethodRepeat(text, repeatsNum);
            Console.WriteLine(result);
        }

        static string MethodRepeat(string text, int repeatsNum)
        {
            string result = "";

            for (int i = 0; i < repeatsNum; i++)
            {
                result += text;
            }
            return result;
        }
    }
}
