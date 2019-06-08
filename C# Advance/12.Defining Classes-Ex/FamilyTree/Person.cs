namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Person
    {
        public Person(string name, string dateOfBirth)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.Parents = new List<Person>();
            this.Children = new List<Person>();
        }

        public List<Person> Children { get; set; }

        public List<Person> Parents { get; set; }

        public string DateOfBirth { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            var personInfo = new StringBuilder();

            personInfo.AppendLine($"{this.Name} {this.DateOfBirth}");

            personInfo.AppendLine($"Parents:");
            if (this.Parents.Any()) Parents.ForEach(p => personInfo.AppendLine($"{p.Name} {p.DateOfBirth}"));

            personInfo.AppendLine($"Children:");
            if (this.Children.Any()) Children.ForEach(c => personInfo.AppendLine($"{c.Name} {c.DateOfBirth}"));

            return personInfo.ToString();
        }
    }
}