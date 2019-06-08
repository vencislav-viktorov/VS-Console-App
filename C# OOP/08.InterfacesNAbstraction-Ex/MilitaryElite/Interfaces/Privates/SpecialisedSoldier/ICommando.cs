namespace MilitaryElite
{
    using System.Collections.Generic;

    public interface ICommando
    {
        IReadOnlyCollection<Mission> Missions { get; }

        void CompleteMission(string codeName);
    }
}