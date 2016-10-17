namespace Problem_04.Mordors_Cruelty_Plan
{
    public class Cram : Food
    {
        private const int CramHappinessPoints = 2;

        public Cram(int happinessPoints)
            : base(happinessPoints)
        {
            
        }

        public Cram()
            : this(CramHappinessPoints)
        {            
        }
    }
}
