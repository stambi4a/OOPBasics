namespace Problem_02.Vehicles_Extension.Models
{
    using System;

    public class Bus : Vehicle
    {
        private const double BusAirConditionerConsumption = 1.4;
        public Bus(double quantity, double consumption, double capaicty)
            : base(quantity, consumption, capaicty)
        {
            
        }

        public override double AirConditionerConsumption => BusAirConditionerConsumption;

        public override double FuelQuantity
        {
            get
            {
                return base.FuelQuantity;
            }

            set
            {
                if (value > base.TankCapacity)
                {
                    throw new ArgumentException("Cannot fit fuel in tank");
                }

                base.FuelQuantity = value;
            }
        }

        public void DriveEmpty(double distance)
        {
            var spentFuel = distance * (this.FuelConsumption - this.AirConditionerConsumption);
            if (spentFuel > this.FuelQuantity)
            {
                Console.WriteLine(NeedsRefuelingMessage, this.GetType().Name);
                return;
            }

            this.FuelQuantity -= spentFuel;
            Console.WriteLine(TravelledMessage, this.GetType().Name, distance);
        }
    }
}
