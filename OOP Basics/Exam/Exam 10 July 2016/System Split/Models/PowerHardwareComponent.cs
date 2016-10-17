namespace System_Split.Models
{
    using System_Split.Enumerations;

    public class PowerHardwareComponent : HardwareComponent
    {
        private const decimal DefaultPowerHardwareCapacityIncrease = -0.75m;
        private const decimal DefaultPowerHardwareMemoryIncrease = 0.75m;
        private const HardwareComponentType DefaultPowerHardwareType = HardwareComponentType.Power;
        public PowerHardwareComponent(
            string name, 
            int capacity, 
            int memory)
            : base(name, capacity, memory, DefaultPowerHardwareType, DefaultPowerHardwareCapacityIncrease, DefaultPowerHardwareMemoryIncrease)
        {

        }        
    }
}
