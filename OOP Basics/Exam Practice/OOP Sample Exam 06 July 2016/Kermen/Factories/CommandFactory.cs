namespace Kermen.Factories
{
    using System;

    using Kermen.Commands;
    using Kermen.Commands.Interfaces;

    public class CommandFactory
    {
        public static ICommand CreateCommand(string commandName, params object[] commandParams)
        {
            ICommand command = null;
            if (commandName == "EVN")
            {
                return new ShowConsumptionCommand();
            }

            if (commandName == "EVN bill")
            {
                return new PayElectricityBillCommand();
            }

            if (commandName == "Pay salaries and pensions")
            {
                return new PaySalariesAndPensionsCommand();
            }

            if (commandName == "Democracy")
            {
                return new ShowPopulationCommand();
            }

            var type = Type.GetType("Kermen.Commands.Register" + commandName + "HomeCommand");
            command = (ICommand)Activator.CreateInstance(type);

            return command;
        }
    }
}
