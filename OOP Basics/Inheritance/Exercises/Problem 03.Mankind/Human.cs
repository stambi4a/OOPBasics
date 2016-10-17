namespace Problem_03.Mankind
{
    using System;
    using System.Text.RegularExpressions;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual string FirstName
        {
            get
            {
                return this.firstName;
            }

            protected set
            {
                if (!this.CheckName(value))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            protected set
            {
                if (!this.CheckName(value))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
                this.lastName = value;
            }
        }

        protected bool CheckName(string name)
        {
            return Regex.IsMatch(name, "^[A-Z]");
        }
    }
}
