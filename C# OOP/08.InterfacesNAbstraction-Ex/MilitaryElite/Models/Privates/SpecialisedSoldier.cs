namespace MilitaryElite
{
    using System;
    using System.Text;

    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;

        public SpecialisedSoldier(
            string id, 
            string firstName, 
            string lastName, 
            decimal salary
            , string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get => this.corps;

            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException("Invalid Corps!");
                }

                this.corps = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append($"Corps: {this.Corps}");

            return sb.ToString();
        }
    }
}