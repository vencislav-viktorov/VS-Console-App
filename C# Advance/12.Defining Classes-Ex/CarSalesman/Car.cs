namespace DefiningClasses
{
    using System.Text;

    public class Car
    {
        private const string DefaultValueString = "n/a";
        
        public Car(string model, Engine engine, int? weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public Car(string model, Engine engine, int? weight) 
            : this(model, engine, weight, DefaultValueString)
        {
        }

        public Car(string model, Engine engine, string color) 
            : this(model, engine, null, color)
        {
        }

        public Car(string model, Engine engine) 
            : this(model, engine, null, DefaultValueString)
        {
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int? Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            var engineDisDisplacement = this.Engine.Displacement != null ? this.Engine.Displacement.ToString() : "n/a";
            var carWeight = this.Weight != null ? this.Weight.ToString() : "n/a";

            var output = new StringBuilder();

            output.AppendLine($"{this.Model}:");
            output.AppendLine($"  {this.Engine.Model}:");
            output.AppendLine($"    Power: {this.Engine.Power}");
            output.AppendLine($"    Displacement: {engineDisDisplacement}");
            output.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
            output.AppendLine($"  Weight: {carWeight}");
            output.Append($"  Color: {this.Color}");

            return output.ToString();
        }

    }
}