namespace Problem_04.Shopping_Spree
{
    using System;

    internal class Product
    {
        private string name;
        private int price;

        internal Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

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

        internal int Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
