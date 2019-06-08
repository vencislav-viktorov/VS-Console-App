namespace BarrackWars_ReturnoftheDependencies.Core.InputCommands
{
    using System;
    using Contracts;

    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data, IRepository repository)
            : base(data)
        {
            this.Repository = repository;
        }

        protected IRepository Repository
        {
            get => this.repository;

            private set => this.repository = value;
        }

        public override string Execute()
        {
            var unitType = Data[1];

            try
            {
                this.Repository.RemoveUnit(unitType);
                return $"{unitType} retired!";
            }

            catch (Exception ex)
            {
                throw new ArgumentException("No such units in repository.", ex);
            }
        }
    }
}