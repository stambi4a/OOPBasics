namespace Problem_03.Opoinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Problem_01.Define_a_class__Person;

    internal class Program
    {
        private static void Main(string[] args)
        {
            CreateOpinionPoll();
        }

        private static List<Person> FindPeopleInGivenAgeRange(List<Person> people)
        {
            return people.Where(person => person.age > 30).ToList();
        }

        private static void SortPeopleAlphabetically(List<Person> people)
        {
            people.Sort();
        }

        private static void CreateOpinionPoll()
        {
            var numPeople = int.Parse(Console.ReadLine());
            var people = new List<Person>();
            for (var i = 0; i < numPeople; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);
                var person = new Person(name, age);
                people.Add(person);
            }

            people = FindPeopleInGivenAgeRange(people);
            SortPeopleAlphabetically(people);
            PrintPeople(people);
        }

        private static void PrintPeople(List<Person> people)
        {
            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }
}
