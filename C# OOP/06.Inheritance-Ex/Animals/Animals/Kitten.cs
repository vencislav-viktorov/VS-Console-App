namespace Animals
{
    public class Kitten : Animal
    {
        public Kitten(string name, int age, string gender)
            : base(name, age, gender)
        {
            this.Gender = "Female";
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}