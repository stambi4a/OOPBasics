namespace Problem_03.Wild_farm
{
    public abstract class Animal
    {
        protected Animal(string type, string name, double weight)
        {
            this.AnimalType = type;
            this.AnimalName = name;
            this.AnimalWeight = weight;
            this.FoodEaten = 0;
        }

        public string AnimalType { get; protected set; }

        public string AnimalName { get; protected set; }

        public double AnimalWeight { get; protected set; }

        public double FoodEaten { get; protected set; }

        public abstract void MakeSound();

        public abstract void Eat(Food food);
    }
}
