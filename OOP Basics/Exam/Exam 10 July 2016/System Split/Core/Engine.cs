namespace System_Split.Core
{
    using System_Split.Data;
    using System_Split.Factories;
    using System_Split.InputOutputManager;

    public class Engine
    {
        private readonly ComponentsDatabase componentsDatabase;
        private readonly ComponentsController componentsController;
        private readonly InputReader inputManager;
        private readonly CommandInterpreter commandInterpreter;

        public Engine(ComponentsDatabase database)
        {
            this.componentsDatabase = database;
            this.componentsController = new ComponentsController(this.componentsDatabase);
            this.inputManager = new InputReader();
            this.commandInterpreter = new CommandInterpreter();
        }

        public void Run()
        {
            while (true)
            {
                var inputLine = this.inputManager.ReadLine();
                var match = this.commandInterpreter.ParseInput(inputLine);
                var commandName = this.commandInterpreter.ParseCommandName(match);
                if (commandName == "System Split")
                {
                    commandName = string.Join("", commandName.Split());
                }
                var commandParams = this.commandInterpreter.ParseCommandParams(match);

                var command = CommandFactory.CreateCommand(commandName, commandParams);
                command.Execute(commandName, commandParams, this.componentsController);
                if (commandName == "SystemSplit")
                {
                    break;
                }
            }  
        }
    }
}
