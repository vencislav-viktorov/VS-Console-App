namespace MuOnline.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using MuOnline.Core.Factories.Contracts;
    using MuOnline.Models.Monsters.Contracts;

    public class MonsterFactory : IMonsterFactory
    {
        public IMonster Create(string monsterTypeName)
        {
            var monsterTypeNameLowerCase = monsterTypeName.ToLower();

            var monsterType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => typeof(IMonster).IsAssignableFrom(x))
                .FirstOrDefault(x => x.Name.ToLower() == monsterTypeNameLowerCase);

            if (monsterType == null)
            {
                throw new ArgumentNullException("Invalid monster type!");
            }

            var monster = (IMonster)Activator.CreateInstance(monsterType);

            return monster;
        }
    }
}