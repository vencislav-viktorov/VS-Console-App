namespace P03_BarraksWars.Core.InputCommands
{
    using _03BarracksFactory.Contracts;
    using System;

    public class FightCommand : Command
    {
        public FightCommand(string[] data, IUnitFactory unitFactory, IRepository unitRepository)
            : base(data, unitFactory, unitRepository)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}