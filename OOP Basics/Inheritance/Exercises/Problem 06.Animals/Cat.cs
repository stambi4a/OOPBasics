namespace Problem_06.Animals
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, long age, Gender gender)
            : base(name, age, gender)
        {
            
        }

        public override void ProduceSound()
        {
            Console.WriteLine("MiauMiau");
        }
    }
}
