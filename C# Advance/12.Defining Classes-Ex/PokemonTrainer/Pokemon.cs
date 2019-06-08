namespace DefiningClasses
{
    public class Pokemon
    {
        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }

        public int Health { get; set; }

        public string Element { get; set; }
        
        public string Name { get; set; }
    }
}