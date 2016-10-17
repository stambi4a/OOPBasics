namespace System_Split
{
    using System_Split.Core;
    using System_Split.Data;

    public class Launcher
    {
        private static void Main(string[] args)
        {
            ComponentsDatabase componentsDatabse = new ComponentsDatabase();
            var engine = new Engine(componentsDatabse);
            engine.Run();
        }
    }
}
