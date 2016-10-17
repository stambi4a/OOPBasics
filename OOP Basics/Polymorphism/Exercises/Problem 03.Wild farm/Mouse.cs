namespace Problem_03.Wild_farm
{
    using System;

    public class Mouse : Mammal
    {
        public Mouse(string type, string name, double weight, string region)
            : base(type, name, weight, region)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
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
