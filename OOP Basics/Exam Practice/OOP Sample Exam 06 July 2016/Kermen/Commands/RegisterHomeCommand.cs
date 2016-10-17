namespace Kermen.Commands
{
    using System.Collections.Generic;

    using Kermen.Data.Interfaces;
    using Kermen.Factories;

    public class RegisterHomeCommand : Command
    {
        private readonly string homeType;

        public RegisterHomeCommand(string homeType)
        {
            this.homeType = homeType;
        }

        public override void Execute(
            IHomesController homesController,
            IList<IList<double>> commandParams)
        {
            var home = HomeFactory.CreateHome(this.homeType, commandParams);
            homesController.AddHome(home);
        }
    }
}
