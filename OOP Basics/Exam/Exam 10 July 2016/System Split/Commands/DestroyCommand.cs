namespace System_Split.Commands
{
    public class DestroyCommand : DumpManipulationCommand
    {
        private const string DumpCommandName = "Destroy";

        public DestroyCommand(string[] commandParams)
            : base(DumpCommandName, commandParams)
        {
        }
    }
}
