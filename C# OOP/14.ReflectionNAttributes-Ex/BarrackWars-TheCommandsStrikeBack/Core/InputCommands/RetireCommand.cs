namespace P03_BarraksWars.Core.InputCommands
{
    using _03BarracksFactory.Contracts;

    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IUnitFactory unitFactory, IRepository unitRepository)
            : base(data, unitFactory, unitRepository)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            this.UnitRepository.RemoveUnit(unitType);

            return $"{unitType} retired!";
        }
    }
}