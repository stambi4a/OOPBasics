namespace Kermen.Core
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;

    using Interfaces;

    public class InputManager : IIManager
    {
        private const string NumbersPattern = @"\((\d+(\.\d*)?(,\s\d+(\.\d*)?)*)\)";
        private const string CommandPattern = "^[A-Za-z]+(\\s+[A-Za-z]+)*\\b";

        public IList<IList<double>> ParseCommandParams(string input)
        {
            var regex = new Regex(NumbersPattern);
            var matches = regex.Matches(input);
            return (from Match match in matches select Regex.Split(match.Groups[1].Value, ",\\s+")
                    .Select(double.Parse).ToList())
                    .Cast<IList<double>>()
                    .ToList();
        }

        public string ParseCommand(string input)
        {
            var regex = new Regex(CommandPattern);
            var commandName = regex.Match(input).Value;

            return commandName;
        }
    }
}
