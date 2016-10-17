/*
namespace Problem_07.Car_Salesman
{
    using System;

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
*/
