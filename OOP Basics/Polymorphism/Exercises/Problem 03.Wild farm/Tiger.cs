namespace Problem_03.Wild_farm
{
    using System;

    public class Tiger : Mammal
    {
        public Tiger(string type, string name, double weight, string region)
            : base(type, name, weight, region)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food.GetType() != typeof(Meat))
            {
                throw new WrongFoodException(string.Format(WrongFoodException.WrongFoodMessage, this.AnimalType));
            }

            this.FoodEaten += food.Quantity;
        }
    }
}
