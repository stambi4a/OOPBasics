namespace Problem_08.Shapes_Volume
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
                var shape = inputParams[0];

                var objectParams = new object[inputParams.Length - 1];
                for (var i = 1; i < inputParams.Length; i++)
                {
                    objectParams[i - 1]= double.Parse(inputParams[i]);
                }

                var operationMethod = typeof(VolumeCalculator).GetMethod("Calculate" + shape + "Volume", BindingFlags.Static | BindingFlags.Public);
                var result = operationMethod.Invoke(null, objectParams);
                Console.WriteLine($"{result:f3}");
            }
        }
    }

    public class VolumeCalculator
    {
        public static double CalculateTrianglePrismVolume(double baseSide, double height, double length)
        {
            var volume = (1 / 2.0) * (baseSide * height * length);

            return volume;
        }

        public static double CalculateCubeVolume(double side)
        {
            var volume = Math.Pow(side, 3);
            return volume;
        }

        public static double CalculateCylinderVolume(double radius, double height)
        {
            var volume = Math.PI * radius * radius * height;

            return volume;
        }
    }
}
