namespace Problem_03.Temperature_converter
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                var input = line.Split();
                var units = int.Parse(input[0]);
                var measure = input[1];
                if (measure == "Celsius")
                {
                    Converter.ConvertToFahrenheit(units);
                    continue;
                }

                Converter.ConvertToCelsius(units);
            } 
        }
    }

    internal class Converter
    {
        private const decimal OneCelsiusInFahrenheit = 1.8m;
        private const int FahnrenheitBase = 32;
       
        internal static void ConvertToCelsius(int units)
        {
            var celsius = (units - FahnrenheitBase) / OneCelsiusInFahrenheit;
            Console.WriteLine($"{celsius:f2} Celsius");
        }

        internal static void ConvertToFahrenheit(int units)
        {
            var fahrenheits = units * OneCelsiusInFahrenheit + FahnrenheitBase;
            Console.WriteLine($"{fahrenheits:f2} Fahrenheit");
        }
    }
}
