using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string[] employee = Console.ReadLine().Split(" -> ");
            while (employee[0] != "End")
            {
                string company = employee[0];
                string id = employee[1];
                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                    companies[company].Add(id);
                    employee = Console.ReadLine().Split(" -> ");
                    continue;
                }
                if (!companies[company].Contains(id))
                {
                    companies[company].Add(id);
                }
                employee = Console.ReadLine().Split(" -> ");
            }
            foreach (var company in companies.OrderBy(c => c.Key))
            {
                Console.WriteLine(company.Key);
                Console.Write("-- ");
                Console.WriteLine(string.Join("\n-- ",company.Value));

            }
        }
    }
}
