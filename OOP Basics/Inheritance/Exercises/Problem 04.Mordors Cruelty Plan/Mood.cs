namespace Problem_04.Mordors_Cruelty_Plan
{
    public abstract class Mood
    {
        protected Mood()
        {
            
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
