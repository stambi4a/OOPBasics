namespace Vegetable_Ninja.Models
{
    public class Asparagus : Vegetable
    {
        private const int AsparagusPower = 5;
        private const int AsparagusStamina = -5;
        private const char AsparagusGardenValue = 'A';
        private const int AsparagusPlayerMovesToRegrow = 2;

        public Asparagus()
            : base(AsparagusPower, AsparagusStamina, AsparagusGardenValue, AsparagusPlayerMovesToRegrow)
        {
        }
    }
}
