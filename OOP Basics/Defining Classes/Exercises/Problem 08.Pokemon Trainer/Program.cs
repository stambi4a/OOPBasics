namespace Problem_08.Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var trainers = new Dictionary<string, Trainer>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Tournament")
                {
                    break;
                }

                var inputParams = input.Split();
                CreatePokemonDatabase(inputParams, trainers);
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                PlayTournament(input, trainers);
            }

            PrintTrainers(trainers);
        }

        private static void PlayTournament(string element, Dictionary<string, Trainer> trainers)
        {
            foreach (var trainer in trainers)
            {
                trainer.Value.CheckForGivenElement(element);
            }
        }

        private static void CreatePokemonDatabase(IReadOnlyList<string> inputParams, Dictionary<string, Trainer> trainers)
        {
            var trainerName = inputParams[0];
            if (!trainers.ContainsKey(trainerName))
            {
                trainers.Add(trainerName, new Trainer(trainerName));
            }

            var pokemonName = inputParams[1];
            var pokemonElement = inputParams[2];
            var pokemonHealth = int.Parse(inputParams[3]);
            var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            trainers[trainerName].AddPokemon(pokemonName, pokemon);
        }

        private static void PrintTrainers(Dictionary<string, Trainer> trainers)
        {
            var rankings = trainers.OrderByDescending(entry => entry.Value.Badges).Select(entry=>entry.Value);
            Console.WriteLine(string.Join(Environment.NewLine, rankings));
        }
    }
}
