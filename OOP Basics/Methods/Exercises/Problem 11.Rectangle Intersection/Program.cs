namespace Problem_11.Rectangle_Intersection
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var rectangleCount = decimal.Parse(input[0]);
            var intersectionChecks = decimal.Parse(input[1]);

            var rectangles = new Dictionary<string, Rectangle>();
            for (var i = 0; i < rectangleCount; i++)
            {
                input = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var id = input[0];
                var width = decimal.Parse(input[2]);
                var height = decimal.Parse(input[2]);
                var bottomXCoord = decimal.Parse(input[3]);
                var bottomYCoord = decimal.Parse(input[4]);
                var rectangle = new Rectangle(id, width, height, bottomXCoord, bottomYCoord);

                rectangles.Add(id, rectangle);
            }

            for (var i = 0; i < intersectionChecks; i++)
            {
                input =  Console.ReadLine().Trim().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var firstId = input[0];
                var secondId = input[1];
                Console.WriteLine(rectangles[firstId].CheckIfIntersect(rectangles[secondId]).ToString().ToLower());
            }
        }
    }

    internal class Rectangle
    {
        internal Rectangle(string id, decimal width, decimal height, decimal xCoord, decimal yCoord)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.TopLeftXCoordinate = xCoord;
            this.TopLeftYCoordinate = yCoord;
        }

        internal string Id { get; set; }

        internal decimal Width { get; set; }

        internal decimal Height { get; set; }

        internal decimal TopLeftXCoordinate { get; set; }

        internal decimal TopLeftYCoordinate { get; set; }

        internal bool CheckIfIntersect(Rectangle other)
        {
            var otherBottomRightXCoord = other.TopLeftXCoordinate + other.Width;
            var otherBottomRightYCoord = other.TopLeftYCoordinate - other.Height;
            var thisBottomRightXCoord = this.TopLeftXCoordinate + this.Width;
            var thisBottomRightYCoord = this.TopLeftYCoordinate - this.Height;
            if (this.TopLeftXCoordinate > otherBottomRightXCoord ||
                thisBottomRightXCoord < other.TopLeftXCoordinate ||
                this.TopLeftYCoordinate < otherBottomRightYCoord ||
                thisBottomRightYCoord > other.TopLeftYCoordinate)
            {
                return false;
            }

            return true;
        }
    }
}
