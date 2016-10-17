namespace Problem_09.Google
{
    using System;

    internal class Pokemon
    {
        internal Pokemon(string name, string element)
        {
            this.Name = name;
            this.Element = element;
        }

        internal string Name { get; private set; }

        internal string Element { get; private set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Element}{Environment.NewLine}";
        }
    }
}
