namespace Problem_08.Pokemon_Trainer
{
    using System.Collections.Generic;
    using System.Linq;

    internal class Trainer
    {
        internal Trainer(string name)
        {
            this.Name = name;
            this.Pokemons = new Dictionary<string, Pokemon>();
            this.Badges = 0;
        }

        internal string Name { get; private set; }

        internal int Badges { get; set; }

        internal IDictionary<string, Pokemon> Pokemons { get; set; }

        internal void AddPokemon(string pokemonName, Pokemon pokemon)
        {
            this.Pokemons.Add(pokemonName, pokemon);
        }

        internal void CheckForGivenElement(string element)
        {
            if (this.Pokemons.Any(entry => entry.Value.CompareElement(element)))
            {
                this.Badges++;
                return;
            }

            var pokemonsToRemove = new List<string>();
            foreach (var pokemon in this.Pokemons)
            {
                pokemon.Value.DecreaseHealth();
                if (!pokemon.Value.CheckHealth())
                {
                    pokemonsToRemove.Add(pokemon.Key);
                }
            }

            foreach (var pokemon in pokemonsToRemove)
            {
                this.Pokemons.Remove(pokemon);
            }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Badges} {this.Pokemons.Count}";
        }
    }
}
