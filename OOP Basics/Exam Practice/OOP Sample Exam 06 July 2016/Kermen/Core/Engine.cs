namespace Kermen.Core
{
    using Kermen.Core.Interfaces;
    using Kermen.Data;
    using Kermen.Data.Interfaces;
    using Kermen.UserInterface.Interfaces;

    public class Engine : IEngine
    {
        private const string EndCommand = "Democracy";

        private readonly IDatabase kermenDatabase;
        private readonly IHomesController homesController;
        private readonly IIManager inputManager;
        private readonly ICommandExecutor commandExecutor;
        private readonly IUserInterface consoleUi;
        public Engine(IDatabase database, IUserInterface consoleUi)
        {
            this.kermenDatabase = database;
            this.consoleUi = consoleUi;
            this.homesController = new HomesController(this.kermenDatabase, this.consoleUi);
            this.inputManager = new InputManager();
            this.commandExecutor = new CommandExecutor();
        }

        public void Run()
        {
            var index = 1;
            while (true)
            {
                var input = this.consoleUi.ReadLine();

                var commandName = this.inputManager.ParseCommand(input);
                var commandParams = this.inputManager.ParseCommandParams(input);

                if (commandName == EndCommand)
                {
                    this.commandExecutor.ExecuteCommand(EndCommand, this.kermenDatabase, this.homesController, null);
                    break;
                }

                if (index % 3 == 0)
                {
                    if (commandName == "Evn bill")
                    {
                        this.commandExecutor.ExecuteCommand("Pay salaries and pensions", this.kermenDatabase, this.homesController, null);
                        this.commandExecutor.ExecuteCommand(commandName, this.kermenDatabase, this.homesController, commandParams);
                        continue;
                    }

                    this.commandExecutor.ExecuteCommand(commandName, this.kermenDatabase, this.homesController, commandParams);
                    this.commandExecutor.ExecuteCommand("Pay salaries and pensions", this.kermenDatabase, this.homesController, null);
                    continue;
                }

                this.commandExecutor.ExecuteCommand(commandName, this.kermenDatabase, this.homesController, commandParams);
                index++;
            }
        }
    }
}
