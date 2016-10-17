namespace Problem_03.Mankind
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student : Human
    {
        private string faculytNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string FirstName
        {
            get
            {
                return base.FirstName;
            }

            protected set
            {
                if (!base.CheckName(value))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }

                if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
                
                base.FirstName = value;
            }
        }
        public string FacultyNumber
        {
            get
            {
                return this.faculytNumber;
            }

            set
            {
                if (!this.CheckFacultyNumberRule(value))
                {
                    throw new ArgumentException("Invalid faculty number!"); 
                }
                this.faculytNumber = value;
            }
        }

        private bool CheckFacultyNumberRule(string facultyNumber)
        {
            return Regex.IsMatch(facultyNumber, "^[A-Za-z0-9]{5,10}$");
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
                .Append("Faculty number: ")
                .Append(this.FacultyNumber);
            return studentBuilder.ToString();
        }
    }
}
