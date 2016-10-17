namespace Vegetable_Ninja.Models
{
    public class Broccoli : Vegetable
    {
        private const int BroccoliPower = 10;
        private const int BroccoliStamina = 0;
        private const char BroccoliGardenValue = 'B';
        private const int BroccoliPlayerMovesToRegrow = 3;

        public Broccoli()
            : base(BroccoliPower, BroccoliStamina, BroccoliGardenValue, BroccoliPlayerMovesToRegrow)
        {
        }
    }
}