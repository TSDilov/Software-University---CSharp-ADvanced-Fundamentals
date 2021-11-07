using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (var username in usernames)
            {
                if (Validation(username))
                {
                    Console.WriteLine(username);
                }
            }
        }
        static bool Validation(string valid) 
        {
            bool isValid = true;

            foreach (var @char in valid)
            {
                if ((char.IsLetterOrDigit(@char) || @char == '_' || @char == '-') && valid.Length >= 3 
                    && valid.Length <= 16)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
    }
}
