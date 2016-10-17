namespace Problem_04.Mordors_Cruelty_Plan
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int bufSize = 1024;
            Stream inStream = Console.OpenStandardInput(bufSize);
            Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufSize));

            var input = Console.ReadLine().ToLower();
            var foodInput = Regex.Split(input, "[^a-z]+").Where(foodName => !string.IsNullOrEmpty(foodName));
            ICollection<Food> foods = foodInput.Select(FoodFactory.ProduceFood).ToList();
            var gandalf = new Gandalf(foods);
            Console.WriteLine(gandalf);
        }
    }
}
