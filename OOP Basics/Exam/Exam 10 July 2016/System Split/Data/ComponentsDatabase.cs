namespace System_Split.Data
{
    using System.Collections.Generic;

    using Models;

    public class ComponentsDatabase
    {
        public ComponentsDatabase()
        {
            this.HardwareComponents = new Dictionary<string, HardwareComponent>();
            this.DumpedComponents = new Dictionary<string, HardwareComponent>();
        }

        public IDictionary<string, HardwareComponent> HardwareComponents { get; }
        public IDictionary<string, HardwareComponent> DumpedComponents { get; }
    }
}
