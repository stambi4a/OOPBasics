namespace Problem_04.Mordors_Cruelty_Plan
{
    public abstract class Food
    {
        protected Food(int points)
        {
            this.HappinessPoints = points;
        }

        public int HappinessPoints { get; protected set; }
    }
}
