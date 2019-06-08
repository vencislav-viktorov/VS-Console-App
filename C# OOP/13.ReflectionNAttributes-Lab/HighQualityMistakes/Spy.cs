using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string AnalyzeAcessModifiers(string className)
    {
        var classType = Type.GetType(className);
        var classFields = classType.GetFields(
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.Public);
        var classPublicMethods = classType.GetMethods(
            BindingFlags.Instance |
            BindingFlags.Public);
        var classNonPublicMethods = classType.GetMethods(
            BindingFlags.Instance |
            BindingFlags.NonPublic);

        var sb = new StringBuilder();

        foreach (var field in classFields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        foreach (var method in classNonPublicMethods
            .Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }

        foreach (var method in classPublicMethods
            .Where(m => m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }
}