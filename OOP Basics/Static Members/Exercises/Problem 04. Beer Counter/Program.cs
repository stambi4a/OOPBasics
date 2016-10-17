namespace Problem_04.Beer_Counter
{
    using System;
    using System.Dynamic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var inputParams = input.Split();
                var boughtCount = int.Parse(inputParams[0]);
                var drankCount = int.Parse(inputParams[1]);
                BeerCounter.BuyBeer(boughtCount);
                BeerCounter.DrinkBeer(drankCount);
            }

            Console.WriteLine(BeerCounter.BeersInStock + " " + BeerCounter.BeersDrankCount);
        }
    }

    internal class BeerCounter
    {
        internal BeerCounter()
        {
            
        }

        internal static int BeersDrankCount { get; set; }

        internal static int BeersInStock { get; set; }

        internal static void BuyBeer(int count)
        {
            BeersInStock += count;
        }

        internal static void DrinkBeer(int count)
        {
            BeersDrankCount += BeersInStock >= count ? count : BeersInStock;
            BeersInStock -= BeersInStock >= count ? count : BeersInStock;
        }
    }
}
