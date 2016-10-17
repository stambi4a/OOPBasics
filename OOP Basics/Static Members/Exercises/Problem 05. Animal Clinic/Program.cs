namespace Problem_05.Animal_Clinic
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var animalClinic = new AnimalClinic();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                var input = line.Split();
                var name = input[0];
                var breed = input[1];
                var animal = new Animal(name, breed);
                var treatment = input[2];
                if (treatment == "heal")
                {
                    animalClinic.HealAnimal(animal);
                }
                else
                {
                    animalClinic.RehabilitateAnimal(animal);
                }
            }

            animalClinic.GetHealedAnimalsCount();
            animalClinic.GetRehabilitatedAnimalsCount();
            var treatmentType = Console.ReadLine();
            if (treatmentType == "heal")
            {
                animalClinic.GetHealedAnimals();
            }
            else
            {
                animalClinic.GetRehabilitatedAnimals();
            }
        }
    }

    internal class Animal
    {
        internal Animal(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        internal string Name { get; set; }

        internal string Breed { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Breed}";
        }
    }

    internal class AnimalClinic
    {
        internal AnimalClinic()
        {
            HealedAnimals = new List<Animal>();
            RehabilitatedAnimals = new List<Animal>();
            PatientsCounter = 0;
        }

        private const string HealedMessage = "Patient {0}: [{1} ({2})] has been healed!";
        private const string RehabilitatedMessage = "Patient {0}: [{1} ({2})] has been rehabilitated!";
        private const string TotalHealedMessage = "Total healed animals: {0}";
        private const string TotalRehabilitatedMessage = "Total rehabilitated animals: {0}";

        internal static int PatientsCounter { get; set; }

        internal static List<Animal> RehabilitatedAnimals { get; set; }

        internal static List<Animal> HealedAnimals { get; set; }

        internal void HealAnimal(Animal animal)
        {
            HealedAnimals.Add(animal);
            PatientsCounter++;
            Console.WriteLine(HealedMessage, PatientsCounter, animal.Name, animal.Breed);
        }

        internal void RehabilitateAnimal(Animal animal)
        {
            RehabilitatedAnimals.Add(animal);
            PatientsCounter++;
            Console.WriteLine(RehabilitatedMessage, PatientsCounter, animal.Name, animal.Breed);
        }

        internal void GetHealedAnimalsCount()
        {
            Console.WriteLine(TotalHealedMessage, HealedAnimals.Count);
        }

        internal void GetRehabilitatedAnimalsCount()
        {
            Console.WriteLine(TotalRehabilitatedMessage, RehabilitatedAnimals.Count);
        }

        internal void GetHealedAnimals()
        {
            Console.WriteLine(string.Join(Environment.NewLine, HealedAnimals));
        }

        internal void GetRehabilitatedAnimals()
        {
            Console.WriteLine(string.Join(Environment.NewLine, RehabilitatedAnimals));
        }
    }
}
