using System;
using System.Text;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\@#+[A-Z][A-Za-z0-9][A-Za-z0-9][A-Za-z0-9][A-Za-z0-9]+[A-Z]\@#+";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                StringBuilder productGroup = new StringBuilder();
                Match validBarcodes = Regex.Match(input, pattern);
                if (!validBarcodes.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                MatchCollection groupNumber = Regex.Matches(input, "[0-9]");
                foreach (Match item in groupNumber)
                {
                    productGroup.Append(item);
                }
                if (productGroup.Length == 0)
                {
                    Console.WriteLine("Product group: 00");
                }
                else
                {
                    Console.WriteLine($"Product group: {productGroup}");
                }
            }
        }
    }
}
