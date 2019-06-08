namespace PetClinic
{
    public class Pet
    {
        private int age;
        private string kind;

        public Pet(string name, int age, string kind)
        {
            this.Name = name;
            this.age = age;
            this.kind = kind;
        }

        public string Name { get; }

        public override string ToString()
        {
            return $"{this.Name} {this.age} {this.kind}";
        }
    }
}