namespace Problem_01.Define_a_class__Person
{
    using System;
    using System.Reflection;

    public class Program
    {
        public static void Main(string[] args)
        {
            var personFirst = new Person() { name = "Pesho", age = 20 };
            var personSecond = new Person() { name = "Gosho", age = 18 };
            var personThird = new Person() { name = "Stamat", age = 43 };
            var personFourth = new Person();
            var personType = typeof(Person);
            var fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }
}
