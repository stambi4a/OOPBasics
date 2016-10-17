namespace Problem_05.Pizza
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    internal class Pizza
    {
        private const int MaximalNameLength = 15;
        private const int MaximalToppingsCount = 10;

        private string name;

        internal Pizza(string name, int toppingsCount)
        {
            this.Name = name;
            this.Dough = null;
            this.Toppings = new List<Topping>();
            this.CheckToppingsCount(toppingsCount);
        }

        internal string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > MaximalNameLength)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        internal decimal Calories => this.CalculateCalories();

        internal Dough Dough { get; set; }

        internal ICollection<Topping> Toppings { get; }

        internal void AddTopping(Topping topping)
        {
            this.Toppings.Add(topping);
        }

        internal decimal CalculateCalories()
        {
            var totalCalories = this.Dough.Calories + this.Toppings.Sum(topping => topping.Calories);

            return totalCalories;
        }

        private void CheckToppingsCount(int count)
        {
            if (count > MaximalToppingsCount || count < 0)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Calories:f2} Calories.";
        }
    }
}
