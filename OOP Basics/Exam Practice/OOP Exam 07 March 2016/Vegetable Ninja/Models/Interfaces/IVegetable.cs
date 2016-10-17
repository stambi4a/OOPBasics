namespace Vegetable_Ninja.Models.Interfaces
{
    public interface IVegetable
    {
        int Power { get; }

        int Stamina { get; }

        char GardenValue { get; }

        int PlayerMovesToRegrow { get; }
    }
}
