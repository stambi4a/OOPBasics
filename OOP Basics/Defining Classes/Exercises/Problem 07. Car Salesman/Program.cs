namespace Problem_07.Car_Salesman
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var engines = CreateEngineDatabase();
            var cars = CreateCarDatabase(engines);
            PrintCarsFromDatabase(cars);
        }

        private static Dictionary<string, Engine> CreateEngineDatabase()
        {
            var engines = new Dictionary<string, Engine>();
            var engineCount = int.Parse(Console.ReadLine());
            for (var i = 0; i < engineCount; i++)
            {
                var input = Console.ReadLine().Trim().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var model = input[0];
                var power = int.Parse(input[1]);
                var displacement = 0;
                string efficiency = null;
                if (input.Length == 3)
                {
                    if (!int.TryParse(input[2], out displacement))
                    {
                        efficiency = input[2];
                    }
                }

                if (input.Length == 4)
                {
                    displacement = int.Parse(input[2]);
                    efficiency = input[3];                  
                }

                if (engines.ContainsKey(model))
                {
                    continue;
                }

                var engine = new Engine(model, power, displacement, efficiency);
                engines.Add(model, engine);
            }

            return engines;
        }

        private static List<Car> CreateCarDatabase(Dictionary<string, Engine> engines)
        {
            var cars = new List<Car>();
            var carCount = int.Parse(Console.ReadLine());
            for (var i = 0; i < carCount; i++)
            {
                var input = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = input[0];
                var engineModel = input[1];
                var engine = engines.ContainsKey(engineModel) ? engines[engineModel] : null;
                var weight = 0;
                string color = null;
                if (input.Length == 3)
                {
                    if (!int.TryParse(input[2], out weight))
                    {
                        color = input[2];
                    }
                }

                if (input.Length == 4)
                {
                    weight =  int.Parse(input[2]);
                    color = input[3];
                }

                var car = new Car(model, engine, weight, color);
                cars.Add(car);
            }

            return cars;
        }

        private static void PrintCarsFromDatabase(List<Car> cars)
        {
            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }

    internal class Car
    {
        internal Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        internal string Model { get; set; }

        internal Engine Engine { get; set; }

        internal int Weight { get; set; }

        internal string Color { get; set; }

        public override string ToString()
        {
            var weight = this.Weight > 0 ? this.Weight.ToString() : "n/a";
            var color = this.Color ?? "n/a";

            return $"{this.Model}:{Environment.NewLine}  {this.Engine}{Environment.NewLine}  Weight: {weight}{Environment.NewLine}  Color: {color}";
        }
    }

    internal class Engine
    {
        internal Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }

        public override string ToString()
        {
            var displacement = this.Displacement > 0 ? this.Displacement.ToString() : "n/a";
            var efficiency = this.Efficiency ?? "n/a";
            return $"{this.Model}: {Environment.NewLine}    Power: {this.Power}{Environment.NewLine}    Displacement: {displacement}{Environment.NewLine}    Efficiency: {efficiency}";
        }
    }
}
