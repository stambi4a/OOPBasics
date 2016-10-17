namespace Problem_01.Define_a_class__Person
{
    using System.Data;

    public class Person
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
    }
}
