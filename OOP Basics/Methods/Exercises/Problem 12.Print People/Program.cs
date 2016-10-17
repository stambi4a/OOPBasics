namespace Problem_12.Print_People
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var people = new List<Person>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }

                var input = line.Split();
                var name = input[0];
                var age = int.Parse(input[1]);
                var occupation = input[2];
                var person = new Person(name, age, occupation);
                people.Add(person);
            }

            people.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }

    internal class Person : IComparable<Person>
    {
        internal Person(string name, int age, string occupation)
        {
            this.Name = name;
            this.Age = age;
            this.Occupation = occupation;
        }

        internal string Name { get; set; }

        internal int Age { get; set; }

        internal string Occupation { get; set; }

        public override string ToString()
        {
            return $"{this.Name} - age: {this.Age}, occupation: {this.Occupation}";
        }

        public int CompareTo(Person other)
        {
            return this.Age - other.Age;
        }
    }
}
