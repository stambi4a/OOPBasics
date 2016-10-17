namespace Problem_01.Define_a_class__Person
{
    using System;
    using System.Data;

    public class Person : IComparable<Person>
    {
        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age)
        {
            this.name = "No name";
            this.age = age;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string name;

        public int age;

        public override string ToString()
        {
            return (this.name + " - " + this.age);
        }

        public int CompareTo(Person otherPerson)
        {
            return this.name.CompareTo(otherPerson.name);
        }
    }
}
