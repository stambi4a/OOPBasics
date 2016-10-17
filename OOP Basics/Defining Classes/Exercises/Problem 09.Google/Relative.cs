namespace Problem_09.Google
{
    using System;

    internal class Relative
    {
        internal Relative(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        internal string Name { get; set; }

        internal string BirthDate { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.BirthDate}{Environment.NewLine}";
        }
    }
}
