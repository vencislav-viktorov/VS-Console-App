namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public List<Parent> Parents { get; set; }

        public List<Child> Children { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public Car Car { get; set; }

        public Company Company { get; set; }

        public override string ToString()
        {
            var personInfo = new StringBuilder();

            personInfo.AppendLine($"{this.Name}");

            personInfo.AppendLine($"Company:");
            if (this.Company != null) personInfo.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:F2}");

            personInfo.AppendLine($"Car:");
            if (this.Car != null) personInfo.AppendLine($"{this.Car.Model} {this.Car.Speed}");

            personInfo.AppendLine($"Pokemon:");
            if (this.Pokemons.Any()) this.Pokemons.ForEach(p => personInfo.AppendLine($"{p.Name} {p.Type}"));

            personInfo.AppendLine($"Parents:");
            if (this.Parents.Any()) this.Parents.ForEach(p => personInfo.AppendLine($"{p.Name} {p.DateOfBirth}"));

            personInfo.AppendLine($"Children:");
            if (this.Children.Any()) this.Children.ForEach(c => personInfo.AppendLine($"{c.Name} {c.DateOfBirth}"));

            return personInfo.ToString();
        }
    }
}