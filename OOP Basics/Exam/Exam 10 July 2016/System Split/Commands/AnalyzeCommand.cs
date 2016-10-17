namespace System_Split.Commands
{
    using System_Split.Data;

    public class AnalyzeCommand : CommonAnalyzeCommand
    {
        private const string AnalyzeCommandName = "Analyze";

        public AnalyzeCommand(string[] commandParams)
            : base(AnalyzeCommandName, commandParams)
        {
        }
    }
}
