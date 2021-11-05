using System;
using System.Text;

namespace DigitsLettersandOther
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            text.Append(Console.ReadLine());
            StringBuilder[] chars = { new StringBuilder(), new StringBuilder(), new StringBuilder() };

            foreach (var @char in text.ToString())
            {
                if (char.IsDigit(@char))
                {
                    chars[0].Append(@char);
                }
                else if (char.IsLetter(@char))
                {
                    chars[1].Append(@char);
                }
                else
                {
                    chars[2].Append(@char);
                }
            }
            foreach (var textWithChars in chars)
            {
                Console.WriteLine(textWithChars);
            }
        }
    }
}
