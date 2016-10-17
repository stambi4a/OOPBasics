namespace Problem_06.Animals
{
    using System;
    using System.Reflection;

    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var animalType = Console.ReadLine();
                    if (animalType == "Beast!")
                    {
                        break;
                    }

                    var input = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var animalName = input[0];
                    var animalAge = long.Parse(input[1]);
                    Gender gender;
                    if (animalType == "Kitten")
                    {
                        gender = Gender.Female;
                    }

                    else if (animalType == "Tomcat")
                    {
                        gender = Gender.Male;
                    }

                    else
                    {
                        gender = (Gender)Enum.Parse(typeof(Gender), input[2]);
                    }

                    var type = Type.GetType("Problem_06.Animals." + animalType);
                    var animal = Activator.CreateInstance(type, animalName, animalAge, gender) as Animal;

                    Console.WriteLine(animal);
                    animal.ProduceSound();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid input!");
                }

                catch (TargetInvocationException tie)
                {
                    Console.WriteLine(tie.InnerException.Message);
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid input!");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
