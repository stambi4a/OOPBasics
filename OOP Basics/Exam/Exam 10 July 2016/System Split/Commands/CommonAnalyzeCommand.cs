namespace System_Split.Commands
{
    using System_Split.Data;

    public abstract class CommonAnalyzeCommand : Command
    {
        protected CommonAnalyzeCommand(string name, string[] commandParams)
            : base(name, commandParams)
        {
        }

        public override void Execute(string commandName, string[] commandParams, ComponentsController controller)
        {
            var methodInfo = controller.GetType().GetMethod(commandName);
            methodInfo.Invoke(controller, null);
        }
    }
}
