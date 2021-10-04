using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            string currentSym = " ";

            for (int i = 0; i < arr2.Length; i++)
            {
                currentSym = arr2[i];
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (currentSym == arr1[j])
                    {
                        Console.Write(currentSym + " ");
                    }
                }
            }

        }
    }
}
