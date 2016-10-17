namespace Vegetable_Ninja.Models
{
    public class Royal : Vegetable
    {
        private const int RoyalPower = 20;
        private const int RoyalStamina= 10;
        private const char RoyalGardenValue = 'R';
        private const int RoyalPlayerMovesToRegrow = 10;

        public Royal()
            : base(RoyalPower, RoyalStamina, RoyalGardenValue, RoyalPlayerMovesToRegrow)
        {
        }
    }
}
