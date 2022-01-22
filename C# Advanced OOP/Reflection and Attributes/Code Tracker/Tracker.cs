using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor(string name)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance 
                    | BindingFlags.Static | BindingFlags.NonPublic))
                {
                    var attribute = method.GetCustomAttribute<AuthorAttribute>();
                    if (attribute != null && attribute.Name == name)
                    {
                        Console.WriteLine($"{method.Name} is writen by {attribute.Name}");
                    }
                }
            }
        }
    }
}
