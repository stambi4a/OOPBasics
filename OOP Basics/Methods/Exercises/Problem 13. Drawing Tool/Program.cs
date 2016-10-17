namespace Problem_13.Drawing_Tool
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var shapeName = Console.ReadLine();
            var shapeType = Type.GetType("Problem_13.Drawing_Tool." + shapeName);
            Shape shape = null;
            var width = int.Parse(Console.ReadLine());
            if (shapeName == "Square")
            {
                shape = new Square(width);               
            }
            else
            {
                var height = int.Parse(Console.ReadLine());
                shape = new Rectangle(width, height);
            }
            
            var corDraw = new CorDraw(shape);
            corDraw.DrawShape();
        }
    }

    internal class CorDraw
    {
        internal CorDraw(Shape shape)
        {
            this.Shape = shape;
        }

        internal Shape Shape { get; set; }

        internal void DrawShape()
        {
            this.Shape.DrawShape();
        }
    }

    internal abstract class Shape
    {
        protected const char VerticalSymbol = '|';
        protected const char HorizontalSymbol = '-';

        protected internal Shape(int width)
        {
            this.Width = width;
        }

        protected internal int Width { get; set; }

        protected internal abstract void DrawShape();
    }

    internal class Rectangle : Shape
    {
        internal Rectangle(int width, int height)
            : base(width)
        {
            this.Height = height;
        }

        protected internal int Height { get; set; }

        protected internal override void DrawShape()
        {
            var builder = new List<string>();

            builder.Add(VerticalSymbol + new string(HorizontalSymbol, this.Width) + VerticalSymbol);
            for (var i = 0; i < this.Height - 2; i++)
            {
                builder.Add(VerticalSymbol + new string(' ', this.Width) + VerticalSymbol);
            }

            if (this.Height >= 2)
            {
                builder.Add(VerticalSymbol + new string(HorizontalSymbol, this.Width) + VerticalSymbol);
            }

            Console.WriteLine(string.Join(Environment.NewLine, builder));
        }
    }

    internal class Square : Shape
    {
        internal Square(int width)
            : base(width)
        {
            
        }

        protected internal override void DrawShape()
        {
            var builder = new List<string>();

            builder.Add(VerticalSymbol + new string(HorizontalSymbol, this.Width) + VerticalSymbol);
            for (var i = 0; i < this.Width - 2; i++)
            {
                builder.Add(VerticalSymbol + new string(' ', this.Width) + VerticalSymbol);
            }

            if (this.Width >= 2)
            {
                builder.Add(VerticalSymbol + new string(HorizontalSymbol, this.Width) + VerticalSymbol);
            }

            Console.WriteLine(string.Join(Environment.NewLine, builder));
        }
    }
}
