namespace Problem_01.Vehicles.Interfaces
{
    public interface IVehicle : IDriveable, IRefuelable
    {
        double FuelQuantity { get; }

        double FuelConsumption { get; }
    }
}
