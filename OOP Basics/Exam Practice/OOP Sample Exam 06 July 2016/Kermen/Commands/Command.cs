namespace Kermen.Commands
{
    using System.Collections.Generic;

    using Interfaces;

    using Data.Interfaces;

    public abstract class Command : ICommand
    {
        public abstract void Execute(IHomesController homesController, IList<IList<double>> commandParams);
    }
}
