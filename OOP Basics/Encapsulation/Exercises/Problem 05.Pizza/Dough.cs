namespace Problem_05.Pizza
{
    using System;
    using System.Collections.Generic;

    internal class Dough
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 200;
        private const int BaseModifier = 2;

        private static readonly Dictionary<string, decimal> Modifiers = new Dictionary<string, decimal>(StringComparer.InvariantCultureIgnoreCase)
                                                                   {
                                                                        { "White", 1.5m },
                                                                        { "Wholegrain", 1.0m },
                                                                        { "Crispy", 0.9m },
                                                                        { "Chewy", 1.1m },
                                                                        { "Homemade", 1.0m }
                                                                   };

        private int weight;
        private string flourType;
        private string bakingTechnique;

        internal Dough(int weight, string flourType, string bakingTechnique)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
            this.CalculateCalories();
        }

        internal decimal Calories { get; set; }
        internal string FlourType
        {
            get
            {
                return this.flourType;
            }

            set
            {
                try
                {
                    Enum.Parse(typeof(FlourType), value, true);
                }
                catch (ArgumentException)
                {
                   throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        internal string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }

            set
            {
                try
                {
                    Enum.Parse(typeof(BakingTechnique), value, true);
                }
                catch (ArgumentException)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        internal int Weight
        {
            get
            {
                return this.weight;
            }

            set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Calories:f2}";
        }

        internal void CalculateCalories()
        {
            this.Calories = this.Weight * BaseModifier * Modifiers[this.flourType] * Modifiers[this.bakingTechnique];
        }
    }
}
