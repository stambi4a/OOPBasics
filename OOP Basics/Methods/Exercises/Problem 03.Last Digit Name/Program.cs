namespace Problem_03.Last_Digit_Name
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var number = new Number(num);
            var digitName = number.GetNameOfLastDigit();
            Console.WriteLine(digitName);
        }
    }

    internal class Number
    {
        internal Number(int num)
        {
            this.Num = num;
        }

        internal int Num { get; set; }

        internal string GetNameOfLastDigit()
        {
            var digit = Num % 10;
            switch (digit)
            {
                case 0:
                    {
                        return "zero";
                    }

                case 1:
                    {
                        return "one";
                    }

                case 2:
                    {
                        return "two";
                    }

                case 3:
                    {
                        return "three";
                    }

                case 4:
                    {
                        return "four";
                    }

                case 5:
                    {
                        return "five";
                    }

                case 6:
                    {
                        return "six";
                    }

                case 7:
                    {
                        return "seven";
                    }

                case 8:
                    {
                        return "eight";
                    }

                case 9:
                    {
                        return "nine";
                    }

                default:
                    {
                        throw new ArgumentException("Not a digit", digit.ToString());
                    }
            }
        }
    }
}
