using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type classType = Type.GetType(investigatedClass);
            var classFields = classType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            var sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: {investigatedClass}");
            var instance = Activator.CreateInstance(classType, new object[] { });

            foreach (var field in classFields.Where(f => requestedFields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(instance)}");
            }

            return sb.ToString().Trim();
        }
        public string AnalyzeAccessModifiers(string investigatedClass)
        {
            Type classType = Type.GetType(investigatedClass);
            var classFields = classType.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
            var publicClassMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            var privateClassMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            var sb = new StringBuilder();

            foreach (var field in classFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (var method in publicClassMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} must be private!");
            }
            foreach (var method in privateClassMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} must be public!");
            }

            return sb.ToString().Trim();
        }
    }
}
