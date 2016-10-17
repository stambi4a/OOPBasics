namespace Problem_05.Fibonacci
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var fibonacci = new Fibonacci();
            var startPosition = int.Parse(Console.ReadLine());
            var endPosition = int.Parse(Console.ReadLine());
            var fibonacciList = fibonacci.GetFibonacciNumbersInRange(startPosition, endPosition);
            Console.WriteLine(string.Join(", ", fibonacciList));
        }
    }

    internal class Fibonacci
    {
        internal List<BigInteger> GetFibonacciNumbersInRange(int startIndex, int endIndex)
        {
            var fibonacciNumber = new List<BigInteger>();
            if (startIndex == 0 && endIndex > 0)
            {
                fibonacciNumber.Add(0);
            }

            if (startIndex <= 1 && endIndex > 1)
            {
                fibonacciNumber.Add(1);
            }

            BigInteger firstFibonacci = 0;
            BigInteger secondFibonacci = 1;
            var index = 2;
            while (index < startIndex)
            {
                secondFibonacci += firstFibonacci;
                firstFibonacci = secondFibonacci - firstFibonacci;
                index++;
            }

            while (index < endIndex)
            {
                secondFibonacci += firstFibonacci;
                firstFibonacci = secondFibonacci - firstFibonacci;
                fibonacciNumber.Add(secondFibonacci);
                index++;
            }

            return fibonacciNumber;
        }
    }
}
