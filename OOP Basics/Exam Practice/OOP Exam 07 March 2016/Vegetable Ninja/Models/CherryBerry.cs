namespace Vegetable_Ninja.Models
{
    public class CherryBerry : Vegetable
    {
        private const int CherryBerryPower = 0;
        private const int CherryBerryStamina = 10;
        private const char CherryBerryGardenValue = 'C';
        private const int CherryBerryPlayerMovesToRegrow = 5;

        public CherryBerry()
            : base(CherryBerryPower, CherryBerryStamina, CherryBerryGardenValue, CherryBerryGardenValue)
        {
        }
    }
}
