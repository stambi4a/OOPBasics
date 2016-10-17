namespace Problem_06.PlanckConstant
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var reducedPlanckConstant = Calculation.GetReducedPlanckConstant();
            Console.WriteLine(reducedPlanckConstant);
        }
    }

    internal class Calculation
    {
        private const double PlanckConstant = 6.62606896e-34d;
        private const double Pi = 3.14159d;

        internal static double GetReducedPlanckConstant()
        {
            return PlanckConstant / (2 * Pi);
        }
    }
}
