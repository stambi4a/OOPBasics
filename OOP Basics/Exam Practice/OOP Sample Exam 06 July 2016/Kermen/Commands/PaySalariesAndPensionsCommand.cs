namespace Kermen.Commands
{
    using System.Collections.Generic;

    using Data.Interfaces;

    public class PaySalariesAndPensionsCommand : Command
    {
        public override void Execute(
            IHomesController homesController,
            IList<IList<double>> commandParams)
        {
            homesController.PaySalariesAndPensions();
        }
    }
}
