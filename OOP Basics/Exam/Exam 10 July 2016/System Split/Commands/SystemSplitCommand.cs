namespace System_Split.Commands
{
    using System_Split.Data;

    public class SystemSplitCommand : CommonAnalyzeCommand
    {
        private const string SystemSplitCommandName = "SystemSplit";

        public SystemSplitCommand(string[] commandParams)
            : base(SystemSplitCommandName, commandParams)
        {
        }
    }
}
