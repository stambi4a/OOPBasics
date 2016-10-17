namespace Problem_01.Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double TruckAirConditionerConsumption = 1.6;

        private const double TruckFuelMinusLoss = 0.95;
        public Truck(double quantity, double consumption)
            : base(quantity, consumption)
        {
            
        }

        public override double FuelConsumption => base.FuelConsumption + TruckAirConditionerConsumption;

        public override void Refuel(double fuel)
        {
            this.FuelQuantity += TruckFuelMinusLoss * fuel;
        }
    }
}
