namespace Problem_06.Prime_Checker
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var num = new Number(number);
            var nextPrimeNumber = num.FindNextPrimeNumber();
            Console.Write(nextPrimeNumber.Num);
            Console.Write(", ");
            Console.WriteLine(num.IsPrime.ToString().ToLower());
        }
    }

    internal class Number
    {
        internal Number(int number)
        {
            this.Num = number;
            this.CheckIfPrime();
        }

        internal int Num { get; set; }

        internal bool IsPrime { get; set; }

        internal void CheckIfPrime()
        {
            if (this.Num <= 3)
            {   
                this.IsPrime = true;
                return;
            }

            var limit = (int)Math.Sqrt(this.Num);
            for(var i = 2; i <= limit; i++)
            {
                if (this.Num % i == 0)
                {
                    return;
                }
            }

            this.IsPrime = true;
        }

        internal Number FindNextPrimeNumber()
        {
            var number = this.Num + 1;
            if (number <= 3)
            {
                return new Number(number);
            }

            while (true)
            {
                var limit = (int)Math.Sqrt(number);
                var prime = true;
                for (var i = 2; i <= limit; i++)
                {
                    if (number % i == 0)
                    {
                        prime = false ;
                        break;
                    }
                }

                if (prime)
                {
                    return new Number(number);
                }

                number++;
            }
        }
    }
}
