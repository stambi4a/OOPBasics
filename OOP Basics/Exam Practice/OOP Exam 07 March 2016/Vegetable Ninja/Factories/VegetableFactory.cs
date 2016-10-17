namespace Vegetable_Ninja.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Models.Interfaces;

    using Vegetable_Ninja.Models;

    public class VegetableFactory
    {
        public static IVegetable CreateVegetable(char gardenValue)
        {
            if (gardenValue == Garden.BlankSpaceGardenValue)
            {
                return null;
            }

            string vegetableNamespace = "Vegetable_Ninja.Models";
            var type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t=>t.IsClass && t.Namespace == vegetableNamespace && t.Name.StartsWith(new string(gardenValue, 1)));

            var vegetable = (IVegetable)(Activator.CreateInstance(type));

            return vegetable;
        }
    }
}
