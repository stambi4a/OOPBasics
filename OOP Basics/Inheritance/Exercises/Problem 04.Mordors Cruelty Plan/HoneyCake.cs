namespace Problem_04.Mordors_Cruelty_Plan
{
    public class HoneyCake : Food
    {
        private const int HoneyCakeHappinessPoints = 5;

        public HoneyCake(int happinessPoints)
            : base(happinessPoints)
        {

        }

        public HoneyCake()
            : this(HoneyCakeHappinessPoints)
        {
        }
    }
}
