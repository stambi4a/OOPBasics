namespace Problem_03.Wild_farm
{
    using System;

    public class WrongFoodException : ArgumentException
    {
        public const string WrongFoodMessage = "{0}s are not eating that type of food!";
        public WrongFoodException(string message)
            : base(message)
        {
            
        }
    }
}
