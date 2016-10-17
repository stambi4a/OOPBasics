namespace Problem_06.Animals
{
    using System;

    public class Animal : IAnimal
    {
        private string name;
        private long age;

        public Animal(string animalName, long age, Gender gender)
        {
            this.Age = age;
            this.Name = animalName;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }

        public long Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }

        public Gender Gender { get; set; }

        public virtual void ProduceSound()
        {
            Console.WriteLine("Not implemented!");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}{Environment.NewLine}" + 
                $"{this.Name} {this.Age} {this.Gender}";
        }
    }
}
