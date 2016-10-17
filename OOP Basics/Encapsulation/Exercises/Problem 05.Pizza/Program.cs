namespace Problem_05.Pizza
{
    using System;

    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var input = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Pizza")
                {
                    var pizzaName = input[1];
                    var toppingsCount = int.Parse(input[2]);
                    var pizza = new Pizza(pizzaName, toppingsCount);

                    input = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var flourType = input[1];
                    var bakingTechnique = input[2];
                    var weight = int.Parse(input[3]);
                    var dough = new Dough(weight, flourType, bakingTechnique);
                    pizza.Dough = dough;

                    for (var i = 0; i < toppingsCount; i++)
                    {
                        input = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        var toppingType = input[1];
                        weight = int.Parse(input[2]);
                        var topping = new Topping(weight, toppingType);
                        pizza.AddTopping(topping);
                    }

                    Console.WriteLine(pizza);
                }
                if (input[0] == "Dough")
                {
                    var flourType = input[1];
                    var bakingTechnique = input[2];
                    var weight = int.Parse(input[3]);
                    var dough = new Dough(weight, flourType, bakingTechnique);
                    Console.WriteLine(dough);

                    var line = Console.ReadLine();
                    if (line == "END")
                    {
                        return;
                    }

                    input = line.Trim().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var toppingType = input[1];
                    weight = int.Parse(input[2]);
                    var topping = new Topping(weight, toppingType);
                    Console.WriteLine(topping);
                }
                     
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }          
        }
    }
}
