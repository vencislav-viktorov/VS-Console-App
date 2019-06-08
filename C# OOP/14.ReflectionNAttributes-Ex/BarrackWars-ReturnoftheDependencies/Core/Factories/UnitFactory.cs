namespace BarrackWars_ReturnoftheDependencies.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Models.Units;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var model = assembly.GetTypes()
                .FirstOrDefault(t => t.Name == unitType);

            if (model == null)
            {
                throw new ArgumentException("Invalid Unit Type!");
            }

            if (!typeof(Unit).IsAssignableFrom(model))
            {
                throw new ArgumentException($"{unitType} is not a Unit Type!");
            }

            var unit = (IUnit)Activator.CreateInstance(model);

            return unit;
        }
    }
}