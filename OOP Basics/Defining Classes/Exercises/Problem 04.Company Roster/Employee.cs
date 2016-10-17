namespace Problem_04.Company_Roster
{
    using System;

    public class Employee : IComparable<Employee>
    {

        public string name;
        public decimal salary;
        public string position;
        public string department;
        public string email;
        public int age;

        public Employee(string name, decimal salary, string position, string department, string email, int age)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = email ?? "n/a";
            this.age = age > 0 ? age : -1;
        }

        public override string ToString()
        {
            return $"{this.name} {this.salary:f2} {this.email} {this.age}";
        }

        public int CompareTo(Employee otherPerson)
        {
            return otherPerson.salary.CompareTo(this.salary);
        }
    }
}
