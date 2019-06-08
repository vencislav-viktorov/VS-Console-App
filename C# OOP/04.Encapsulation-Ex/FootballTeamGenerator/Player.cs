namespace FootballTeamGenerator
{
    using System;

    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(
            string name, 
            int endurance, 
            int sprint, 
            int dribble, 
            int passing, 
            int shooting)
        {
            this.Name = name;
            ValidateParameter(
                endurance,
                sprint,
                dribble,
                passing,
                shooting);
            this.endurance = endurance;
            this.sprint = sprint;
            this.dribble = dribble;
            this.passing = passing;
            this.shooting = shooting;
        }

        private void ValidateParameter(params int[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                var parameter = parameters[i];

                if (parameter < 0 || parameter > 100)
                {
                    throw new ArgumentException($"{(PropertyNumber)i} should be between 0 and 100.");
                }
            }
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"A {nameof(this.name)} should not be empty.");
                }

                this.name = value;
            }
        }

        public int Skill()
        {
            return (int)Math.Round((
                this.passing + 
                this.shooting + 
                this.sprint + 
                this.dribble + 
                this.endurance) / 5.0);
        }
    }
}
