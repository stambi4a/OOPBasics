namespace System_Split.Models
{
    using System_Split.Enumerations;

    public class LightSoftwareComponent : SoftwareComponent
    {
        private const decimal DefaultLightSoftwareCapacityIncrease = 0.5m;
        private const decimal DefaultLightSoftwareMemoryIncrease = -0.5m;
        private const SoftwareComponentType DefaultLightSoftwareType = SoftwareComponentType.Light;

        public LightSoftwareComponent(string name, int capacity, int memory)
            : base(name, capacity, memory, DefaultLightSoftwareType, DefaultLightSoftwareCapacityIncrease, DefaultLightSoftwareMemoryIncrease)
        {
        }
    }
}
