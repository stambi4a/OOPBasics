namespace Kermen.Models
{
    using System.Collections.Generic;

    using Kermen.Models.Interfaces;

    public class Child : Person, IToyPlayer, IGrowable
    {
        public Child(IEnumerable<Toy> toys, double foodCost)
        {
            this.CostPerMonth = foodCost;
            this.Toys = toys;
        }

        public double CostPerMonth { get; }

        public IEnumerable<Toy> Toys { get; }
    }
}
