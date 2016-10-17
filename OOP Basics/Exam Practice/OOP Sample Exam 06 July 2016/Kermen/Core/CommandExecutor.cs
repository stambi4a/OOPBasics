namespace Kermen.Core
{
    using System.Collections.Generic;

    using Data.Interfaces;
    using Interfaces;
    using Factories;

    public class CommandExecutor : ICommandExecutor
    {
        public void ExecuteCommand(string commandName, IDatabase database, IHomesController homesController, IList<IList<double>> commandParams)
        {
            var command = CommandFactory.CreateCommand(commandName);
            command.Execute(homesController, commandParams);
        }
    }
}
