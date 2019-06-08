namespace DefiningClasses
{
    public class Engine
    {
        private const string DefaultValueString = "n/a";

        public Engine(string model, int power, int? displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement) 
            : this(model, power, displacement, DefaultValueString)
        {
        }

        public Engine(string model, int power, string efficiency) 
            : this(model, power, null, efficiency)
        {
        }

        public Engine(string model, int power) 
            : this(model, power, null, DefaultValueString)
        {
        }

        public string Model { get; set; }

        public int Power { get; set; }

        public int? Displacement { get; set; }
        
        public string Efficiency { get; set; }
    }
}