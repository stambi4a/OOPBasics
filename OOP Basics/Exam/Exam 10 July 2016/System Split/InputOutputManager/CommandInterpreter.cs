namespace System_Split.InputOutputManager
{
    using System.Text.RegularExpressions;

    public class CommandInterpreter
    {
        private const string CommandPattern = @"\b(\w+(\s+\w+)*)(\((.*?)\))*";

        public Match ParseInput(string input)
        {
            var regex = new Regex(CommandPattern);
            return regex.Match(input);
        }
        public string ParseCommandName(Match match)
        {
            return match.Groups[1].Value;
        }

        public string[] ParseCommandParams(Match match)
        {
            return Regex.Split(match.Groups[4].Value, ",\\s+");
        }
    }
}
