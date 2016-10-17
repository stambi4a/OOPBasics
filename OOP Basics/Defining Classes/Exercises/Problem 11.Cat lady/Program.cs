namespace Problem_11.Cat_lady
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;

    public class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var cats = new Dictionary<string, Cat>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var inputParams = input.Split();
                FullfillCatDatabase(inputParams, cats);
            }

            var catToPrint = Console.ReadLine();
            Console.WriteLine(cats[catToPrint]);
        }

        private static void FullfillCatDatabase(IReadOnlyList<string> inputParams, Dictionary<string, Cat> cats)
        {
            var catName = inputParams[1];
            var catType = inputParams[0];
            var type = Type.GetType("Problem_11.Cat_lady." + catType);
            var intMeasure = 0;
            var measure = int.TryParse(inputParams[2], out intMeasure) ? int.Parse(inputParams[2]) : double.Parse(inputParams[2]);
            var cat = Activator.CreateInstance(type, catName, double.Parse(inputParams[2])) as Cat;
            cats.Add(catName, cat);
        }
    }
}
