namespace System_Split.Commands
{
    using System_Split.Data;

    public abstract class Command
    {
        protected Command(string commandName, string[] commandParams)
        {
            this.CommandName = commandName;
            this.CommandParams = commandParams;
        }

        public string CommandName { get; protected set; }

        public string[] CommandParams { get; protected set; }

        public abstract void Execute(string commandName, string[] commandParams, ComponentsController controller);
    }
}
