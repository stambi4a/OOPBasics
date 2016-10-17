namespace Problem_03.Wild_farm
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string type, string name, double weight, string region)
            : base(type, name, weight)
        {
            this.LivingRegion = region;
        }

        public string LivingRegion { get; protected set; }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
