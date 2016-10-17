namespace System_Split.Commands
{
    using System_Split.Data;

    public class RegisterHardwareCommand : Command
    {
        protected RegisterHardwareCommand(string commandName, string[] commandParams)
            : base(commandName, commandParams)
        {      
        }

        public override void Execute(string commandName, string[] commandParams, ComponentsController controller)
        {
            var name = commandParams[0];
            var capacity = int.Parse(commandParams[1]);
            var memory = int.Parse(commandParams[2]);

            var methodInfo = controller.GetType().GetMethod(commandName);
            methodInfo.Invoke(controller, new object[] { name, capacity, memory });
        }
    }
}
