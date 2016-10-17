namespace Problem_04.Number_In_Reversed_Number
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var decimalNumber = decimal.Parse(Console.ReadLine());
            var decimalNum = new DecimalNumber(decimalNumber);
            decimalNum.PrintNumberInReverseOrder();
        }
    }

    internal class DecimalNumber
    {
        internal DecimalNumber(decimal decim)
        {
            this.Decimal = decim;
        }

        internal decimal Decimal { get; set; }

        internal void PrintNumberInReverseOrder()
        {
            /*var reverseBuilder = new StringBuilder();
            var intPart = (int)this.Decimal;
            var decimalPart = this.Decimal - intPart;
            var decimalIntPart = decimalPart
            while (true)
            {
               
            }*/

            var strCharArray= this.Decimal.ToString().ToCharArray();
            var reversedSequence = strCharArray.Reverse();


            Console.WriteLine(string.Join(string.Empty, reversedSequence));
        }
    }
}
