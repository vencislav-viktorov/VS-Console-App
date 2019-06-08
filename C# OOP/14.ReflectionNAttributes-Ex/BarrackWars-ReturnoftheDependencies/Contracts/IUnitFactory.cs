namespace BarrackWars_ReturnoftheDependencies.Contracts
{
    public interface IUnitFactory
    {
        IUnit CreateUnit(string unitType);
    }
}