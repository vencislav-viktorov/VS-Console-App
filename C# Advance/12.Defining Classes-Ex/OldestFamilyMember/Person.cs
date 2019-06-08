namespace DefiningClasses
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(int age)
            : this("No name", age)
        {
        }

        public Person()
            : this("No name", 1)
        {
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
