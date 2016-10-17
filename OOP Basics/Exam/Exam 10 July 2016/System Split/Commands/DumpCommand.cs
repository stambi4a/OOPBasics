namespace System_Split.Commands
{
    using Data;

    public class DumpCommand : DumpManipulationCommand
    {
        private const string DumpCommandName = "Dump";

        public DumpCommand(string[] commandParams)
            : base(DumpCommandName, commandParams)
        {
        }
    }
}
