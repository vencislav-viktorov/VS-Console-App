namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var type = typeof(BlackBoxInteger);

            var methods = type.GetMethods(
                BindingFlags.Instance |
                BindingFlags.NonPublic);

            var instance = Activator.CreateInstance(type, true);

            var input = Console.ReadLine();

            while (input != "END")
            {
                var splitedInput = input
                    .Split("_");

                var methodName = splitedInput[0];
                var value = int.Parse(splitedInput[1]);

                var method = methods
                    .FirstOrDefault(x => x.Name == methodName);

                method.Invoke(instance, new object[] { value });

                var field = type.GetField("innerValue",
                    BindingFlags.Instance |
                    BindingFlags.NonPublic);

                Console.WriteLine(field.GetValue(instance));

                input = Console.ReadLine();
            }
        }
    }
}