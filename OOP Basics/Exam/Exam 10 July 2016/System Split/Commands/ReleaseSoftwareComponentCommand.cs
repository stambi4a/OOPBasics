namespace System_Split.Commands
{
    using System_Split.Data;

    public class ReleaseSoftwareComponentCommand : Command
    {
        private const string ReleaseSoftwareCommandName = "ReleaseSoftwareComponent";
        public ReleaseSoftwareComponentCommand(string[] commandParams)
            : base(ReleaseSoftwareCommandName, commandParams)
        {
        }

        public override void Execute(string commandName, string[] commandParams, ComponentsController controller)
        {
            var hardwareComponentName = commandParams[0];
            var softwareComponentName = commandParams[1];
            var methodInfo = controller.GetType().GetMethod(commandName);
            methodInfo.Invoke(controller, new object[] { hardwareComponentName, softwareComponentName });
        }
    }
}
