namespace Problem_01.Vehicles.Models
{
    using System;
    using Interfaces;

    public abstract class Vehicle : IVehicle
    {
        private const string NeedsRefuelingMessage = "{0} needs refueling";
        private const string TravelledMessage = "{0} travelled {1} km";
        protected Vehicle(double quantity, double consumption)
        {
            this.FuelQuantity = quantity;
            this.FuelConsumption = consumption;
        }

        public double FuelQuantity { get; protected set; }

        public virtual double FuelConsumption { get; protected set; }

        public virtual void Refuel(double fuel)
        {
            this.FuelQuantity += fuel;
        }

        public virtual void Drive(double distance)
        {
            var spentFuel = distance * this.FuelConsumption;
            if (spentFuel > this.FuelQuantity)
            {
                Console.WriteLine(NeedsRefuelingMessage, this.GetType().Name);
                return;
            }

            this.FuelQuantity -= spentFuel;
            Console.WriteLine(TravelledMessage, this.GetType().Name, distance);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
