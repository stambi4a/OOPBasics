namespace Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    internal class Program
    {
        private const int CountOfTyresInACar = 4;
        private const int EnginePowerCompareValue = 250;

        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var cars = CreateCarDatabase();
            var cargoTypeFilter = Console.ReadLine();
            var carsWithCertainParameters = FindCarsWithParameters(cargoTypeFilter, cars);
            PrintFoundCars(carsWithCertainParameters);
        }

        private static void PrintFoundCars(IEnumerable<string> carModels)
        {
            Console.WriteLine(string.Join(Environment.NewLine, carModels));
        }

        private static Dictionary<string, Car> CreateCarDatabase()
        {
            var cars = new Dictionary<string, Car>();
            var countCars = int.Parse(Console.ReadLine());
            for (var i = 0; i < countCars; i++)
            {
                var input = Console.ReadLine().Split();
                var model = input[0];
                var engineSpeed = int.Parse(input[1]);
                var enginePower = int.Parse(input[2]);
                var engine = new Engine(engineSpeed, enginePower);

                var cargoWeight = int.Parse(input[3]);
                var cargoType = input[4];
                var cargo = new Cargo(cargoType, cargoWeight);

                var tyres = new Tyre[CountOfTyresInACar];
                var firstTyrePressure = double.Parse(input[5]);
                var firstTyreAge= int.Parse(input[6]);
                tyres[0] = new Tyre(firstTyreAge, firstTyrePressure);
                var secondTyrePressure = double.Parse(input[7]);
                var secondTyreAge = int.Parse(input[8]);
                tyres[1] = new Tyre(secondTyreAge, secondTyrePressure);
                var thirdTyrePressure = double.Parse(input[9]);
                var fourthTyreAge = int.Parse(input[10]);
                tyres[2] = new Tyre(fourthTyreAge, thirdTyrePressure);
                var fifthTyrePressure = double.Parse(input[11]);
                var sixthTyreAge = int.Parse(input[12]);
                tyres[3] = new Tyre(sixthTyreAge, fifthTyrePressure);

                var car = new Car(model, engine, cargo, tyres);
                cars.Add(model, car);
            }

            return cars;
        }

        private static IEnumerable<string> FindCarsWithParameters(string cargoType, Dictionary<string, Car> cars)
        {
            if (cargoType == "flamable")
            {
                return cars.Where(car => car.Value.Cargo.Type == cargoType && car.Value.Engine.Power > EnginePowerCompareValue)
                    .Select(car=>car.Key);
            }

            return
                cars.Where(car => car.Value.Cargo.Type == cargoType && car.Value.Tyres.Any(tyre => tyre.Pressure < 1))
                    .Select(car => car.Key);
        }
    }
}
