namespace System_Split.Commands
{
    using System_Split.Data;

    public class RestoreCommand : DumpManipulationCommand
    {
        private const string RestoreCommandName = "Restore";

        public RestoreCommand(string[] commandParams)
            : base(RestoreCommandName, commandParams)
        {
        }
    }
}
