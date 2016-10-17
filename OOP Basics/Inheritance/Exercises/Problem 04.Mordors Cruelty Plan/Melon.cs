namespace Problem_04.Mordors_Cruelty_Plan
{
    public class Melon : Food
    {
        private const int MelonHappinessPoints = 1;

        public Melon(int happinessPoints)
            : base(happinessPoints)
        {

        }

        public Melon()
            : this(MelonHappinessPoints)
        {
        }
    }
}
