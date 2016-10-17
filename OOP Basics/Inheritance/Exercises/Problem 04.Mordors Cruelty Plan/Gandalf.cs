namespace Problem_04.Mordors_Cruelty_Plan
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Gandalf
    {
        private int happinessPoints;

        private Mood mood;

        public Gandalf(ICollection<Food> foods)
        {
            this.CalculateHappinessPoints(foods);
            this.CreateMood();
        }

        private void CalculateHappinessPoints(ICollection<Food> foods)
        {
            this.happinessPoints = foods.Sum(food => food.HappinessPoints);
        }

        private void CreateMood()
        {
            this.mood = MoodFactory.CreateMood(this.happinessPoints);
        }

        public override string ToString()
        {
            return $"{this.happinessPoints}{Environment.NewLine}{this.mood}";
        }
    }
}
