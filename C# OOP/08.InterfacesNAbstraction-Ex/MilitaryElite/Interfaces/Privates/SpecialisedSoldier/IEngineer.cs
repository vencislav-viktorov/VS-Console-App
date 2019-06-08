namespace MilitaryElite
{
    using System.Collections.Generic;

    public interface IEngineer
    {
        IReadOnlyCollection<Repair> Repairs { get; }
    }
}