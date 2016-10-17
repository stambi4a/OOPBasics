namespace Problem_09.Google
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Person
    {
        internal Person(string name)
        {
            this.Name = name;
            this.Car = null;
            this.WorkPlace = null;
            this.Pokemons = new HashSet<Pokemon>();
            this.Parents = new Dictionary<string, Relative>();
            this.Children = new Dictionary<string, Relative>();
        }

        internal string Name { get; }

        internal WorkPlace WorkPlace { get; set; }

        internal Car Car { get; set; }

        internal ISet<Pokemon> Pokemons { get; }

        internal IDictionary<string, Relative> Parents { get; }

        internal IDictionary<string, Relative> Children { get; }

        internal void ChangeCar(Car car)
        {
            this.Car = car;
        }

        internal void ChangeWorkPlace(WorkPlace workPlace)
        {
            this.WorkPlace = workPlace;
        }

        internal void AddPokemon(Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }

        internal void AddParent(string name, Relative parent)
        {
            if (!this.Parents.ContainsKey(name) && !this.Children.ContainsKey(name))
            {
                this.Parents.Add(name, parent);
            }
        }

        internal void AddChild(string name, Relative child)
        {
            if (!this.Children.ContainsKey(name) && !this.Parents.ContainsKey(name))
            {
                this.Children.Add(name, child);
            }
        }

        internal void GetCar(Car car)
        {
            this.Car = car;
        }

        internal void GetWorkPlace(WorkPlace workPlace)
        {
            this.WorkPlace = workPlace;
        }

        public override string ToString()
        {
            var personBuilder = new StringBuilder();
            personBuilder.Append(this.Name + Environment.NewLine);
            personBuilder.Append("Company: " + Environment.NewLine + this.WorkPlace);
            personBuilder.Append("Car: " + Environment.NewLine + this.Car);
            personBuilder.Append("Pokemon: " + Environment.NewLine + string.Join(string.Empty, this.Pokemons));
            personBuilder.Append("Parents: " + Environment.NewLine + string.Join(string.Empty, this.Parents.Values));
            personBuilder.Append("Children: " + Environment.NewLine + string.Join(string.Empty, this.Children.Values));

            return personBuilder.ToString();
        }
    }
}
