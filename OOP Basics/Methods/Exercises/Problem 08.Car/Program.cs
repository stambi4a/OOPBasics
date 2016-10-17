namespace Problem_08.Car
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var inputParams = Console.ReadLine().Split();
            var speed = decimal.Parse(inputParams[0]);
            var fuel = decimal.Parse(inputParams[1]);
            var fuelEconomy = decimal.Parse(inputParams[2]);
            var car = new Car(speed, fuel, fuelEconomy);
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                inputParams = input.Split();
                if (inputParams.Length == 2)
                {
                    if (inputParams[0] == "Travel")
                    {
                        var distance = decimal.Parse(inputParams[1]);
                        car.Travel(distance);
                    }
                    if (inputParams[0] == "Refuel")
                    {
                        var addedFuel = decimal.Parse(inputParams[1]);
                        car.Refuel(addedFuel);
                    }

                    continue;
                }

                if (input == "Distance")
                {
                    car.GetDistance();
                }

                if (input == "Time")
                {
                    car.GetTime();
                }

                if (input == "Fuel")
                {
                    car.GetFuel();
                }
            }
        }
    }

    internal class Car
    {
        private const string TotalDistance = "Total distance: {0:f1} kilometers";
        private const string TotalTime = "Total time: {0} hours and {1} minutes";
        private const string FuelLeft = "Fuel left: {0:f1} liters";
        private const int EconomyDistance = 100;
        private const int MinutesInAHour = 60;

        internal Car(decimal speed, decimal fuel, decimal fuelEconomy)
        {
            this.Speed = speed;
            this.Fuel = fuel;
            this.FuelEconomy = fuelEconomy;
            this.Distance = 0;
            this.FuelCostPerKilometer = this.FuelEconomy / (decimal)EconomyDistance;
            this.Time = 0;
        }

        internal decimal Speed { get; set; }

        internal decimal Fuel { get; set; }

        internal decimal FuelEconomy { get; set; }

        internal decimal Distance { get; set; }

        internal decimal FuelCostPerKilometer { get; }

        internal decimal Time { get; set; }

        internal void Travel(decimal distance)
        {
            var fuelToUse = this.FuelCostPerKilometer * distance;
            if (fuelToUse > this.Fuel)
            {
                var traveledDistance = this.Fuel / this.FuelCostPerKilometer;
                distance = traveledDistance;
            }

            this.Distance += distance;
            this.Fuel -= distance * this.FuelCostPerKilometer;
            this.Time += (distance / this.Speed);
        }

        internal void Refuel(decimal fuel)
        {
            this.Fuel += fuel;
        }

        internal void GetDistance()
        {
            Console.WriteLine(TotalDistance, this.Distance);
        }

        internal void GetTime()
        {
            var hours = (int)this.Time;
            var minutes = (int)((this.Time - hours) * MinutesInAHour);
            Console.WriteLine(TotalTime, hours, minutes);
        }

        internal void GetFuel()
        {
            Console.WriteLine(FuelLeft, this.Fuel);
        }
    }
}
