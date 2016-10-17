namespace Problem_06.Animals
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, long age, Gender gender)
            : base(name, age, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("BauBau");
        }
    }
}
