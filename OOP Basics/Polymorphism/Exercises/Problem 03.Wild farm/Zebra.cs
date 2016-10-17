namespace Problem_03.Wild_farm
{
    using System;

    public class Zebra : Mammal
    {
        public Zebra(string type, string name, double weight, string region)
            : base(type, name, weight, region)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Zs");
        }

        public override void Eat(Food food)
        {
            if (food.GetType() != typeof(Vegetable))
            {
                throw new WrongFoodException(string.Format(WrongFoodException.WrongFoodMessage, this.AnimalType));
            }

            this.FoodEaten += food.Quantity;
        }
    }
}
