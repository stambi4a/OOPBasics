namespace System_Split.Commands
{
    public class DumpAnalyzeCommand : CommonAnalyzeCommand
    {
        private const string DumpAnalyzeCommandName = "DumpAnalyze";

        public DumpAnalyzeCommand(string[] commandParams)
            : base(DumpAnalyzeCommandName, commandParams)
        {
        }
    }
}
