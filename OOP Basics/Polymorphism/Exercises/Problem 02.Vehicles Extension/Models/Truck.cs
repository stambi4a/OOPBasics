namespace Problem_02.Vehicles_Extension.Models
{
    public class Truck : Vehicle
    {
        private const double TruckAirConditionerConsumption = 1.6;
        private const double TruckFuelMinusLoss = 0.95;

        public Truck(double quantity, double consumption, double capacity)
            : base(quantity, consumption, capacity)
        {
            
        }

        public override double AirConditionerConsumption => TruckAirConditionerConsumption;

        public override void Refuel(double fuel)
        {
            this.FuelQuantity += TruckFuelMinusLoss * fuel;
        }
    }
}
