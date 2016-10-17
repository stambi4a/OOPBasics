namespace Problem_04.Mordors_Cruelty_Plan
{
    public class OtherFood : Food
    {
        private const int OtherFoodHappinessPoints = -1;
        
        public OtherFood(int happinessPoints = OtherFoodHappinessPoints)
            : base(happinessPoints)
        {

        }
    }
}
