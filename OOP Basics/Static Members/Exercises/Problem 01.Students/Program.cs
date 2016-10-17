namespace Problem_01.Students
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var student = new Student(input);
            }

            Console.WriteLine(Student.Counter);
        }
    }

    internal class Student
    {
        internal Student(string name)
        {
            this.Name = name;
            Counter++;
        }

        internal static int Counter { get; set; }
        internal string Name { get; set; }
    }
}
