using System;
using System.Collections.Generic;
using System.Linq;

public class PokemonTrainer
{
    public static void Main()
    {
        string input = Console.ReadLine();

        var trainers = new List<Trainer>();

        while (input != "Tournament")
        {
            var currentLine = input.Split();

            var trainerName = currentLine[0];
            var pokemonName = currentLine[1];
            var pokemonElement = currentLine[2];
            var pokemonHealth = int.Parse(currentLine[3]);

            var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

            var trainer = trainers.FirstOrDefault(t => t.Name == trainerName);

            if (trainer == null)
            {
                trainer = new Trainer(trainerName);
                trainers.Add(trainer);
            }

            trainer.Pokemons.Add(pokemon);

            input = Console.ReadLine();
        }

        var command = Console.ReadLine();

        while (command != "End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(p => p.Element == command))
                {
                    trainer.BadgesNum++;
                }
                else
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }

                    var killedPokemons = trainer.Pokemons.Where(p => p.Health <= 0).ToList();

                    foreach (var pokemon in killedPokemons)
                    {
                        trainer.Pokemons.Remove(pokemon);
                    }
                }
            }

            command = Console.ReadLine();
        }

        foreach (var trainer in trainers.OrderByDescending(t => t.BadgesNum))
        {
            Console.WriteLine(trainer.ToString());
        }
    }
}