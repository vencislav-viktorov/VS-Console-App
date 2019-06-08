namespace DefiningClasses
{
    public class Parent
    {
        public Parent(string name, string dateOfBirth)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
        }

        public string Name { get; set; }

        public string DateOfBirth { get; set; }
    }
}