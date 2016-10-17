namespace Problem_02.Unique_Student_Names
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var studentGroup = new StudentGroup();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var student = new Student(input);
                studentGroup.AddName(input);
            }

            Console.WriteLine(StudentGroup.Counter);
        }
    }

    internal class Student
    {
        internal Student(string name)
        {
            this.Name = name;
        }
        internal string Name { get; set; }
    }

    internal class StudentGroup
    {
        internal StudentGroup()
        {
            this.UniqueNames = new HashSet<string>();
        }
        internal static int Counter { get; set; }
        internal ISet<string> UniqueNames { get; set; }

        internal void AddName(string name)
        {
            if (!this.UniqueNames.Contains(name))
            {
                this.UniqueNames.Add(name);
                Counter++;
            }
        }
    }
}
