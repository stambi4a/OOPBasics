namespace Problem_06.Animals
{
    using System;

    public class Tomcat : Animal
    {
        public Tomcat(string name, long age, Gender gender = Gender.Male)
            : base(name, age, gender)
        {
            
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Give me one million b***h");
        }
    }
}
