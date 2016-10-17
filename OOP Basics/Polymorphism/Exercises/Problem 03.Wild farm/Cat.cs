namespace Problem_03.Wild_farm
{
    using System;

    public class Cat : Mammal
    {
        public Cat(string type, string name, double weight, string region, string breed)
            : base(type, name, weight, region)
        {
            this.Breed = breed;
        }

        public string Breed { get; }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
