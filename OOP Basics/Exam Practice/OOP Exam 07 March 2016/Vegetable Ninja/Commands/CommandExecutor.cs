namespace Vegetable_Ninja.Commands
{
    using Interfaces;
    using Factories;

    using Vegetable_Ninja.Models.Interfaces;

    public class CommandExecutor : ICommandExecutor
    {
        public void Execute(char commandValue, int[] currentNinjaCoordinates, IGarden garden)
        {
            var command = this.SelectCommand(commandValue);
            command.Execute(currentNinjaCoordinates, garden);
        }

        private ICommand SelectCommand(char commandValue)
        {
            ICommand command = null;
            command = CommandFactory.CreateCommand(commandValue);

            return command;
        }

    }
}
