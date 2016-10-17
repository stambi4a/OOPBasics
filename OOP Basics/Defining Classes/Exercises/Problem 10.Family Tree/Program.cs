namespace Problem_10.Family_Tree
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text.RegularExpressions;

    internal class Program
    {
        private static void Main(string[] args)
        {
            CreateFamilyTree();
        }

        private static void CreateFamilyTree()
        {
            var personToInvestigate = Console.ReadLine();
            var peopleData = new List<string>();
            var relationsData = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                if (input.Contains("-"))
                {
                    relationsData.Add(input);
                }
                else
                {
                    peopleData.Add(input);
                }
            }

            var people = new Dictionary<string, string>();
            var birthDaysPeople = new Dictionary<string, string>();
            var personWithFamilyTree = CreatePeopleDatabase(peopleData, people, personToInvestigate);
            CreatePeopleDatabaseWithDatesFirst(people, birthDaysPeople, personToInvestigate);
            FindParentsAndChildren(relationsData, people, birthDaysPeople, personWithFamilyTree);
            Console.WriteLine(personWithFamilyTree);
        }

        private static Person CreatePeopleDatabase(IReadOnlyList<string> peopleData, Dictionary<string, string> people, string personToInvestigate)
        {
            Person person = null;
            foreach (var line in peopleData)
            {
                var inputParams = line.Split();
                var name = inputParams[0] + " " + inputParams[1];
                var birthDate = inputParams[2];
                if (name == personToInvestigate || birthDate == personToInvestigate)
                {
                    person = new Person(name, birthDate);
                    continue;
                }

                people.Add(name, birthDate);
            }

            return person;
        }

        private static void CreatePeopleDatabaseWithDatesFirst(
            Dictionary<string, string> people,
            Dictionary<string, string> datesPeople,
            string personToInvestigate)
        {
            foreach (var person in people)
            {
                datesPeople.Add(person.Value, person.Key);
            }
        }

        private static void FindParentsAndChildren(
            IEnumerable<string> relationsData, 
            IDictionary<string, string> people, 
            IDictionary<string, string> birthdaysPeople, 
            Person personToInvestigate)
        {
            var personName = personToInvestigate.Name;
            var personBirthDate = personToInvestigate.BirthDate;
            foreach (var line in relationsData)
            {
                var inputParams = Regex.Split(line, "\\s-\\s");
                if (people.ContainsKey(inputParams[0]) && 
                    (personName == inputParams[1] || personBirthDate == inputParams[1])  && 
                    !personToInvestigate.Parents.ContainsKey(inputParams[0]))
                {
                    personToInvestigate.Parents.Add(inputParams[0], people[inputParams[0]]);
                }

                if (birthdaysPeople.ContainsKey(inputParams[0]) && 
                    !personToInvestigate.Parents.ContainsKey(inputParams[0]) &&
                    (personName == inputParams[1] || personBirthDate == inputParams[1]))
                {
                    personToInvestigate.Parents.Add(birthdaysPeople[inputParams[0]], inputParams[0]);
                }

                if (people.ContainsKey(inputParams[1]) && 
                    !personToInvestigate.Children.ContainsKey(inputParams[1]) &&
                    (personBirthDate == inputParams[0] || personName == inputParams[0]))
                {
                    personToInvestigate.Children.Add(inputParams[1], people[inputParams[1]]);
                }

                if (birthdaysPeople.ContainsKey(inputParams[1]) && 
                    !personToInvestigate.Children.ContainsKey(inputParams[1]) &&
                    (personBirthDate == inputParams[0] || personName == inputParams[0]))
                {
                    personToInvestigate.Children.Add(birthdaysPeople[inputParams[1]], inputParams[1]);
                }
            }
        }
    }
}
