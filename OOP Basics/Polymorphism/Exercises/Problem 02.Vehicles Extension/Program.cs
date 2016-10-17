namespace Problem_02.Vehicles_Extension
{
    using System;
    using System.Globalization;
    using System.Reflection;
    using System.Threading;

    using Models;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Car car = null;
            try
            {
                var carInput = Console.ReadLine().Split();
                var fuelQuantity = double.Parse(carInput[1]);
                var fuelConsumption = double.Parse(carInput[2]);
                var tankCapacity = double.Parse(carInput[3]);
                car = new Car(fuelQuantity, fuelConsumption, tankCapacity);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Truck truck = null;
            try
            {
                var truckInput = Console.ReadLine().Split();
                var fuelQuantity = double.Parse(truckInput[1]);
                var fuelConsumption = double.Parse(truckInput[2]);
                var tankCapacity = double.Parse(truckInput[3]);
                truck = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Bus bus = null;
            try
            {
                var busInput = Console.ReadLine().Split();
                var fuelQuantity = double.Parse(busInput[1]);
                var fuelConsumption = double.Parse(busInput[2]);
                var tankCapacity = double.Parse(busInput[3]);
                bus = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            var commandsCount = int.Parse(Console.ReadLine());
            for (var i = 0; i < commandsCount; i++)
            {
                try
                {
                    var commandInput = Console.ReadLine().Split();
                    var command = commandInput[0];
                    var vehicle = commandInput[1];
                    var quantity = double.Parse(commandInput[2]);

                    if (vehicle == "Car")
                    {
                        var method = typeof(Car).GetMethod(command);
                        method.Invoke(car, new object[] { quantity });
                    }
                    if (vehicle == "Truck")
                    {
                        var method = typeof(Truck).GetMethod(command);
                        method.Invoke(truck, new object[] { quantity });
                    }
                    if (vehicle == "Bus")
                    {
                        var method = typeof(Bus).GetMethod(command);
                        method.Invoke(bus, new object[] { quantity });
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                catch (TargetInvocationException tie)
                {
                    Console.WriteLine(tie.InnerException.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
