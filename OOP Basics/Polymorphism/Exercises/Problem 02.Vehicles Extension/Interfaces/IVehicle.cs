namespace Problem_02.Vehicles_Extension.Interfaces
{
    public interface IVehicle : IDriveable, IRefuelable
    {
        double FuelQuantity { get; }

        double FuelConsumption { get; }

        double TankCapacity { get; }
    }
}
