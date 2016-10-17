namespace Kermen.Commands.Interfaces
{
    using System.Collections.Generic;

    using Kermen.Data.Interfaces;

    public interface ICommand
    {
        void Execute(IHomesController homesController, IList<IList<double>> commandParams);
    }
}
