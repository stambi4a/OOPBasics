namespace System_Split.Factories
{
    using System;

    using System_Split.Commands;

    public class CommandFactory
    {
        public static Command CreateCommand(string commandName, string[] commandParams)
        {
            var type = Type.GetType("System_Split.Commands." + commandName + "Command");
            var command = (Command)Activator.CreateInstance(type, new object[] {commandParams});

            return command;
        }
    }
}