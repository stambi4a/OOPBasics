namespace Problem_10.Date_Modifier
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var firstInput = Console.ReadLine();
            var secondInput = Console.ReadLine();

            var dateModifier = new DateModifier(firstInput, secondInput);
            dateModifier.GetDayDifference();
        }
    }

    internal class DateModifier
    {
        internal DateModifier(string firstInput, string secondInput)
        {
            this.FindDateDifference(firstInput, secondInput);
        }

        internal TimeSpan DayDifference { get; set; }

        internal void FindDateDifference(string firstInput, string secondInput)
        {
            /*var inputParams = firstInput.Split();
            var year = int.Parse(inputParams[0]);
            var month = int.Parse(inputParams[1]);
            var day = int.Parse(inputParams[2]);
            var firstDate = new DateTime(year, month, day);

            inputParams = secondInput.Split();
            year = int.Parse(inputParams[0]);
            month = int.Parse(inputParams[1]);
            day = int.Parse(inputParams[2]);
            var secondDate = new DateTime(year, month, day);
            this.DayDifference = Math.Abs((firstDate - secondDate).Days);*/

            var firstDate = DateTime.Parse(firstInput);
            var secondDate = DateTime.Parse(secondInput);

            
            this.DayDifference = secondDate - firstDate;
        }

        internal void GetDayDifference()
        {
            Console.WriteLine(Math.Abs(this.DayDifference.TotalDays));
        }
    }


}
