namespace Vegetable_Ninja.Models
{
    public class Mushroom : Vegetable
    {
        private const int MushroomPower = -10;
        private const int MushroomStamina = -10;
        private const char MushroomGardenValue = 'M';
        private const int MushroomPlayerMovesToRegrow = 5;

        public Mushroom()
            : base(MushroomPower, MushroomStamina, MushroomGardenValue, MushroomPlayerMovesToRegrow)
        {
        }
    }
}
