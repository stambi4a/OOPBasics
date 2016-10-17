namespace Problem_03.Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private const int MinimalSalary = 10;
        private const int DaysInAWeek = 5;
        private const int MinWorkingHours = 1;
        private const int MaxWorkingHours = 12;
        private decimal salary;
        private decimal workingHours;

        public Worker(string firstName, string lastName, decimal salary, decimal workingHours) : base(firstName, lastName)
        {
            this.Salary = salary;
            this.WorkingHours = workingHours;
            this.CalculateSalaryPerHour();
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < MinimalSalary)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.salary = value;
            }
        }

        public decimal WorkingHours
        {
            get
            {
                return this.workingHours;
            }

            set
            {
                if (value < MinWorkingHours || value > MaxWorkingHours)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workingHours = value;
            }
        }

        public decimal SalaryPerHour { get; set; }

        private void CalculateSalaryPerHour()
        {
            this.SalaryPerHour = this.Salary / (DaysInAWeek * this.WorkingHours);
        }

        public override string ToString()
        {
            var studentBuilder = new StringBuilder();
            studentBuilder.Append("First Name: ")
                .Append(this.FirstName)
                .Append(Environment.NewLine)
                .Append("Last Name: ")
                .Append(this.LastName)
                .Append(Environment.NewLine)
                .Append("Week Salary: ")
                .Append($"{this.Salary:f2}")
                .Append(Environment.NewLine)
                .Append("Hours per day: ")
                .Append($"{this.WorkingHours:f2}")
                .Append(Environment.NewLine)
                .Append("Salary per hour: ")
                .Append($"{this.SalaryPerHour:f2}");
            return studentBuilder.ToString();
        }
    }
}
