namespace BarrackWars_ReturnoftheDependencies.Core.InputCommands
{
    using System;
    using Contracts;

    public class FightCommand : Command
    {
        public FightCommand(string[] data)
            : base(data)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return null;
        }
    }
}