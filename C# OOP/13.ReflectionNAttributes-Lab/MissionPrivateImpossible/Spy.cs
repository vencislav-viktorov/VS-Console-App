using System;
using System.Reflection;
using System.Text;

public class Spy
{
    public string RevealPrivateMethods(string className)
    {
        var classType = Type.GetType(className);
        var classMethods = classType.GetMethods(
            BindingFlags.Instance |
            BindingFlags.NonPublic);
        var sb = new StringBuilder();

        sb.AppendLine($"All Private Methods of Class: {classType}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (var method in classMethods)
        {
            sb.AppendLine(method.Name);
        }

        return sb.ToString().Trim();
    }
}