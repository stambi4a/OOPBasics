namespace Problem_06.Animals
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, long age, Gender gender)
            : base(name, age, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Frogggg");
        }
    }
}
