namespace Kermen.Core.Interfaces
{
    using System.Collections.Generic;

    using Kermen.Data.Interfaces;

    public interface ICommandExecutor
    {
        void ExecuteCommand(string commandName, IDatabase database, IHomesController homesController, IList<IList<double>> commandParams);
    }
}
