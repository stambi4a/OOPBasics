namespace P03_AnimalFarm
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;

    using Models;

    public class Program
    {
        public static void Main(string[] args)
        {
            var chickenType = typeof(Chicken);
            var fields = chickenType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            var methods = chickenType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            Debug.Assert(fields.Count(f => f.IsPrivate) == 2);
            Debug.Assert(methods.Count(m => m.IsPrivate) == 1);

            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            try
            {
                Chicken chicken = new Chicken(name, age);
                Console.WriteLine(
                    "Chicken {0} (age {1}) can produce {2} eggs per day.",
                    chicken.Name,
                    chicken.Age,
                    chicken.GetProductPerDay());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
