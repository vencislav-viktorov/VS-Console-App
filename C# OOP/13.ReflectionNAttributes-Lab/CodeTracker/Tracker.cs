using System;
using System.Text;
using System.Linq;
using System.Reflection;

public class Tracker
{
    public string PrintMethodsByAuthor()
    {
        var type = typeof(StartUp);
        var methods = type.GetMethods(
            BindingFlags.Instance |
            BindingFlags.Public |
            BindingFlags.Static);
        var sb = new StringBuilder();

        foreach (var method in methods)
        {
            if (method.CustomAttributes
                .Any(n => n.AttributeType == typeof(AttributeUsageAttribute)))
            {
                var attributes = method.GetCustomAttributes(false);

                foreach (AuthorAttribute attr in attributes)
                {
                    sb.AppendLine($"{method.Name} is written by {attr.Name}");
                }
            }
        }

        return sb.ToString().Trim();
    }
}