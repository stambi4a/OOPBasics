namespace Problem_09.Pizza_time
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text.RegularExpressions;

    internal class Program
    {
        private static void Main(string[] args)
        {
            MethodInfo[] methods = typeof(Pizza).GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Contains("SortedDictionary"));
            if (!containsMethod)
            {
                throw new Exception();
            }

            var input = Console.ReadLine().Split();
            var pizza = new Pizza();
            var orders = pizza.GetPizzaOrders(input);
            pizza.PrintOrders(orders);
        }
    }

    public class Pizza
    {
        public Pizza()
        {
            /*this.Name = name;
            this.Group = group;*/
        }

        public string Name { get; set; }

        public int Group { get; set; }

        public string GetName()
        {
            return this.Name;
        }

        public int GetGroup()
        {
            return this.Group;
        }

        public SortedDictionary<int, List<string>> GetPizzaOrders(params string[] listOfOrders)
        {
            var orders = new SortedDictionary<int, List<string>>();
            foreach (var order in listOfOrders)
            {
                var match = Regex.Match(order, "(\\d+)(\\w+)");
                var group = int.Parse(match.Groups[1].Value);
                var pizzaName = match.Groups[2].Value;
                if (!orders.ContainsKey(group))
                {
                    orders.Add(group, new List<string>());
                }


                orders[group].Add(pizzaName);
            }

            return orders;
        }

        public void PrintOrders(SortedDictionary<int, List<string>> orders)
        {
            foreach (var group in orders)
            {
                Console.WriteLine($"{group.Key} - {string.Join(", ", group.Value)}");
            }
        }
    }
}
