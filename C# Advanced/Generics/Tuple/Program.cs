using System;
using System.Linq;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split();
            string name = input1[0] + " " + input1[1];
            string address = input1[2];
            var nameAndAddress = new MyTuple<string, string>(name, address);
            
            var input2 = Console.ReadLine().Split();
            string firstName = input2[0];
            int litersOfBeer = int.Parse(input2[1]);
            var nameAndLitersBeer = new MyTuple<string, int>(firstName, litersOfBeer);
            
            var input3 = Console.ReadLine().Split();
            int integer = int.Parse(input3[0]);
            double doubleNumber = double.Parse(input3[1]);
            var integerAndDouble = new MyTuple<int, double>(integer, doubleNumber);
            
            Console.WriteLine(nameAndAddress.GetItem());
            Console.WriteLine(nameAndLitersBeer.GetItem());
            Console.WriteLine(integerAndDouble.GetItem());
        }
    }
}
