namespace MuOnline.Core.Commands
{
    using MuOnline.Core.Commands.Contracts;
    using MuOnline.Core.Factories.Contracts;
    using MuOnline.Models.Heroes.HeroContracts;
    using MuOnline.Repositories.Contracts;

    public class AddHeroCommand : ICommand
    {
        private const string successfulMessage = "Successfully created hero: {0}!";

        private readonly IRepository<IHero> heroRepository;
        private readonly IHeroFactory factory;

        public AddHeroCommand(IRepository<IHero> heroRepository, IHeroFactory factory)
        {
            this.heroRepository = heroRepository;
            this.factory = factory;
        }

        public string Execute(string[] inputArgs)
        {
            string heroType = inputArgs[0];
            string userName = inputArgs[1];

            var hero = this.factory.Create(heroType, userName);

            this.heroRepository.Add(hero);

            return string.Format(successfulMessage, userName);
        }
    }
}