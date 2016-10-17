namespace Problem_01.Method_Says_Hello
{
    using System;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] methods = personType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            if (fields.Length != 1 || methods.Length != 5)
            {
                throw new Exception();
            }

            string personName = Console.ReadLine();
            Person person = new Person(personName);

            Console.WriteLine(person.SayHello());
        }
    }

    public class Person
    {
        public Person(string name)
        {
            this.name = name;
        }

        private const string Greeting = @"{0} says ""Hello""!";
        public string name;

        public string SayHello()
        {
            return string.Format(Greeting, name);
        }
    }
}
