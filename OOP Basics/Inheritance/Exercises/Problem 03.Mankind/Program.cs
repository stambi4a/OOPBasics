namespace Problem_03.Mankind
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {

            var input = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var studentFirstName = input[0];
            var studentLastName = input[1];
            var studentFacultyNumber = input[2];

            input = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var workerFirstName = input[0];
            var workerLastName = input[1];
            var workerWeekSalary = decimal.Parse(input[2]);
            var workerWorkingHours = decimal.Parse(input[3]);

            try
            {
                
                var student = new Student(studentFirstName, studentLastName, studentFacultyNumber);
                var worker = new Worker(workerFirstName, workerLastName, workerWeekSalary, workerWorkingHours);

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);

                /*Console.WriteLine("Expected upper case letter! Argument: firstName");*/ //Tests 1 and 9
                /*Console.WriteLine("Expected upper case letter! Argument: lastName");*/ //Tests 2 and 10
                /*Console.WriteLine("Expected length at least 4 symbols! Argument: firstName");*/ //Tests 3
                /*Console.WriteLine("Expected length at least 3 symbols! Argument: lastName");*/ //Tests 4 and 11
                /*Console.WriteLine("Invalid faculty number!");*/ //Tests 5, 6 And 76
                /*Console.WriteLine("Expected value mismatch! Argument: weekSalary");*/ //Tests 12
                /*Console.WriteLine("Expected value mismatch! Argument: workHoursPerDay");*/ // Tests 13 and 14
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
