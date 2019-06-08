namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Topping
    {
        private const double baseToppingCalories = 2;

        private string type;
        private double weight;
        private Dictionary<string, double> validTypes;

        public Topping(string type, double weight)
        {
            this.validTypes = new Dictionary<string, double>();
            this.SeedTypes();
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => this.type;

            set
            {
                if (!validTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public double Weight
        {
            get => this.weight;

            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            return baseToppingCalories *
                this.Weight *
                this.validTypes[this.Type.ToLower()];
        }

        private void SeedTypes()
        {
            this.validTypes.Add("meat", 1.2);
            this.validTypes.Add("veggies", 0.8);
            this.validTypes.Add("cheese", 1.1);
            this.validTypes.Add("sauce", 0.9);
        }
    }
}
