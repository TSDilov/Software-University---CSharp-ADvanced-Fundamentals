using System;

namespace Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            array = Tribonacci(array);

            Console.WriteLine(string.Join(" ",array));
        }
        static int[] Tribonacci(int[] array) 
        {
            if (array.Length <= 3)
            {
                switch (array.Length)
                {
                    case 1:
                        array[0] = 1;
                        break;
                    case 2:
                        array[0] = 1;
                        array[1] = 1;
                        break;
                    case 3:
                        array[0] = 1;
                        array[1] = 1;
                        array[2] = 2;
                        break;
                }
            }
            if (array.Length > 3)
            {
                array[0] = 1;
                array[1] = 1;
                array[2] = 2;
                for (int i = 3; i < array.Length; i++)
                {
                    array[i] = array[i - 1] + array[i - 2] + array[i - 3];
                }
            }

            return array;
        }
    }
}
