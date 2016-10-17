namespace Problem_01.Vehicles
{
    using System;
    using System.Globalization;
    using System.Threading;

    using Models;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var carInput = Console.ReadLine().Split();
            var fuelQuantity = double.Parse(carInput[1]);
            var fuelConsumption = double.Parse(carInput[2]);
            var car = new Car(fuelQuantity, fuelConsumption);

            var truckInput = Console.ReadLine().Split();
            fuelQuantity = double.Parse(truckInput[1]);
            fuelConsumption = double.Parse(truckInput[2]);
            var truck = new Truck(fuelQuantity, fuelConsumption);

            var commandsCount = int.Parse(Console.ReadLine());
            for (var i = 0; i < commandsCount; i++)
            {
                var commandInput = Console.ReadLine().Split();
                var command = commandInput[0];
                var vehicle = commandInput[1];
                var quantity = double.Parse(commandInput[2]);

                var method = typeof(Vehicle).GetMethod(command);
                if (vehicle =="Car")
                {
                    method.Invoke(car, new object[] { quantity });
                }
                else
                {
                    method.Invoke(truck, new object[] { quantity });
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
