namespace Kermen.Core.Interfaces
{
    using System.Collections.Generic;

    public interface IIManager
    {
        IList<IList<double>> ParseCommandParams(string input);

        string ParseCommand(string input);
    }
}
