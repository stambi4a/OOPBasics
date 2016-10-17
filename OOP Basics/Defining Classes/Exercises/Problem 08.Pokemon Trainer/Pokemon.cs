
namespace Problem_08.Pokemon_Trainer
{
    internal class Pokemon
    {
        private const int PokemonHealthDecrease = 10;
        internal Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }

        internal string Name { get; private set; }

        internal string Element { get; private set; }

        internal int Health { get; set; }

        internal bool CompareElement(string element)
        {
            if (this.Element.Equals(element))
            {
                return true;
            }

            return false;
        }

        internal void DecreaseHealth()
        {
            this.Health -= PokemonHealthDecrease;
        }

        internal bool CheckHealth()
        {
            return this.Health > 0;
        }
    }
}
