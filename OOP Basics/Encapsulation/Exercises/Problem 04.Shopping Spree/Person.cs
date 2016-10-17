namespace Problem_04.Shopping_Spree
{
    using System;
    using System.Collections.Generic;

    internal class Person
    {
        private const string BoughtMessage = "{0} bought {1}";
        private const string CannotAffordMessage = "{0} can't afford {1}";
        private const string NothingBoughtMessage = "Nothing bought";

        private string name;
        private int money;

        internal Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>();
        }

        internal ICollection<Product> Products { get; }

        internal string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        internal int Money
        {
            get
            {
                return this.money;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        internal void TryBuyProduct(Product product)
        {
            if (this.Money < product.Price)
            {
                Console.WriteLine(CannotAffordMessage, this.Name, product.Name);
                return;
            }

            this.Money -= product.Price;
            this.Products.Add(product);
            Console.WriteLine(BoughtMessage, this.Name, product.Name);
        }

        internal void PrintPurchases()
        {
            var productsMessage = this.Products.Count > 0 ? string.Join(", ", this.Products) : NothingBoughtMessage;
            Console.WriteLine($"{this.Name} - {productsMessage}");
        }
    }
}
