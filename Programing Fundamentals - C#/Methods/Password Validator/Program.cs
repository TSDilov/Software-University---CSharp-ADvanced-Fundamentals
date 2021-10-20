using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (MethodForSixToTenCharacters(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (MethodForLettersAndDigits(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (MethodForAtleastTwoDigits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (MethodForSixToTenCharacters(password)  && MethodForLettersAndDigits(password)  
                && MethodForAtleastTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool MethodForAtleastTwoDigits(string password)
        {
            bool isValid = true;
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char character = password[i];
                if (character >= '0' && character < '9')
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }

        static bool MethodForLettersAndDigits(string password)
        {
            bool isValid = true;
            foreach (var character in password)
            {
                if (character >= 'a' && character <= 'z' || character >= '0' && character <= '9' 
                    || character >= 'A' && character <='Z')
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

        static bool MethodForSixToTenCharacters(string password)
        {
            bool isValid = false;
            int countOfCharacters = 0;
            for (int i = 0; i < password.Length; i++)
            {
                countOfCharacters++;
                if (countOfCharacters >= 6 && countOfCharacters <= 10)
                {
                    isValid = true;
                }               
            }
            return isValid;
        }
    }
}
