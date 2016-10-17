namespace Vegetable_Ninja.Factories
{
    using System;

    using Vegetable_Ninja.Commands.Interfaces;

    public class CommandFactory 
    {
        public static ICommand CreateCommand(char commandValue)
        {
            var type = Type.GetType($"Vegetable_Ninja.Commands.{commandValue}Command");

            var command = (ICommand)Activator.CreateInstance(type);

            return command;
        }
    }
}
