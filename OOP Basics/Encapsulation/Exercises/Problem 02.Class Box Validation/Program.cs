namespace Problem_02.Class_Box_Validation
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
            try
            {
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
            catch (ArgumentException ae)
            {
               Console.WriteLine(ae.Message);
            }
           
           
        }
    }

    public class Box
    {
        private double length;
        private double height;
        private double width;

        public Box(double length, double widtyh, double height)
        {
            this.Length = length;
            this.Width = widtyh;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
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
