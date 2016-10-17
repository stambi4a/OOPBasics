namespace Problem_02.Vehicles_Extension.Models
{
    using System;

    public class Car : Vehicle
    {
        private const double CarAirConditionerConsumption = 0.9;
        public Car(double quantity, double consumption, double capacity)
            : base(quantity, consumption, capacity)
        {
            
        }

        public override double AirConditionerConsumption => CarAirConditionerConsumption;

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
    }
}
