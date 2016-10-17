namespace Kermen.Commands
{
    using System.Collections.Generic;

    using Data.Interfaces;

    public class PayElectricityBillCommand : Command
    {
        public override void Execute(
            IHomesController homesController,
            IList<IList<double>> commandParams)
        {
            var homes = homesController.PayBills();
            foreach (var home in homes)
            {
                homesController.RemoveHome(home);
            }
        }
    }
}
