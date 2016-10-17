namespace Problem_05.Speed_Racing
{
    public class Car
    {
        public Car(string model, decimal fuelAmount, decimal fuelCost)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelCostPerKilometer = fuelCost;
            this.DistanceTraveled = 0;
        }

        public string Model { get; set; }
        public decimal FuelAmount { get; set; }
        public decimal FuelCostPerKilometer { get; set; }
        public int DistanceTraveled { get; set; }

        public bool TryDriveCar(int distance)
        {
            var usedFuel = distance * this.FuelCostPerKilometer;

            if (this.FuelAmount < usedFuel)
            {
                return false;
            }

            this.FuelAmount -= usedFuel;
            this.DistanceTraveled += distance;

            return true;
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.DistanceTraveled}";
        }
    }
}
