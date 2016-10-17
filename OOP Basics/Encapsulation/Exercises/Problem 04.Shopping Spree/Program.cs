namespace Problem_04.Shopping_Spree
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var people = new Dictionary<string, Person>();
            var products = new Dictionary<string, Product>();

            try
            {
                CreatePeopleDatabase(people);
                CreateProductsDatabase(products);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }

                var input = line.Split();
                var productName = input[1];
                var personName = input[0];
                people[personName].TryBuyProduct(products[productName]);
            }

            PrintPeopleWithProducts(people.Values);
        }

        private static void CreatePeopleDatabase(Dictionary<string, Person> people)
        {
            var peopleInput = Console.ReadLine().Trim().Split(new [] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var input in peopleInput)
            {
                var inputParams = input.Split('=');
                var name = inputParams[0];
                var money = int.Parse(inputParams[1]);
                var person = new Person(name, money);
                people.Add(name, person);
            }
        }

        private static void CreateProductsDatabase(Dictionary<string, Product> products)
        {
            var productsInput = Console.ReadLine().Trim().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var input in productsInput)
            {
                var inputParams = input.Split('=');
                var name = inputParams[0];
                var price = int.Parse(inputParams[1]);
                var product = new Product(name, price);
                products.Add(name, product);
            }
        }

        private static void PrintPeopleWithProducts(IEnumerable<Person> people)
        {
            foreach (var person in people)
            {
                person.PrintPurchases();
            }
        }
    }
}
