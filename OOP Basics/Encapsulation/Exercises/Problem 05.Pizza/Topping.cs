namespace Problem_05.Pizza
{
    using System;
    using System.Collections.Generic;

    internal class Topping
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 50;
        private const int BaseModifier = 2;

        private static readonly Dictionary<string, decimal> Modifiers = new Dictionary<string, decimal>(StringComparer.InvariantCultureIgnoreCase)
                                                                   {
                                                                        { "Meat", 1.2m },
                                                                        { "Veggies", 0.8m },
                                                                        { "Cheese", 1.1m },
                                                                        { "Sauce", 0.9m }
                                                                   };

        private int weight;
        private string toppingType;

        internal Topping(int weight, string toppingType)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;
            this.CalculateCalories();
        }

        internal decimal Calories { get; set; }

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
                    throw new ArgumentException($"{this.toppingType} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        internal string ToppingType
        {
            get
            {
                return this.toppingType;
            }

            set
            {
                try
                {
                    Enum.Parse(typeof(ToppingType), value, true);
                }
                catch (ArgumentException)
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.toppingType = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Calories:f2}";
        }

        internal void CalculateCalories()
        {
            this.Calories = this.Weight * BaseModifier * Modifiers[this.toppingType];
        }
    }
}
