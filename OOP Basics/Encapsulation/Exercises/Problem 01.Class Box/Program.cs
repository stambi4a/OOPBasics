namespace Problem_01.Class_Box
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Threading;

    public class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var boxType = typeof(Box);
            var fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var box = new Box(length, width, height);
            var surfaceArea = box.CalculateSurfaceArea();
            var lateralArea = box.CalculateLateralArea();
            var volume = box.CalculateVolume();
            Console.WriteLine($"Surface Area - {surfaceArea:f2}");
            Console.WriteLine($"Lateral Surface Area - {lateralArea:f2}");
            Console.WriteLine($"Volume - {volume:f2}");
        }
    }

    public class Box
    {
        private readonly double length;
        private readonly double height;
        private readonly double width;

        public Box(double length, double widtyh, double height)
        {
            this.length = length;
            this.width = widtyh;
            this.height = height;
        }

        public double CalculateSurfaceArea()
        {
            var surfaceArea = 2 * (this.length * this.width + this.width * this.height + this.length * this.height);

            return surfaceArea;
        }

        public double CalculateLateralArea()
        {
            var surfaceArea = 2 * (this.width * this.height + this.length * this.height);

            return surfaceArea;
        }

        public double CalculateVolume()
        {
            var surfaceArea = this.length * this.width * this.height;

            return surfaceArea;
        }
    }
}
