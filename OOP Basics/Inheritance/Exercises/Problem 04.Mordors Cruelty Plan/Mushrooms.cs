namespace Problem_04.Mordors_Cruelty_Plan
{
    public class Mushrooms : Food
    {
        private const int MushroomsHappinessPoints = -10;

        public Mushrooms(int happinessPoints)
            : base(happinessPoints)
        {

        }

        public Mushrooms()
            : this(MushroomsHappinessPoints)
        {
        }
    }
}
