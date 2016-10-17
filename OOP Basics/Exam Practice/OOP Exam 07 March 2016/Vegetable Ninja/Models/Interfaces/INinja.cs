namespace Vegetable_Ninja.Models.Interfaces
{
    public interface INinja : IVegetableConsumer
    {
        int Power { get; }

        int Stamina { get; set; }

        char GardenCharValue { get; }

        string Name { get; }
    }
}
