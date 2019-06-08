namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
           var trainers = new List<Trainer>();

            var command = Console.ReadLine();

            while (command != "Tournament")
            {
                var tokens = command
                    .Split();

                var trainer = tokens[0];
                var name = tokens[1];
                var elementPower = tokens[2];
                var healt = int.Parse(tokens[3]);

                var currentPokemon = new Pokemon(name, elementPower, healt);

                if (trainers.Any(t => t.Name == trainer))
                {
                    trainers
                        .Find(t => t.Name == trainer)
                        .Pokemons
                        .Add(currentPokemon);
                }

                else
                {
                    trainers
                        .Add(new Trainer(trainer, currentPokemon));
                }

                command = Console.ReadLine();
            }

            var element = Console.ReadLine();

            while (element != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.NumberOfBadges++;
                    }

                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health -= 10);

                        trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }

                element = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}