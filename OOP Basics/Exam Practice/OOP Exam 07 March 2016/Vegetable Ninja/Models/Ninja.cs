namespace Vegetable_Ninja.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Interfaces;

    public class Ninja : INinja
    {
        private const int InitialPower = 1;
        private const int InitialStamina = 1;
        private int power;
        private int stamina;

        public Ninja(string name, int power = InitialPower, int stamina = InitialStamina)
        {
            this.Power = power;
            this.Stamina = stamina;
            this.Name = name;
            this.GardenCharValue = name[0];
            this.Vegetables = new List<IVegetable>();
        }

        public ICollection<IVegetable> Vegetables { get; }

        public string Name { get; }

        public char GardenCharValue { get; }

        public int Power
        {
            get
            {
                return this.power;
            }

            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this.power = value;
            }
        }

        public int Stamina
        {
            get
            {
                return this.stamina;
            }

            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this.stamina = value;
            }
        }

        public void CollectVegetable(IVegetable vegetable)
        {
            this.Vegetables.Add(vegetable);
        }

        public void EatVegetables()
        {
            foreach (var vegetable in this.Vegetables)
            {
                this.EatVegetable(vegetable);
            }

            this.Vegetables.Clear();
        }

        public override bool Equals(object obj)
        {
            var otherNinja = obj as INinja;
            return this.GardenCharValue == otherNinja.GardenCharValue;
        }

        public override string ToString()
        {
            var ninjaBuilder = new StringBuilder();
            ninjaBuilder.Append("Winner: ")
                .Append(this.Name)
                .Append(Environment.NewLine)
                .Append("Power: ")
                .Append(this.Power)
                .Append(Environment.NewLine)
                .Append("Stamina: ")
                .Append(this.Stamina);

            return ninjaBuilder.ToString();
        }

        private void EatVegetable(IVegetable vegetable)
        {
            this.Power += vegetable.Power;
            this.Stamina += vegetable.Stamina;
        }
    }
}
