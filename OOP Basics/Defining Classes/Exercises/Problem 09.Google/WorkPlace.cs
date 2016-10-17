namespace Problem_09.Google
{
    using System;

    internal class WorkPlace
    {
        internal WorkPlace(string company, string department, decimal salary)
        {
            this.Company = company;
            this.Department = department;
            this.Salary = salary;
        }

        internal string Company { get; private set; }

        internal string Department { get; private set; }

        internal decimal Salary { get; private set; }

        public override string ToString()
        {
            return $"{this.Company} {this.Department} { this.Salary:f2}{Environment.NewLine}";
        }
    }
}
