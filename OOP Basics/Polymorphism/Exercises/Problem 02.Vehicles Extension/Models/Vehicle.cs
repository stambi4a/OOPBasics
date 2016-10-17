namespace Problem_02.Vehicles_Extension.Models
{
    using System;

    using Problem_02.Vehicles_Extension.Interfaces;

    public abstract class Vehicle : IVehicle
    {
        protected const string NeedsRefuelingMessage = "{0} needs refueling";
        protected const string TravelledMessage = "{0} travelled {1} km";

        private double fuelQuantity;
        protected Vehicle(double quantity, double consumption, double capacity)
        {
            this.TankCapacity = capacity;
            this.FuelQuantity = quantity;
            this.FuelConsumption = consumption + this.AirConditionerConsumption;
        }

        public virtual double AirConditionerConsumption { get; protected set; }
        public double TankCapacity { get; set; }

        public virtual double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }

                this.fuelQuantity = value;
            }
        }

        public virtual double FuelConsumption { get; protected set; }

        public virtual void Refuel(double fuel)
        {
            try
            {
                this.FuelQuantity += fuel;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            
        }

        public void Drive(double distance)
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
