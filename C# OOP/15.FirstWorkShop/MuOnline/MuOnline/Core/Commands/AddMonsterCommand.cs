namespace MuOnline.Core.Commands
{
    using MuOnline.Core.Commands.Contracts;
    using MuOnline.Core.Factories.Contracts;
    using MuOnline.Models.Monsters.Contracts;
    using MuOnline.Repositories.Contracts;

    public class AddMonsterCommand : ICommand
    {
        private const string successfullMessage = "Successfully create monster: {0}";

        private readonly IRepository<IMonster> monsterRepository;
        private readonly IMonsterFactory monsterFactory;

        public AddMonsterCommand(IRepository<IMonster> monsterRepository, IMonsterFactory monsterFactory)
        {
            this.monsterRepository = monsterRepository;
            this.monsterFactory = monsterFactory;
        }

        public string Execute(string[] inputArgs)
        {
            string monsterTypeName = inputArgs[0];

            var monster = monsterFactory.Create(monsterTypeName);

            this.monsterRepository.Add(monster);

            return string.Format(successfullMessage, monster.GetType().Name);
        }
    }
}