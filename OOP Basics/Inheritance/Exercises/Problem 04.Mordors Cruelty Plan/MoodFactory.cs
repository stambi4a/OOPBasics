namespace Problem_04.Mordors_Cruelty_Plan
{
    public class MoodFactory
    {
        private const int SadMinValue = -5;
        private const int HappyMinValue = 0;
        private const int HappyMaxValue = 15;

        public static Mood CreateMood(int happinessPoints)
        {
            if (happinessPoints < -5)
            {
                return new Angry();
            }

            if (happinessPoints >= -5 && happinessPoints < 0)
            {
                return new Sad();
            }

            if (happinessPoints >= 0 && happinessPoints <= 15)
            {
                return new Happy();
            }

            return new JavaScript();
        }
    }
}
