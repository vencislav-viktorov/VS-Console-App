namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Linq;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var assembly = typeof(AppEntryPoint)
                .Assembly;

            var currentUnitType = assembly
                .GetTypes()
                .FirstOrDefault(x => x.Name == unitType);

            if (currentUnitType == null)
            {
                throw new ArgumentException("Not valid unit");
            }

            return (IUnit)Activator.CreateInstance(currentUnitType);
        }
    }
}