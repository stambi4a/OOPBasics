namespace Problem_09.Google
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var persons = new Dictionary<string, Person>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var inputParams = input.Trim().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                CreatePersonsDatabase(inputParams, persons);
            }

            var personName = Console.ReadLine();
            if (persons.ContainsKey(personName))
            {
                var person = persons[personName];
                Console.WriteLine(person);
            }         
        }

        private static void CreatePersonsDatabase(IReadOnlyList<string> inputParams, Dictionary<string, Person> persons)
        {
            var name = inputParams[0];
            if (!persons.ContainsKey(name))
            {
                persons.Add(name, new Person(name));
            }

            var attribute = inputParams[1];
            switch (attribute)
            {
                case "company":
                    {
                        var workplace = CreateWorkplace(inputParams);
                        persons[name].ChangeWorkPlace(workplace);
                    }

                    break;

                case "car":
                    {
                        var car = CreateCar(inputParams);
                        persons[name].ChangeCar(car);
                    }

                    break;

                case "pokemon":
                    {
                        var pokemon = CreatePokemon(inputParams);
                        persons[name].AddPokemon(pokemon);
                    }

                    break;
                case "parents":
                    {
                        var parent = CreateRelative(inputParams);
                        var parentName = inputParams[2];
                        if (name != parentName)
                        {
                            persons[name].AddParent(parentName, parent);
                        }
                    }

                    break;

                case "children":
                    {
                        var child = CreateRelative(inputParams);
                        var childName = inputParams[2];
                        persons[name].AddChild(childName, child);
                    }

                    break;

                default:
                    {
                        throw new ArgumentException("Invalid Person Info Unit", attribute);
                    }

            }
        }

        private static WorkPlace CreateWorkplace(IReadOnlyList<string> inputParams)
        {
            var company = inputParams[2];
            var department = inputParams[3];
            var salary = decimal.Parse(inputParams[4]);

            return new WorkPlace(company, department, salary);
        }

        private static Car CreateCar(IReadOnlyList<string> inputParams)
        {
            var model = inputParams[2];
            var speed = int.Parse(inputParams[3]);

            return new Car(model, speed);
        }

        private static Pokemon CreatePokemon(IReadOnlyList<string> inputParams)
        {
            var name = inputParams[2];
            var element = inputParams[3];

            return new Pokemon(name, element);
        }

        private static Relative CreateRelative(IReadOnlyList<string> inputParams)
        {
            var name = inputParams[2];
            var birthDate = inputParams[3];

            return new Relative(name, birthDate);
        }
    }
}
