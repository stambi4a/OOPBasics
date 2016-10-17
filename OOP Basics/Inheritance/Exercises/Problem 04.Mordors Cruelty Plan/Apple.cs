namespace Problem_04.Mordors_Cruelty_Plan
{
    public class Apple : Food
    {
        private const int AppleHappinessPoints = 1;

        public Apple(int happinessPoints)
            : base(happinessPoints)
        {

        }

        public Apple()
            : this(AppleHappinessPoints)
        {
        }
    }
}
