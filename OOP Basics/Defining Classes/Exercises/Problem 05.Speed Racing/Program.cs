namespace Problem_05.Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;

    internal class Program
    {

        public const string InsufficientFuel = "Insufficient fuel for the drive";
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var cars = CreateSpeedRacing();
            RaceCars(cars);
            PrintCars(cars.Values);
        }

        private static void PrintCars(IEnumerable<Car> cars)
        {
            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }

        private static Dictionary<string, Car> CreateSpeedRacing()
        {
            var cars = new Dictionary<string, Car>();
            var countCars = int.Parse(Console.ReadLine());
            for (var i = 0; i < countCars; i++)
            {
                var input = Console.ReadLine().Split();
                var model = input[0];
                var fuelCost = decimal.Parse(input[2]);
                var fuelAmount = decimal.Parse(input[1]);
                var car = new Car(model, fuelAmount, fuelCost);
                cars.Add(model, car);
            }

            return cars;
        }

        private static void RaceCars(Dictionary<string, Car> cars)
        {
            while (true)
            {
                var line = Console.ReadLine();
                if (line.Equals("End"))
                {
                    break;
                }

                var input = line.Split();
                var model = input[1];
                var distance = int.Parse(input[2]);
                var car = cars[model];
                var canТraverseDistance = car.TryDriveCar(distance);
                if (!canТraverseDistance)
                {
                    Console.WriteLine(InsufficientFuel);
                }
            }
        }
    }
}
