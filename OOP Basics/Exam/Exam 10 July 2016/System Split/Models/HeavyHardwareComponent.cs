namespace System_Split.Models
{
    using System_Split.Enumerations;

    public class HeavyHardwareComponent : HardwareComponent
    {
        private const decimal DefaultPowerHardwareCapacityIncrease = 1m;
        private const decimal DefaultPowerHardwareMemoryIncrease= -0.25m;
        private const HardwareComponentType DefaultHeavyHardwareType = HardwareComponentType.Heavy;

        public HeavyHardwareComponent(
            string name, 
            int capacity,
            int memory)
            : base(name, capacity, memory, DefaultHeavyHardwareType, DefaultPowerHardwareCapacityIncrease, DefaultPowerHardwareMemoryIncrease)
        {

        }
    }
}
