namespace System_Split.Commands
{
    using System_Split.Data;

    public abstract class DumpManipulationCommand : Command
    {
        protected DumpManipulationCommand(string commandName, string[] commandParams)
            : base(commandName, commandParams)
        {
        }

        public override void Execute(string commandName, string[] commandParams, ComponentsController controller)
        {
            var methodInfo = controller.GetType().GetMethod(commandName);
            var hardwarecomponent = commandParams[0];
            methodInfo.Invoke(controller, new object[] { hardwarecomponent });
        }
    }
}
