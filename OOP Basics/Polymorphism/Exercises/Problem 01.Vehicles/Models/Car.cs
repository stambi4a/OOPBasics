namespace Problem_01.Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double CarAirConditionerConsumption = 0.9;
        public Car(double quantity, double consumption)
            : base(quantity, consumption)
        {
            
        }

        public override double FuelConsumption => base.FuelConsumption + CarAirConditionerConsumption;
    }
}
