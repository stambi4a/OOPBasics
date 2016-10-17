namespace Problem_06.Animals
{
    using System;

    public class Kitten : Animal
    {
        public Kitten(string name, long age, Gender gender = Gender.Female)
            : base(name, age, gender)
        {
            
        }


        public override void ProduceSound()
        {
            Console.WriteLine("Miau");
        }
    }
}
