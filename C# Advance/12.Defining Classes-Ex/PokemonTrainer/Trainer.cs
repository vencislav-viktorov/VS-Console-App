namespace DefiningClasses
{
    using System.Collections.Generic;

    public class Trainer
    {
        public Trainer(string name, Pokemon pokemon)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.Pokemons = new List<Pokemon>();
            this.Pokemons.Add(pokemon);
        }

        public List<Pokemon> Pokemons { get; set; }

        public int NumberOfBadges { get; set; }
        
        public string Name { get; set; }
    }
}