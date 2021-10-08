using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] member = Console.ReadLine().Split();
                Person currentPerson = new Person(member[0], int.Parse(member[1]));
                family.AddMember(currentPerson);
            }
            family.FamilyMembers.Where(m => m.Age > 30).OrderBy(m => m.Name).ToList().ForEach(Console.WriteLine);
        }
    }
}
