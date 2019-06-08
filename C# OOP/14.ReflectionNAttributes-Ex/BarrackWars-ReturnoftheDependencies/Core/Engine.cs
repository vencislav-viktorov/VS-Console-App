namespace BarrackWars_ReturnoftheDependencies.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    class Engine : IRunnable
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    IExecutable command = commandInterpreter.InterpretCommand(data, commandName);

                    var method = typeof(IExecutable).GetMethods().First();

                    try
                    {
                        var result = (string)method.Invoke(command, null);

                        Console.WriteLine(result);
                    }

                    catch (TargetInvocationException e)
                    {
                        throw e.InnerException;
                    }

                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}