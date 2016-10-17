namespace Problem_07.Basic_Math
{
    using System;
    using System.Globalization;
    using System.Reflection;
    using System.Threading;

    public class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var inputParams = input.Split();
                var operation = inputParams[0];
                var firstNumber = double.Parse(inputParams[1]);
                var secondNumber = double.Parse(inputParams[2]);
                var operationMethod = typeof(MathUtil).GetMethod(operation, BindingFlags.Static | BindingFlags.Public);
                operationMethod.Invoke(null, new object[] { firstNumber, secondNumber });
            }         
        }
    }

    public class MathUtil
    {
        private const int MaxPercents = 100;
        public static void Sum(double firstNumber, double secondNumber)
        {
            var sum = firstNumber + secondNumber;
            Console.WriteLine($"{sum:f2}");
        }

        public static void Multiply(double firstNumber, double secondNumber)
        {
            var product = firstNumber * secondNumber;
            Console.WriteLine($"{product:f2}");
        }

        public static void Divide(double firstNumber, double secondNumber)
        {
            var quotient = firstNumber / secondNumber;
            Console.WriteLine($"{quotient:f2}");
        }

        public static void Subtract(double firstNumber, double secondNumber)
        {
            var difference = firstNumber - secondNumber;
            Console.WriteLine($"{difference:f2}");
        }

        public static void Percentage(double firstNumber, double secondNumber)
        {
            var percentage = firstNumber * (secondNumber / MaxPercents);
            Console.WriteLine($"{percentage:f2}");
        }
    }
}
