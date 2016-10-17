namespace Problem_02.Oldest_Family_Member
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class Program
    {
        private static void Main(string[] args)
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var memberCount = int.Parse(Console.ReadLine());
            var family = new Family();
            for (var i = 0; i < memberCount; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);
                var person = new Person(name, age);
                family.AddMember(person);
            }

            var oldestMember = family.GetOldestMember();
            Console.WriteLine(oldestMember.Name + " " + oldestMember.Age);
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }

    public class Family
    {
        public Family()
        {
            this.FamilyMembers = new List<Person>();
        }

        public List<Person> FamilyMembers { get; set; }

        public void AddMember(Person member)
        {
            this.FamilyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            var maxAge = this.FamilyMembers.Max(member => member.Age);
            var oldestMember = this.FamilyMembers.First(member => member.Age == maxAge);

            return oldestMember;
        }
    }

}
