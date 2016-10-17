/*
namespace Problem_07.Car_Salesman
{
    using System;

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
}
*/
