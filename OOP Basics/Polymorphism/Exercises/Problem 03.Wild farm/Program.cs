namespace Problem_03.Wild_farm
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var animalInput = input.Split();
                var animalType = animalInput[0];
                var animalName = animalInput[1];
                var animalWeight = double.Parse(animalInput[2]);
                var region = animalInput[3];

                var constructorParameters = new List<object> { animalType, animalName, animalWeight, region };
                if (animalInput.Length == 5)
                {
                    var breed = animalInput[4];
                    constructorParameters.Add(breed);
                }

                var type = Type.GetType("Problem_03.Wild_farm." + animalType);
                var animal = (Mammal)Activator.CreateInstance(type, constructorParameters.ToArray());

                var foodInput = Console.ReadLine().Split();
                var foodType = foodInput[0];
                var foodQuantity = int.Parse(foodInput[1]);
                type = Type.GetType("Problem_03.Wild_farm." + foodType);
                var food = (Food)Activator.CreateInstance(type, foodQuantity);

                animal.MakeSound();
                try
                {
                    animal.Eat(food);
                }
                catch (WrongFoodException wfe)
                {
                    Console.WriteLine(wfe.Message);
                }

                Console.WriteLine(animal);
            }
        }
    }
}
