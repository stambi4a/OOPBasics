namespace Vegetable_Ninja.Models
{
    using Vegetable_Ninja.Models.Interfaces;

    public abstract class Vegetable : IVegetable
    {
        protected Vegetable(int power, int stamina, char gardenValue, int playerMoves)
        {
            this.Power = power;
            this.Stamina = stamina;
            this.GardenValue = gardenValue;
            this.PlayerMovesToRegrow = playerMoves;
        }

        public int Stamina { get; protected set; }

        public int Power { get; protected set; }

        public char GardenValue { get; protected set; }

        public int PlayerMovesToRegrow { get; protected set; }
    }
}
