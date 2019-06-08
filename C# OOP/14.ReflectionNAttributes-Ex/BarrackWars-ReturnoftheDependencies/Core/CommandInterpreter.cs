namespace BarrackWars_ReturnoftheDependencies.Core
{
    using Contracts;
    using Core.InputCommands;
    using System;
    using System.Linq;
    using System.Reflection;

    class CommandInterpreter : ICommandInterpreter
    {
        private IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            var assembly = Assembly.GetCallingAssembly();
            var commandType = assembly.GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == commandName + "command");

            if (commandType == null)
            {
                throw new ArgumentException("Invalid Command!");
            }

            if (!typeof(IExecutable).IsAssignableFrom(commandType))
            {
                throw new ArgumentException($"{commandName} Is Not A Command!");
            }

            var fieldsToInject = commandType.GetFields(
                BindingFlags.NonPublic |
                BindingFlags.Instance)
                .Where(f => f.CustomAttributes.Any(ca => ca.AttributeType == typeof(InjectAttribute)))
                .ToArray();

            var injectArgs = fieldsToInject
                .Select(f => this.serviceProvider.GetService(f.FieldType))
                .ToArray();

            object[] constructorArgs = new object[] { data }.Concat(injectArgs)
                .ToArray();

            var instance = (IExecutable)Activator.CreateInstance(commandType, constructorArgs);

            return instance;
        }
    }
}