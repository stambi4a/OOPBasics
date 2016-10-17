namespace System_Split.Commands
{
    using System_Split.Data;

    public class RegisterSoftwareCommand : Command
    {
        protected RegisterSoftwareCommand(string commandName, string[] commandParams)
            : base(commandName, commandParams)
        {

        }

        public override void Execute(string commandName, string[] commandParams, ComponentsController controller)
        {
            var hardwareComponentName = commandParams[0];
            var name = commandParams[1];
            var capacity = int.Parse(commandParams[2]);
            var memory = int.Parse(commandParams[3]);

            var methodInfo = controller.GetType().GetMethod(commandName);
            methodInfo.Invoke(controller, new object[] { hardwareComponentName, name, capacity, memory });
        }
    }
}
