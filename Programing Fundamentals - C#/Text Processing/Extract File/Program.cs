using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = Console.ReadLine();
            int lastIndexOfBreakLine = fullPath.LastIndexOf('\\');
            string substringPath = fullPath.Substring(lastIndexOfBreakLine + 1);
            int extensionIndex = substringPath.LastIndexOf('.');
            string extension = substringPath.Substring(extensionIndex + 1);
            string name = substringPath.Substring(0, substringPath.Length - extension.Length - 1);
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
