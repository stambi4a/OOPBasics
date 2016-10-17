namespace Problem_04.Mordors_Cruelty_Plan
{
    using System;

    public class FoodFactory
    {
        public static Food ProduceFood(string foodName)
        {
            try
            {
                var type = Type.GetType("Problem_04.Mordors_Cruelty_Plan." + foodName, true, true);
                var food = Activator.CreateInstance(type) as Food;
                return food;
            }
            catch (TypeLoadException)
            {
                var food = new OtherFood() as Food;
                return food;
            }
        }
    }
}
