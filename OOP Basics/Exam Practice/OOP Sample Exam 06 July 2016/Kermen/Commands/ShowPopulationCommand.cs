namespace Kermen.Commands
{
    using System.Collections.Generic;

    using Kermen.Data.Interfaces;

    public class ShowPopulationCommand : Command
    {
        public override void Execute(IHomesController homesController, IList<IList<double>> commandParams)
        {
            homesController.PrintTotalPopulation();
        }
    }
}
