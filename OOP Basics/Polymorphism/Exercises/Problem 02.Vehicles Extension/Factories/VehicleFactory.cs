namespace Problem_02.Vehicles_Extension.Factories
{
    using System;

    using Problem_02.Vehicles_Extension.Interfaces;

    public class VehicleFactory
    {
        public IVehicle ProduceVehicle(string[] vehicleParameters)
        {
            var vehicleName = vehicleParameters[0];
            var type = Type.GetType(vehicleName);
            var quantity = double.Parse(vehicleParameters[1]);
            var consumption = double.Parse(vehicleParameters[2]);

            var vehicle = (IVehicle)Activator.CreateInstance(type, quantity, consumption);
            return vehicle;
        }
    }
}
