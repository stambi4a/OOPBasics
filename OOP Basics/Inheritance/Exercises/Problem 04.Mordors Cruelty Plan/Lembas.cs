namespace Problem_04.Mordors_Cruelty_Plan
{
    public class Lembas : Food
    {
        private const int LembasHappinessPoints = 3;

        public Lembas(int happinessPoints)
            : base(happinessPoints)
        {

        }

        public Lembas()
            : this(LembasHappinessPoints)
        {
        }
    }
}
