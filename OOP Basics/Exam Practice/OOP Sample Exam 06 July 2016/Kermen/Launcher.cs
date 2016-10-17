namespace Kermen
{
    using System.Globalization;
    using System.Threading;

    using Kermen.Core;
    using Kermen.Data;
    using Kermen.UserInterface;

    public class Launcher
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var kermenDatabase = new KermenDatabase();
            var consoleUserInterface = new ConsoleUi();
            var engine = new Engine(kermenDatabase, consoleUserInterface);
            engine.Run();
        }
    }
}
